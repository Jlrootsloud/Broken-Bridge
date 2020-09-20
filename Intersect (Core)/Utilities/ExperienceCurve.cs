using System;

using Intersect.Logging;

using JetBrains.Annotations;

using NCalc;

namespace Intersect.Server.Utilities
{

    public class ExperienceCurve
    {

        public const string DEFAULT_EXPERIENCE_FORMULA = "Floor(BaseExp * Pow(Gain, Level - 1))";

        public const string PARAM_BASE_EXP = "BaseExp";

        public const string PARAM_GAIN = "Gain";

        public const string PARAM_LEVEL = "Level";

        public ExperienceCurve(string source = DEFAULT_EXPERIENCE_FORMULA)
        {
            if (string.IsNullOrEmpty(source))
            {
                return;
            }

            //Formula = new Formula(source);
            //Formula.RegisterFunction("Exp", Exp);

            BaseExperience = 100;
            Gain = 1.5;
        }

        //[CanBeNull]
        //private Formula mFormula;

        //[NotNull]
        //public Formula Formula
        //{
        //    get => mFormula ?? (mFormula = new Formula(DEFAULT_EXPERIENCE_FORMULA));
        //    set => mFormula = value;
        //}

        public long BaseExperience { get; set; }

        public double Gain { get; set; }

        protected virtual void Exp([NotNull] FunctionArgs args)
        {
            if (args.Parameters == null || args.Parameters.Length < 3)
            {
                Log.Error("Tried to execute Exp with fewer than three arguments.");
                args.Result = 0L;
            }

            var level = (int) (args.Parameters?[0]?.Evaluate() ?? -1);
            var baseExperience = (long) (args.Parameters?[1]?.Evaluate() ?? -1);
            var gain = (double) (args.Parameters?[2]?.Evaluate() ?? -1);
            args.Result = Calculate(level, baseExperience, gain);
        }

        public long Calculate(int level)
        {
            return Calculate(level, BaseExperience, Gain);
        }

        public long Calculate(int level, long baseExperience)
        {
            return Calculate(level, baseExperience, Gain);
        }

        public long Calculate(int level, long baseExperience, double gain)
        {
            //Formula.RegisterParameter(PARAM_BASE_EXP, baseExperience, true);
            //Formula.RegisterParameter(PARAM_GAIN, gain, true);
            //Formula.RegisterParameter(PARAM_LEVEL, level, true);
            //return Formula.Evaluate<long>();
            return (long) Math.Floor(baseExperience * Math.Pow(gain, level - 1));
        }

    }


    public class SkillsExperienceCurve
    {

        public const string DEFAULT_EXPERIENCE_FORMULA = "Floor(BaseExp * Pow(Gain, FarmingLevel - 1))";

        public const string PARAM_BASE_EXP = "BaseExp";

        public const string PARAM_GAIN = "Gain";

        public const string PARAM_LEVEL = "FarmingLevel";

        public SkillsExperienceCurve(string source = DEFAULT_EXPERIENCE_FORMULA)
        {
            if (string.IsNullOrEmpty(source))
            {
                return;
            }

            //Formula = new Formula(source);
            //Formula.RegisterFunction("Exp", Exp);

            BaseExperience = 10;
            Gain = 1.5;
        }

        public long BaseExperience { get; set; }

        public double Gain { get; set; }

        protected virtual void Exp([NotNull] FunctionArgs args)
        {
            if (args.Parameters == null || args.Parameters.Length < 3)
            {
                Log.Error("Tried to execute Exp with fewer than three arguments.");
                args.Result = 0L;
            }

            var FarmingLevel = (int)(args.Parameters?[0]?.Evaluate() ?? -1);
            var baseExperience = (long)(args.Parameters?[1]?.Evaluate() ?? -1);
            var gain = (double)(args.Parameters?[2]?.Evaluate() ?? -1);
            args.Result = FarmingCalculate(FarmingLevel, baseExperience, gain);
        }

        public long FarmingCalculate(int FarmingLevel)
        {
            return FarmingCalculate(FarmingLevel, BaseExperience, Gain);
        }

        public long FarmingCalculate(int FarmingLevel, long baseExperience)
        {
            return FarmingCalculate(FarmingLevel, baseExperience, Gain);
        }

        public long FarmingCalculate(int FarmingLevel, long baseExperience, double gain)
        {
            //Formula.RegisterParameter(PARAM_BASE_EXP, baseExperience, true);
            //Formula.RegisterParameter(PARAM_GAIN, gain, true);
            //Formula.RegisterParameter(PARAM_LEVEL, level, true);
            //return Formula.Evaluate<long>();
            return (long)Math.Floor(baseExperience * Math.Pow(gain, FarmingLevel - 1));
        }

    }

}
