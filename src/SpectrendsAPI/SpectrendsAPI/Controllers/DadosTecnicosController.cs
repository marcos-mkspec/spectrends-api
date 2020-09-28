using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpectrendsAPI.Models;
using SpectrendsAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpectrendsAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/{id?}")]
    public class DadosTecnicosController : ControllerBase
    {
        private readonly ILogger<DadosTecnicosController> _logger;
        private readonly IDadosTecnicosRepository _repository;
        public DadosTecnicosController(ILogger<DadosTecnicosController> logger, IDadosTecnicosRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<DadoTecnico>> DadosTecnicos(int id)
        {
            return await _repository.GetAll(id);
        }
    }
}
