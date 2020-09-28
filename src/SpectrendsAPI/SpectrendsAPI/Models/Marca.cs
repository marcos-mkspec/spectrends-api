using System.Text.Json.Serialization;

namespace SpectrendsAPI.Models
{
    public class Marca
    {
        [JsonPropertyName("id")]
        public int MarcaId { get; set; }
        [JsonPropertyName("nome")]
        public string MarcaDescricao { get; set; }
    }
}
