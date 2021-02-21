using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Discord_Webhooks
{
    public class Embed
    {
        public Embed()
        {
            
        }
        
        public Embed(Author author, string title, string url, string description, long color, List<Field> fields, Image thumbnail, Image image, Footer footer)
        {
            Author = author;
            Title = title;
            Url = url;
            Description = description;
            Color = color;
            Fields = fields;
            Thumbnail = thumbnail;
            Image = image;
            Footer = footer;
        }

        [JsonPropertyNameAttribute("author")]
        public Author Author { get; set; }

        [JsonPropertyNameAttribute("title")]
        public string Title { get; set; }

        [JsonPropertyNameAttribute("url")]
        public string Url { get; set; }

        [JsonPropertyNameAttribute("description")]
        public string Description { get; set; }

        [JsonPropertyNameAttribute("color")]
        public long Color { get; set; }

        [JsonPropertyNameAttribute("fields")]
        public List<Field> Fields { get; set; }

        [JsonPropertyNameAttribute("thumbnail")]
        public Image Thumbnail { get; set; }

        [JsonPropertyNameAttribute("image")]
        public Image Image { get; set; }

        [JsonPropertyNameAttribute("footer")]
        public Footer Footer { get; set; }
    }
}