using System.Text.Json.Serialization;

namespace Discord_Webhooks
{
    public class Footer
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("icon_url")] 
        public string IconUrl { get; set; }
    }
}