using Microsoft.EntityFrameworkCore;
using PUG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUG.Repositories
{
    public class GuildRepository
    {
        private readonly EFContext _context;

        public GuildRepository(EFContext context)
        {
            _context = context;
        }

        public Guild GetGuildByID(ulong guildID)
        {
            var guild = _context.Guilds.Find(guildID);

            return guild;
        }

        public Guild AddGuild(Guild guild)
        {
            _context.Guilds.Add(guild);
            _context.SaveChanges();

            return guild;
        }

        public Guild UpdateGuild(Guild guild)
        {
            _context.Guilds.Update(guild);
            _context.SaveChanges();

            return guild;
        }

        public void DeleteGuild(Guild guild)
        {
            _context.Guilds.Remove(guild);
            _context.SaveChanges();
        }
    }
}
