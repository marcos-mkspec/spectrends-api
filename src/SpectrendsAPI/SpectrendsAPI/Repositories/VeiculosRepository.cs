using Microsoft.Data.Sqlite;
using SpectrendsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace SpectrendsAPI.Repositories
{
    public interface IVeiculosRepository
    {
        Task<IEnumerable<Veiculo>> GetAll(int marcaId);
    }

    public class VeiculosRepository : IVeiculosRepository
    {
        private readonly SpectrendsDbConfig _spectrendsDbConfig;
        public VeiculosRepository(SpectrendsDbConfig spectrendsDbConfig)
        {
            this._spectrendsDbConfig = spectrendsDbConfig;
        }

        public async Task<IEnumerable<Veiculo>> GetAll(int marcaId)
        {
            using (var connection = new SqliteConnection(_spectrendsDbConfig.StringConnection))
            {
                return await connection.QueryAsync<Veiculo>("Select VeiculoId, NomeReduzido, Ano, DataTabelaDescricao, Substr(PrecoDescricao, 1, 3) As MoedaDescricao, Preco From Veiculos  Where MarcaId = " + marcaId);
            }
        }
    }
}
