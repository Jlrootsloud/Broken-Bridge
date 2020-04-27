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


        public void SetupDefaultRanks()
        {
            // Clear existing ranks, if any.
            Ranks.Clear();

           // Create new ranks
           Options
        }

    }
}
