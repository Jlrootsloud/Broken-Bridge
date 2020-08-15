namespace Intersect.Network.Packets.Server
{

    public class SkillsExperiencePacket : CerasPacket
    {

        public SkillsExperiencePacket(long exp, long tnl)
        {
            FarmingExperience = exp;
            ExperienceToFarmingNextLevel = tnl;
        }

        public long FarmingExperience { get; set; }

        public long ExperienceToFarmingNextLevel { get; set; }

    }

}
