using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Web_API_Oracle_19c_ODP.NET.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProbabilidadController : ControllerBase
    {
        private readonly ProbabilidadService _service;

        public ProbabilidadController(ProbabilidadService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Crear([FromBody] ProbabilidadEvento p)
        {
            try
            {
                // calculo automatico .
                if (p.TotalCasos > 0)

                    p.Probabilidad = (double)p.CasosFavorables / p.TotalCasos;

                p.FechaCalculo = DateTime.Now;

                _service.Insertar(p);

                return Ok(new { message = "registro insertado correctamente.", p.Probabilidad });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
