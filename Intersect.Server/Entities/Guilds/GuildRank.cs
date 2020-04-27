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
    public class GuildRank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public Guid Id { get; private set; }

        [Column(Order = 1)]
        public string Title { get; set; }

        [Column("Permissions", Order = 2)]
        [JsonIgnore]
        public string PermissionsJson
        {
            get => JsonConvert.SerializeObject(Permissions);
            set => Permissions = JsonConvert.DeserializeObject<Dictionary<GuildPermissions, bool>>(value);
        }

        [NotMapped]
        public Dictionary<GuildPermissions, bool> Permissions = new Dictionary<GuildPermissions, bool>(); 

        public GuildRank() : this(Guid.NewGuid())
        {
            
        }

        public GuildRank(Guid guid)
        {
            // Create a new Id for ourselves.
            Id = guid;

            Title = "New Rank";

            // Set up some default rank permissions.
            for (var p = 0; p < (int)GuildPermissions.PermissionCount; p++)
            {
                Permissions.Add((GuildPermissions)p, false);
            }
        }

        public static GuildRank Create(string title, Dictionary<GuildPermissions, bool> permissions)
        {
            return new GuildRank() { Title = title, Permissions = permissions };
        }
    }
}
