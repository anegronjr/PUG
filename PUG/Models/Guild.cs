using System;
using System.Collections.Generic;
using System.Text;

namespace PUG.Models
{
    public class Guild
    {
        public ulong ID { get; set; }
        public List<TextChannel> TextChannels { get; set; }
    }
}
