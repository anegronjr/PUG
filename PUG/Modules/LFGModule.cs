using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Linq;
using System.Threading.Tasks;
using PUG.Common;
using PUG.Classes;

namespace PUG.Modules
{
    public class LFGModule : ModuleBase
    {
        [Command("lfg")]
        [Summary("Create a new LFG event.")]
        public async Task LFG()
        {

        }
    }
}
