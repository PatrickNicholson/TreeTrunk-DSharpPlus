using System;
using System.Threading.Tasks;
using DSharpPlus;
namespace DiscordBot_DSharp{
    class Program{
        static void Main(string[] args){
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync(){

            var discord = new DiscordClient(new DiscordConfiguration(){
                Token = "Token",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.All
            });

            await discord.ConnectAsync();
            await Task.Delay(-1);

        }

    }
}
