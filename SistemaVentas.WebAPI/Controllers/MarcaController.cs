using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVentas.Application.Features.Marca.Commands.CreateMarcaCommand;
using SistemaVentas.Application.Interface.Persistence;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository _repository;

        public MarcaController(IMarcaRepository repository) 
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Guardar(CreateMarcaCommandParameters parametro)
        {
            CreateMarcaCommand command = new CreateMarcaCommand(_repository);
            return Ok(command.Guardar(parametro));
        }

        [HttpGet]
        public async Task<IActionResult> Saludar()
        {
            return Ok("Saludps");
        }
    }
}
