namespace Intersect.Network.Packets.Server
{

    public class WoodExperiencePacket : CerasPacket
    {

        public WoodExperiencePacket(long exp, long tnl)
        {
            
   
            
            WoodExperience = exp;
            ExperienceToWoodNextLevel = tnl;

           
        }


        public long WoodExperience { get; set; }

        public long ExperienceToWoodNextLevel { get; set; }

      

    }

}
