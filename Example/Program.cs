using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord_Webhooks;
namespace Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var webhook = new Webhook();
            
            webhook.Username = "ItsNemesi";
            webhook.Content = "Test";
            
            var discordWebhook = new DiscordWebhook("", webhook);
            var send = await discordWebhook.Send();
            
            Console.WriteLine(send ? "Success" : "Not Successful");
        }
    }
}