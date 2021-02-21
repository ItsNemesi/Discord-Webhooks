using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Discord_Webhooks
{
    public class DiscordWebhook
    {
        private readonly HttpClient _client;
        public Webhook Webhook { get; set; }
        public string WebhookUrl { private get; set; }
        
        public DiscordWebhook(string webhookUrl, Webhook webhook)
        {
            WebhookUrl = webhookUrl;
            Webhook = webhook;
            _client = new HttpClient();
        }

        public DiscordWebhook()
        {
            _client = new HttpClient();
        }

        public async Task<bool> Send()
        {
            string jsonString = JsonSerializer.Serialize(Webhook);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            
            var response = await _client.PostAsync(WebhookUrl, content);
            
            if(response.IsSuccessStatusCode)
                return await Task.FromResult(true);
            
            return await Task.FromResult(false);
        }
    }
}