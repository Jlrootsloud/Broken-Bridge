namespace Intersect.Network.Packets.Server
{

    public class FarmingExperiencePacket : CerasPacket
    {

        public FarmingExperiencePacket(long exp, long tnl)
        {
            
   
            
            FarmingExperience = exp;
            ExperienceToFarmingNextLevel = tnl;

           
        }


        public long FarmingExperience { get; set; }

        public long ExperienceToFarmingNextLevel { get; set; }

      

    }

}
