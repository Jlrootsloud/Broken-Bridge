using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Enums;
using Intersect.GameObjects.Maps;
using Intersect.Models;
using Intersect.Server.Utilities;
using Intersect.Utilities;

using JetBrains.Annotations;

using Newtonsoft.Json;

namespace Intersect.GameObjects
{

    public class SkillBase : DatabaseObject<SkillBase>
    {

        public const long DEFAULT_BASE_EXPERIENCE = 8;

        public const long DEFAULT_EXPERIENCE_INCREASE = 5;

        [NotMapped] public int[] BaseSkills = new int[(int) Skills.SkillCount];

        [NotMapped] public Dictionary<int, long> ExperienceOverrides = new Dictionary<int, long>();

        [JsonIgnore] private long mBaseExp;

        [JsonIgnore] private long mExpIncrease;


        public SkillBase()
        {
           

            ExperienceCurve = new ExperienceCurve();
            ExperienceCurve.Calculate(1);
            BaseExp = DEFAULT_BASE_EXPERIENCE;
            ExpIncrease = DEFAULT_EXPERIENCE_INCREASE;

        }

        public SkillBase(Guid predefinedid)
        {
            ExperienceCurve = new ExperienceCurve();
            ExperienceCurve.Calculate(1);
            BaseExp = DEFAULT_BASE_EXPERIENCE;
            ExpIncrease = DEFAULT_EXPERIENCE_INCREASE;
        }

        public long BaseExp
        {
            get => mBaseExp;
            set
            {
                mBaseExp = Math.Max(0, value);
                ExperienceCurve.BaseExperience = Math.Max(1, mBaseExp);
            }
        }

        public long ExpIncrease
        {
            get => mExpIncrease;
            set
            {
                mExpIncrease = Math.Max(0, value);
                ExperienceCurve.Gain = 1 + value / 100.0;
            }
        }

        //Level Up Info
        public bool IncreasePercentage { get; set; }

        [JsonIgnore]
        [NotMapped]
        [NotNull]
        public ExperienceCurve ExperienceCurve { get; }

       
        [JsonIgnore]
        [Column("ExperienceOverrides")]
        public string ExpOverridesJson
        {
            get => JsonConvert.SerializeObject(ExperienceOverrides);
            set
            {
                ExperienceOverrides = JsonConvert.DeserializeObject<Dictionary<int, long>>(value ?? "");
                if (ExperienceOverrides == null)
                {
                    ExperienceOverrides = new Dictionary<int, long>();
                }
            }
        }

       
        [Pure]
        public long ExperienceToFarmingNextLevel(int FarmingLevel)
        {
            if (ExperienceOverrides.ContainsKey(FarmingLevel))
            {
                return ExperienceOverrides[FarmingLevel];
            }

            return ExperienceCurve.Calculate(FarmingLevel);
        }

    }

   

}
