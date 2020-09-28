using System.Text.Json.Serialization;

namespace SpectrendsAPI.Models
{
    public class DadoTecnico
    {
        [JsonPropertyName("id")]
        public int DadoTecnicoId { get; set; }
        [JsonPropertyName("nome")]
        public string DadoTecnicoDescricao { get; set; }

        [JsonPropertyName("grupo")]
        public string GrupoDescricao { get; set; }
        [JsonPropertyName("valor")]
        public string Valor { get; set; }
    }
}
