using System.Text.Json.Serialization;

namespace Replace
{
    public class ReplacementData
    {
        [JsonPropertyName("replacement")]
        public string Replacement { get; set; }
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
   
}