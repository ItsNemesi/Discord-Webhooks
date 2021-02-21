#nullable enable
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Discord_Webhooks
{
    public class Webhook
    {
        public Webhook()
        {
        }

        public Webhook(string username, string avatarUrl, string content, List<Embed> embeds)
        {
            Username = username;
            AvatarUrl = avatarUrl;
            Content = content;
            Embeds = embeds;
        }

        private string WebhookUrl { get; set; }
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyNameAttribute("avatar_url")]
        public string? AvatarUrl { get; set; }

        [JsonPropertyNameAttribute("content")]
        public string? Content { get; set; }

        [JsonPropertyNameAttribute("embeds")]
        public List<Embed>? Embeds { get; set; }

    }
}