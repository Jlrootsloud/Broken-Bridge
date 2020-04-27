using System.Collections.Generic;

using Intersect.Enums;


namespace Intersect.Config
{
    /// <summary>
    /// Contains the options pertaining to all things guild related.
    /// </summary>
    public class GuildOptions
    {

        /// <summary>
        /// Determines whether the client should render the Guild Tag (true) or the Guild Name (false) by players their names.
        /// </summary>
        public bool ShowGuildTag = true;

        /// <summary>
        /// Configures which rank will be used by default for the person creating a guild.
        /// </summary>
        public string DefaultCreationRank = "Leader";

        /// <summary>
        /// Configures which rank will be used by default for each person invited to a guild.
        /// </summary>
        public string DefaultMemberRank = "New Member";

        public List<GuildRankOptions> DefaultRanks = new List<GuildRankOptions>() { 
            // New Member
            new GuildRankOptions() {
                Title = "New Member",
                Permissions = new Dictionary<GuildPermissions, bool>() {
                    { GuildPermissions.UseGuildChat, true },
                }
            },

            // Member
            new GuildRankOptions() {
                Title = "Member",
                Permissions = new Dictionary<GuildPermissions, bool>() {
                    { GuildPermissions.UseGuildChat, true },
                    { GuildPermissions.InvitePlayers, true },
                }
            },

            // Officer
            new GuildRankOptions() {
                Title = "Officer",
                Permissions = new Dictionary<GuildPermissions, bool>() {
                    { GuildPermissions.UseGuildChat, true },
                    { GuildPermissions.InvitePlayers, true },
                    { GuildPermissions.KickPlayers, true },
                }
            },

            // Leader
            new GuildRankOptions() {
                Title = "Leader",
                Permissions = new Dictionary<GuildPermissions, bool>() {
                    { GuildPermissions.UseGuildChat, true },
                    { GuildPermissions.InvitePlayers, true },
                    { GuildPermissions.KickPlayers, true },
                    { GuildPermissions.ChangeGuildName, true },
                    { GuildPermissions.ChangeGuildTag, true },
                }
            },
        };

    }

    /// <summary>
    /// Contains settings pertaining to each (default) guild rank.
    /// </summary>
    public class GuildRankOptions
    {
        public string Title { get; set; }

        public Dictionary<GuildPermissions, bool> Permissions = new Dictionary<GuildPermissions, bool>();
    }
}
