using PUG.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUG.Repositories
{
    public class TextChannelRepository
    {
        private readonly EFContext _context;

        public TextChannelRepository(EFContext context)
        {
            _context = context;
        }

        public TextChannel GetTextChannelByID(ulong textChannelID)
        {
            var textChannel = _context.TextChannels.Find(textChannelID);

            return textChannel;
        }

        public TextChannel AddTextChannel(TextChannel textChannel)
        {
            _context.TextChannels.Add(textChannel);
            _context.SaveChanges();

            return textChannel;
        }

        public TextChannel UpdateTextChannel(TextChannel textChannel)
        {
            _context.TextChannels.Update(textChannel);
            _context.SaveChanges();

            return textChannel;
        }

        public void DeleteTextChannel(TextChannel textChannel)
        {
            _context.TextChannels.Remove(textChannel);
            _context.SaveChanges();
        }
    }
}
