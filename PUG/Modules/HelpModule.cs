using Discord;
using Discord.Commands;
using Microsoft.Extensions.Configuration;
using PUG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUG.Modules
{
    public class HelpModule : ModuleBase
    {
        private readonly CommandService _commands;
        private readonly IConfiguration _config;

        public HelpModule(CommandService commands, IConfiguration config)
        {
            _commands = commands;
            _config = config;
        }

        [Command("help")]
        [Summary("Lists all of the commands available for PUG Bot.")]
        public async Task Help()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.Title = "List of all PUG Bot Commands";
            builder.Color = Colors.Info;

            foreach (var command in _commands.Commands.OrderBy(c => c.Name))
                AddCommand(command, builder);

            await ReplyAsync("", embed: builder.Build());
        }

        private void AddCommand(CommandInfo command, EmbedBuilder builder)
        {
            builder.AddField(f =>
            {
                f.Name = $"{_config["prefix"]}{command.Name}";
                f.Value = command.Summary ?? "No summary available.";

                if (command.Parameters.Count > 0)
                {
                    foreach(var parameter in command.Parameters)
                        f.Name += $" <{parameter.Name}>";
                }
            });
        }
    }
}
