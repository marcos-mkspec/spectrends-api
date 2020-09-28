using System.Text.Json.Serialization;

namespace SpectrendsAPI.Models
{
    public class Veiculo
    {
        [JsonPropertyName("id")]
        public int VeiculoId { get; set; }
        [JsonPropertyName("nome")]
        public string NomeReduzido { get; set; }
        [JsonPropertyName("anomodelo")]
        public int Ano { get; set; }
        [JsonPropertyName("tabelaReferencia")]
        public string DataTabelaDescricao { get; set; }
        [JsonPropertyName("moeda")]
        public string MoedaDescricao { get; set; }
        [JsonPropertyName("preco")]
        public int Preco { get; set; }
    }
}
