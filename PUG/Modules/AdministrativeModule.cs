using Discord;
using Discord.Commands;
using Discord.WebSocket;
using PUG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUG.Modules
{
    public class AdministrativeModule : ModuleBase
    {
        [Command("purge")]
        [Summary("Purges the specified number of messages in the current channel.")]
        [RequireUserPermission(GuildPermission.ManageMessages)]
        public async Task Purge(int amount)
        {
            var messages = await Context.Channel.GetMessagesAsync(amount).FlattenAsync();
            await (Context.Channel as SocketTextChannel).DeleteMessagesAsync(messages);

            var message = await Context.Channel.SendMessageAsync($"{messages.Count()} messages deleted successfully!");
            await Task.Delay(2500);
            await message.DeleteAsync();
        }
    }
}
