using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace SpectrendsAPI.Models
{
    public class Opcional
    {
        [JsonPropertyName("id")]
        public int PacoteOpcionalId { get; set; }
        [JsonPropertyName("nome")]
        public string PacoteOpcionalDescricao { get; set; }

        [JsonPropertyName("moeda")]
        public string Moeda { get; set; }
        [JsonPropertyName("precoSugerido")]
        public int Preco { get; set; }

        [JsonPropertyName("equipamentos")]
        public IEnumerable<Equipamento> Equipamentos { get; set; }
    }

    public class OpcionalConverter
    {
        public int PacoteOpcionalId { get; set; }
        public string PacoteOpcionalDescricao { get; set; }
        public int EquipamentoId { get; set; }
        public string EquipamentoDescricao { get; set; }
        public string GrupoDescricao { get; set; }
        public string Moeda { get; set; }
        public int Preco { get; set; }

        public static IEnumerable<Opcional> Converter(IEnumerable<OpcionalConverter> converter)
        {
            if (converter.Count() == 0)
            {
                return new Opcional[] { };
            }

            return converter.Select(x => new { x.PacoteOpcionalId, x.Moeda, x.PacoteOpcionalDescricao, x.Preco}).Distinct().Select(
                x => new Opcional()
                {
                    Moeda = x.Moeda,
                    PacoteOpcionalDescricao = x.PacoteOpcionalDescricao,
                    PacoteOpcionalId = x.PacoteOpcionalId,
                    Preco = x.Preco,
                    Equipamentos = converter.Where(c => c.PacoteOpcionalId == x.PacoteOpcionalId).Select(c => new Equipamento()
                    {
                        EquipamentoId = c.EquipamentoId,
                        EquipamentoDescricao = c.EquipamentoDescricao,
                        GrupoDescricao = c.GrupoDescricao,
                    })
                });
        }
    }
}
