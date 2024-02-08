using System.Text.Json.Serialization;

namespace DataLibrary.Models
{
    public class VideoModel
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<VideoDetails> Results { get; set; } = new List<VideoDetails>();
    }

    public class VideoDetails
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("iso_639_1")]
        public string Iso_639_1 { get; set; }= string.Empty;

        [JsonPropertyName("iso_3166_1")]
        public string Iso_3166_1 { get; set; }=string.Empty;

        [JsonPropertyName("key")]
        public string Key { get; set; } =string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("site")]
        public string Site { get; set; } = string.Empty;

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }

}
