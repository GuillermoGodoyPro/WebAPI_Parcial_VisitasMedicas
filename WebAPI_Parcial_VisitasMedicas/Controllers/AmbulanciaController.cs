using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI_Parcial_VisitasMedicas.Context;

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

    }
}
