using System;
using System.IO;

using Intersect.Enums;
using Intersect.Server.Entities;
using Intersect.Server.Localization;
using Intersect.Utilities;

using JetBrains.Annotations;

using NCalc;

using Newtonsoft.Json;

namespace Intersect.Server.General
{

    public class Formulas
    {

        private const string FORMULAS_FILE = "resources/formulas.json";

        private static Formulas mFormulas;

        public Formula ExpFormula = new Formula("BaseExp * Power(Gain, Level)");

        public string MagicDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_Defense))";

        public string PhysicalDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_Defense))";

        public string EarthDamage =
            "Random(((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025)";

        public string FireDamage =
           "Random(((BaseDamage + (ScalingStat * ScaleFactor + (100 + V_Fire/100)))) * CritMultiplier * .975, ((BaseDamage + (ScalingStat * ScaleFactor))) * CritMultiplier * 1.025) * (100 / (100 + V_FireResist))";

        public static void LoadFormulas()
        {
            try
            {
                mFormulas = new Formulas();
                if (File.Exists(FORMULAS_FILE))
                {
                    mFormulas = JsonConvert.DeserializeObject<Formulas>(File.ReadAllText(FORMULAS_FILE));
                }

                File.WriteAllText(FORMULAS_FILE, JsonConvert.SerializeObject(mFormulas, Formatting.Indented));

                Expression.CacheEnabled = false;
            }
            catch (Exception ex)
            {
                throw new Exception(Strings.Formulas.missing, ex);
            }
        }

        public static int CalculateDamage(
            int baseDamage,
            DamageType damageType,
            Stats scalingStat,
            int scaling,
            double critMultiplier,
            Entity attacker,
            Entity victim
        )
        {
            if (mFormulas == null)
            {
                throw new ArgumentNullException(nameof(mFormulas));
            }

            if (attacker == null)
            {
                throw new ArgumentNullException(nameof(attacker));
            }

            if (attacker.Stat == null)
            {
                throw new ArgumentNullException(
                    nameof(attacker.Stat), $@"{nameof(attacker)}.{nameof(attacker.Stat)} is null"
                );
            }

            if (victim == null)
            {
                throw new ArgumentNullException(nameof(victim));
            }

            if (victim.Stat == null)
            {
                throw new ArgumentNullException(
                    nameof(victim.Stat), $@"{nameof(victim)}.{nameof(victim.Stat)} is null"
                );
            }

            string expressionString;
            switch (damageType)
            {
                case DamageType.Physical:
                    expressionString = mFormulas.PhysicalDamage;

                    break;
                case DamageType.Magic:
                    expressionString = mFormulas.MagicDamage;

                    break;
                case DamageType.Earth:
                    expressionString = mFormulas.EarthDamage;

                    break;
                case DamageType.Fire:
                    expressionString = mFormulas.FireDamage;

                    break;
                default:
                    expressionString = mFormulas.PhysicalDamage;

                    break;
            }

            var expression = new Expression(expressionString);
            var negate = false;
            if (baseDamage < 0)
            {
                baseDamage = Math.Abs(baseDamage);
                negate = true;
            }

            if (expression.Parameters == null)
            {
                throw new ArgumentNullException(nameof(expression.Parameters));
            }

            try
            {

                expression.Parameters["BaseDamage"] = baseDamage;
                expression.Parameters["ScalingStat"] = attacker.Stat[(int)scalingStat].Value();
                expression.Parameters["ScaleFactor"] = scaling / 100f;
                expression.Parameters["CritMultiplier"] = critMultiplier;
                //atacante
                expression.Parameters["A_Attack"] = attacker.Stat[(int)Stats.Attack].Value();
                expression.Parameters["A_Magic"] = attacker.Stat[(int)Stats.Magic].Value();
                expression.Parameters["A_Defense"] = attacker.Stat[(int)Stats.Defense].Value();
                expression.Parameters["A_Speed"] = attacker.Stat[(int)Stats.Speed].Value();
                expression.Parameters["A_Vitality"] = attacker.Stat[(int)Stats.Vitality].Value();
                expression.Parameters["A_Intelligence"] = attacker.Stat[(int)Stats.Intelligence].Value();
                expression.Parameters["A_Fire"] = attacker.Stat[(int)Stats.Fire].Value();
                expression.Parameters["A_Earth"] = attacker.Stat[(int)Stats.Earth].Value();
                expression.Parameters["A_Ice"] = attacker.Stat[(int)Stats.Ice].Value();
                expression.Parameters["A_Wind"] = attacker.Stat[(int)Stats.Wind].Value();
                expression.Parameters["A_FireResist"] = attacker.Stat[(int)Stats.FireResist].Value();
                expression.Parameters["A_EarthResist"] = attacker.Stat[(int)Stats.EarthResist].Value();
                expression.Parameters["A_WindResist"] = attacker.Stat[(int)Stats.WindResist].Value();
                expression.Parameters["A_IceResist"] = attacker.Stat[(int)Stats.IceResist].Value();
                // victima
                expression.Parameters["V_Attack"] = victim.Stat[(int)Stats.Attack].Value();
                expression.Parameters["V_Magic"] = victim.Stat[(int)Stats.Magic].Value();
                expression.Parameters["V_Defense"] = victim.Stat[(int)Stats.Defense].Value();
                expression.Parameters["V_Speed"] = victim.Stat[(int)Stats.Speed].Value();
                expression.Parameters["V_Vitality"] = victim.Stat[(int)Stats.Vitality].Value();
                expression.Parameters["V_Intelligence"] = victim.Stat[(int)Stats.Intelligence].Value();
                expression.Parameters["V_Fire"] = victim.Stat[(int)Stats.Fire].Value();
                expression.Parameters["V_Earth"] = victim.Stat[(int)Stats.Earth].Value();
                expression.Parameters["V_Ice"] = victim.Stat[(int)Stats.Ice].Value();
                expression.Parameters["V_Wind"] = victim.Stat[(int)Stats.Wind].Value();
                expression.Parameters["V_FireResist"] = victim.Stat[(int)Stats.FireResist].Value();
                expression.Parameters["V_EarthResist"] = victim.Stat[(int)Stats.EarthResist].Value();
                expression.Parameters["V_WindResist"] = victim.Stat[(int)Stats.WindResist].Value();
                expression.Parameters["V_IceResist"] = victim.Stat[(int)Stats.IceResist].Value();


                expression.EvaluateFunction += delegate (string name, FunctionArgs args)
                {
                    if (args == null)
                    {
                        throw new ArgumentNullException(nameof(args));
                    }

                    if (name == "Random")
                    {
                        args.Result = Random(args);
                    }
                };

                var result = Convert.ToDouble(expression.Evaluate());
                if (negate)
                {
                    result = -result;
                }

                return (int)Math.Round(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to evaluate damage formula", ex);
            }
        }

        private static int Random([NotNull] FunctionArgs args)
        {
            if (args.Parameters == null)
            {
                throw new ArgumentNullException(nameof(args.Parameters));
            }

            var parameters = args.EvaluateParameters() ??
                             throw new NullReferenceException($"{nameof(args.EvaluateParameters)}() returned null.");

            if (parameters.Length < 2)
            {
                throw new ArgumentException($"{nameof(Random)}() requires 2 numerical parameters.");
            }

            var min = (int)Math.Round(
                (double)(parameters[0] ?? throw new NullReferenceException("First parameter is null."))
            );

            var max = (int)Math.Round(
                (double)(parameters[1] ?? throw new NullReferenceException("First parameter is null."))
            );

            return min >= max ? min : Globals.Rand.Next(min, max + 1);
        }

    }

}
