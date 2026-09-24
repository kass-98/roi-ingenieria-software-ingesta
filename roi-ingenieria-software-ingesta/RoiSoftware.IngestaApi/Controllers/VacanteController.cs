using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoiSoftware.IngestaApi.Data;
using RoiSoftware.IngestaApi.Models;

namespace RoiSoftware.IngestaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacanteController : ControllerBase
    {
        private readonly DataContext _context;

        // Inyectamos nuestro puente de datos al controlador
        public VacanteController(DataContext context)
        {
            _context = context;

        }

        // 1. MÉTODO GET: Para leer todas las vacantes guardadas en SQL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacante>>> GetVacantes()

        {
            return await _context.Vacantes.ToListAsync();
        }

        // 2. MÉTODO POST: Simula la ingesta (recibe una vacante y la guarda en SQL)
        [HttpPost]
        public async Task<ActionResult<Vacante>> PostVacante(Vacante vacante)
        {
            _context.Vacantes.Add(vacante);
            await _context.SaveChangesAsync();

            return Ok(vacante);
        }
    }
}
