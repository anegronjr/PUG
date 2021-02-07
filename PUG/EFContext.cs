using Microsoft.EntityFrameworkCore;
using PUG.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUG
{
    public class EFContext : DbContext
    {
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<TextChannel> TextChannels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Hide connection string later...
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2818F9A;Initial Catalog=PugDB;Integrated Security=True");
        }
    }
}
