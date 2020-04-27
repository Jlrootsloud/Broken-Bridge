using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using Intersect.Enums;
using Intersect.Server.Localization;
using Intersect.Server.Networking;

using JetBrains.Annotations;

using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

namespace Intersect.Server.Entities.Guilds
{
    public class Guild
    {
        /// <summary>
        /// The Identifier by which this Guild can be uniquely identified.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public Guid Id { get; private set; }

        /// <summary>
        /// The Guild's full name.
        /// </summary>
        [Column(Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// The display tag that shows next to a player's name when in a guild.
        /// </summary>
        [Column(Order = 2)]
        public string Tag { get; set; }

        [Column("Members", Order = 3)]
        [JsonIgnore]
        public string MembersJson
        {
            get => JsonConvert.SerializeObject(Members);
            set => Members = JsonConvert.DeserializeObject<Dictionary<Guid, Guid>>(value);
        }

        /// <summary>
        /// A Dictionary of all Members in this guild. Key is Player, Value is Rank.
        /// </summary>
        [NotMapped]
        public Dictionary<Guid, Guid> Members = new Dictionary<Guid, Guid>();

        [Column("Ranks", Order = 4)]
        [JsonIgnore]
        public string RanksJson
        {
            get => JsonConvert.SerializeObject(Ranks);
            set => Ranks = JsonConvert.DeserializeObject<List<GuildRank>>(value);
        }

        /// <summary>
        /// A list of all Ranks in this guild.
        /// </summary>
        [NotMapped]
        public List<GuildRank> Ranks = new List<GuildRank>();

        /// <summary>
        /// Determines which rank a player will get by default upon joining this guild.
        /// </summary>
        public Guid DefaultMemberRank { get; set; }

        /// <summary>
        /// Determines which rank within this guild is the leader rank.
        /// </summary>
        public Guid LeaderRank { get; set; }

        /// <summary>
        /// The date on which this guild was founded.
        /// </summary>
        [Column(Order = 6)]
        public DateTime FoundingDate { get; set; }

        public Guild() : this(Guid.NewGuid())
        {

        }

        public Guild(Guid guid)
        {
            Id = guid;
        }

        public static void Create(Player player, string name, string tag)
        {
            Database.DbInterface.CreateGuild(player, name, tag);
        }

        public void SetupDefaultRanks()
        {
            // Clear existing ranks, if any.
            Ranks.Clear();

            // Create new ranks
            Guid defaultRank = Guid.Empty;
            foreach (var rank in Options.GuildOptions.DefaultRanks)
            {
                // Create a new rank and set it up as configured.
                var newRank = new GuildRank() { Title = rank.Title, Permissions = rank.Permissions };
                Ranks.Add(newRank);

                // If this rank matches our default member rank setting, set it as such!
                if (Options.GuildOptions.DefaultMemberRank == rank.Title) DefaultMemberRank = newRank.Id;

                // If this rank matches our default creation rank setting, set it as our Leader Rank
                if (Options.GuildOptions.DefaultLeaderRank == rank.Title) LeaderRank = newRank.Id;
            }
            
            // If our Leader rank is empty, something went horribly awry?
            if (LeaderRank == Guid.Empty) 
            {
                Logging.Log.Debug($@"Created guild with Id {Id} without a LeaderRank. Is the Guild configuration invalid? Setting to First rank!");
                LeaderRank = Ranks.First().Id;
            }

            // If our Leader rank is empty, something went horribly awry?
            if (DefaultMemberRank == Guid.Empty)
            {
                Logging.Log.Debug($@"Created guild with Id {Id} without a DefaultMemberRank. Is the Guild configuration invalid? Setting to First rank!");
                DefaultMemberRank = Ranks.First().Id;
            }
        }

        public bool Join(Player player, Guid rank) 
        { 
            // Check if this player is already in a guild.
            if (player.Guild != null)
            {
                PacketSender.SendChatMsg(player, Strings.Guilds.AlreadyInGuild, CustomColors.Alerts.Error);
                return false;
            }

            // Set this player to be in this guild.
            player.Guild = this;
            Members.Add(player.Id, rank);

            // Notify them they've joined!
            PacketSender.SendChatMsg(player, Strings.Guilds.JoinedGuild.ToString(Name), CustomColors.Alerts.Success);

            return true;
        }

    }
}
