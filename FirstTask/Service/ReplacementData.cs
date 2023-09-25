using System.Text.Json.Serialization;

namespace FirstTask
{
    public class ReplacementData
    {
        [JsonPropertyName("replacement")]
        public string Replacement { get; set; }
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
   
}