using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_Parcial_VisitasMedicas.Context;
using WebAPI_Parcial_VisitasMedicas.Models;

namespace WebAPI_Parcial_VisitasMedicas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbulanciaController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AmbulanciaController(AppDbContext context)
        {
            _context = context; // Esto es inyectar dependencias
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ambulancia>> Get()
        {
            var AmbEmpresas = _context.Ambulancias.ToList();
            return Ok(AmbEmpresas);
        }

        [HttpGet("{id}")]
        public ActionResult<Ambulancia> GetWith(int id)
        {
            var amb = _context.Ambulancias.FirstOrDefault(x => x.Id == id);

            if (amb == null)
            {
                return NotFound();
            }
            return Ok(amb);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ambulancia amb)
        {
            _context.Ambulancias.Add(amb);
            _context.SaveChanges();
                        
            return new CreatedAtRouteResult("ObetenerAmbulancia", new { id = amb.Id }, amb);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ambulancia amb)
        {
            if (id != amb.Id)
            {
                return BadRequest();
            }
            _context.Entry(amb).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        //DELETE        
        [HttpDelete("{id}")]
        public ActionResult<Ambulancia> Delete(int id)
        {
            var autorDeleted = (from d in _context.Ambulancias
                                where d.Id == id
                                select d).SingleOrDefault();

            if (autorDeleted == null)
            {
                return NotFound();
            }

            _context.Ambulancias.Remove(autorDeleted);
            _context.SaveChanges();

            return autorDeleted;
            
        }
    }
}
