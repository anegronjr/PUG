using System;
using System.Collections.Generic;
using System.Text;

namespace PUG.Models
{
    public class TextChannel
    {
        public ulong ID { get; set; }
        public Guild Guild { get; set; }
        public enum Type { LFG, PUG }
        public Type ChannelType { get; set; }
    }
}
