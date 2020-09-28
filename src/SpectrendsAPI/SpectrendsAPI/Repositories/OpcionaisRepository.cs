using Microsoft.Data.Sqlite;
using SpectrendsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace SpectrendsAPI.Repositories
{
    public interface IOpcionaisRepository
    {
        Task<IEnumerable<Opcional>> GetAll(int veiculoId);
    }

    public class OpcionaisRepository : IOpcionaisRepository
    {
        private readonly SpectrendsDbConfig _spectrendsDbConfig;
        public OpcionaisRepository(SpectrendsDbConfig spectrendsDbConfig)
        {
            this._spectrendsDbConfig = spectrendsDbConfig;
        }

        public async Task<IEnumerable<Opcional>> GetAll(int veiculoId)
        {
            using (var connection = new SqliteConnection(_spectrendsDbConfig.StringConnection))
            {
                string query = @"
Select p.PacoteOpcionalId, p.PacoteOpcionalDescricao, Substr(p.PrecoDescricao, 1, 3) As Moeda
    , Cast(Replace(Replace(Substr(p.PrecoDescricao, 4), ',00', ''), '.', '') As NUMERIC) As Preco 
	, e.EquipamentoId, e.EquipamentoDescricao_pt_BR As EquipamentoDescricao, e.GrupoDescricao_pt_BR As GrupoDescricao
From PacotesOpcionais p 
	Inner Join PacotesOpcionaisEquipamentos pe On (p.PacoteOpcionalId = pe.PacoteOpcionalId)
	Inner Join Equipamentos e On (pe.EquipamentoId = e.EquipamentoId)
Where p.VeiculoId = " + veiculoId;

                return OpcionalConverter.Converter(await connection.QueryAsync<OpcionalConverter>(query));
            }
        }
    }
}
