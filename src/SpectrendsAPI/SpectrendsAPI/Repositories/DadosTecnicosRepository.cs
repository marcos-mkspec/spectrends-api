using Microsoft.Data.Sqlite;
using SpectrendsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System;

namespace SpectrendsAPI.Repositories
{
    public interface IDadosTecnicosRepository
    {
        Task<IEnumerable<DadoTecnico>> GetAll(int veiculoId);
    }

    public class DadosTecnicosRepository : IDadosTecnicosRepository
    {
        private readonly SpectrendsDbConfig _spectrendsDbConfig;
        public DadosTecnicosRepository(SpectrendsDbConfig spectrendsDbConfig)
        {
            this._spectrendsDbConfig = spectrendsDbConfig;
        }

        public async Task<IEnumerable<DadoTecnico>> GetAll(int veiculoId)
        {
            using (var connection = new SqliteConnection(_spectrendsDbConfig.StringConnection))
            {
                var campo = "v" + veiculoId;
                try
                {
                    return await connection.QueryAsync<DadoTecnico>("Select DadoTecnicoId, DadoTecnicoDescricao_pt_BR As DadoTecnicoDescricao, GrupoDescricao_pt_BR As GrupoDescricao, " + campo + " As Valor From DadosTecnicos Where " + campo + " <> ''  Order By GrupoOrdem");
                }
                catch (Exception)
                {
                    return new DadoTecnico[] { };
                }
                
            }
        }
    }
}
