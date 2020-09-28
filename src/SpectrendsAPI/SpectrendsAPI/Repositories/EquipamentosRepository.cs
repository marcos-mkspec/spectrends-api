using Microsoft.Data.Sqlite;
using SpectrendsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System;

namespace SpectrendsAPI.Repositories
{
    public interface IEquipamentosRepository
    {
        Task<IEnumerable<Equipamento>> Series(int veiculoId);
    }

    public class EquipamentosRepository : IEquipamentosRepository
    {
        private readonly SpectrendsDbConfig _spectrendsDbConfig;
        public EquipamentosRepository(SpectrendsDbConfig spectrendsDbConfig)
        {
            this._spectrendsDbConfig = spectrendsDbConfig;
        }

        public async Task<IEnumerable<Equipamento>> Series(int veiculoId)
        {
            using (var connection = new SqliteConnection(_spectrendsDbConfig.StringConnection))
            {
                var campo = "v" + veiculoId;
                try
                {
                    return await connection.QueryAsync<Equipamento>("Select EquipamentoId, EquipamentoDescricao_pt_BR As EquipamentoDescricao, GrupoDescricao_pt_BR As GrupoDescricao From Equipamentos Where " + campo + " = 'X' Order By GrupoOrdem");
                }
                catch (Exception)
                {
                    return new Equipamento[] { };
                }
                
            }
        }
    }
}
