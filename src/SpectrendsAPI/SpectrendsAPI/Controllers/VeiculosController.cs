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
    public class VeiculosController : ControllerBase
    {
        private readonly ILogger<VeiculosController> _logger;
        private readonly IVeiculosRepository _repository;
        public VeiculosController(ILogger<VeiculosController> logger, IVeiculosRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Veiculo>> Veiculos(int id)
        {
            return await _repository.GetAll(id);
        }
    }
}
