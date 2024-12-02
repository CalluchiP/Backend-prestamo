using App_Prestamos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_Prestamos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {

        private readonly AppPrestamosContext _appprestamosContext;

        public PrestamosController(AppPrestamosContext appprestamosContext)
        {
            _appprestamosContext = appprestamosContext;
        }

        [HttpGet]
        [Route("Lista")]

        public async Task<IActionResult> Lista ()
        {
            var listaPrestamos = await _appprestamosContext.Prestamos.ToListAsync();
            return Ok(listaPrestamos);
        }
        [HttpPost]
        [Route("Agregar")]

        public async Task<IActionResult> Agregar([FromBody]Prestamo request)
        {
            await _appprestamosContext.Prestamos.AddAsync(request);
            await _appprestamosContext.SaveChangesAsync();
            return Ok(request);
               
        }

        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
             var PrestamoEliminar = await _appprestamosContext.Prestamos.FindAsync(id);

            if (PrestamoEliminar == null)
                return BadRequest("No existe el prestamo");
            _appprestamosContext.Prestamos.Remove(PrestamoEliminar);
            await _appprestamosContext.SaveChangesAsync();
            return Ok();
        }
       

    }
}
