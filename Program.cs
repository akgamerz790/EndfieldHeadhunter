using System;
using System.Collections;
using System.Collections.Generic;
using Discord;
using Discord.API;
using Discord.WebSocket;
using EndfieldHeadhunter;
using EndfieldHeadhunter.ENDFIELD_DATABASE;
using EndfieldHeadhunter.INTERNALS;
using EndfieldHeadhunter.BOT;

namespace EndfieldHeadhunter
{
    public static class Program
    {
        public static DiscordSocketClient _BOT =

        new DiscordSocketClient(

            new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info
            }
        );

        public static void Main(string[] args)
        {
            //
            RunBotAsync()
                .GetAwaiter()
                .GetResult();
            //
        }

        public static async Task RunBotAsync()
        {
            // Initialize the client
            
            // Log to console
            _BOT.Log += (LogMessage msg) =>
            {
                Console.WriteLine(msg.ToString());
                return Task.CompletedTask;
            };

            // Ready event
            _BOT.Ready += () =>
            {
                Console.WriteLine($"{_BOT.CurrentUser.Username} is online!");
                return Task.CompletedTask;
            };

            await _BOT.LoginAsync(TokenType.Bot, BotSecrets.BOT_TOKEN);
            await _BOT.StartAsync();

            // Keep the bot running
            await Task.Delay(-1);
        }
    }
}