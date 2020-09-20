namespace Intersect.Network.Packets.Server
{

    public class FishingExperiencePacket : CerasPacket
    {

        public FishingExperiencePacket(long exp, long tnl)
        {
            
   
            
            FishingExperience = exp;
            ExperienceToFishingNextLevel = tnl;

           
        }


        public long FishingExperience { get; set; }

        public long ExperienceToFishingNextLevel { get; set; }

      

    }

}
