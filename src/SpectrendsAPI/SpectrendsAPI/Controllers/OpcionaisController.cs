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
    public class OpcionaisController : ControllerBase
    {
        private readonly ILogger<OpcionaisController> _logger;
        private readonly IOpcionaisRepository _repository;
        public OpcionaisController(ILogger<OpcionaisController> logger, IOpcionaisRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Opcional>> Opcionais(int id)
        {
            return await _repository.GetAll(id);
        }
    }
}
