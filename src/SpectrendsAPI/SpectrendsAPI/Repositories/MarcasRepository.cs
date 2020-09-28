using Microsoft.Data.Sqlite;
using SpectrendsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace SpectrendsAPI.Repositories
{
    public interface IMarcasRepository
    {
        Task<IEnumerable<Marca>> GetAll();
    }

    public class MarcasRepository : IMarcasRepository
    {
        private readonly SpectrendsDbConfig _spectrendsDbConfig;
        public MarcasRepository(SpectrendsDbConfig spectrendsDbConfig)
        {
            this._spectrendsDbConfig = spectrendsDbConfig;
        }

        public async Task<IEnumerable<Marca>> GetAll()
        {
            using (var connection = new SqliteConnection(_spectrendsDbConfig.StringConnection))
            {
                return await connection.QueryAsync<Marca>("select MarcaId, MarcaDescricao from marcas");
            }
        }
    }
}
