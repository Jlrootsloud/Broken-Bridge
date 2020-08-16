namespace Intersect.Network.Packets.Server
{

    public class SkillsExperiencePacket : CerasPacket
    {

        public SkillsExperiencePacket(long exp, long tnl)
        {
            
   
            
            FarmingExperience = exp;
            ExperienceToFarmingNextLevel = tnl;

            MiningExperience = exp;
            ExperienceToMiningNextLevel = tnl;

            FishingExperience = exp;
            ExperienceToFishingNextLevel = tnl;

            WoodExperience = exp;
            ExperienceToWoodNextLevel = tnl;
        }

        public long FarmingExperience { get; set; }

        public long ExperienceToFarmingNextLevel { get; set; }

        public long MiningExperience { get; set; }

        public long ExperienceToMiningNextLevel { get; set; }
        public long FishingExperience { get; set; }

        public long ExperienceToFishingNextLevel { get; set; }
        public long WoodExperience { get; set; }

        public long ExperienceToWoodNextLevel { get; set; }

    }

}
