namespace Intersect.Network.Packets.Server
{

    public class MiningExperiencePacket : CerasPacket
    {

        public MiningExperiencePacket(long exp, long tnl)
        {
            
            MiningExperience = exp;
            ExperienceToMiningNextLevel = tnl;

           
        }

      

        public long MiningExperience { get; set; }

        public long ExperienceToMiningNextLevel { get; set; }
    

    }

}
