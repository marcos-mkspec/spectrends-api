using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpectrendsAPI.Models;
using SpectrendsAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpectrendsAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MarcasController : ControllerBase
    {
        private readonly ILogger<MarcasController> _logger;
        private readonly IMarcasRepository _repository;
        public MarcasController(ILogger<MarcasController> logger, IMarcasRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Marca>> Marcas()
        {
            return await _repository.GetAll();
        }
    }
}
