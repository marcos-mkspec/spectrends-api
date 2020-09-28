using System.Text.Json.Serialization;

namespace SpectrendsAPI.Models
{
    public class Equipamento
    {
        [JsonPropertyName("id")]
        public int EquipamentoId { get; set; }
        [JsonPropertyName("nome")]
        public string EquipamentoDescricao { get; set; }

        [JsonPropertyName("grupo")]
        public string GrupoDescricao { get; set; }
    }
}
