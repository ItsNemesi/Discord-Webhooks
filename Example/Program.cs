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
            
            var discordWebhook = new DiscordWebhook("https://discord.com/api/webhooks/813191490389540894/9Dn79dUodmX8PwVb_LjPXQS25R5k5PgE51tIJx8sIArs1ddG8igfOrWr2M8luwV0gLll", webhook);
            var send = await discordWebhook.Send();
            
            Console.WriteLine(send ? "Success" : "Not Successful");
        }
    }
}