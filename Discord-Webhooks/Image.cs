using System.Text.Json.Serialization;

namespace Discord_Webhooks
{
    public class Image
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}