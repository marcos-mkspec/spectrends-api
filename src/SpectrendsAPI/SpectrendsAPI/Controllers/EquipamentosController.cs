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
    public class EquipamentosController : ControllerBase
    {
        private readonly ILogger<EquipamentosController> _logger;
        private readonly IEquipamentosRepository _repository;
        public EquipamentosController(ILogger<EquipamentosController> logger, IEquipamentosRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Equipamento>> Equipamentos(int id)
        {
            return await _repository.Series(id);
        }
    }
}
