using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_Parcial_VisitasMedicas.Models
{
    public class Ambulancia
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Empresa { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Codigo { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "El código es obligatorio")]
        public string ObraSocial { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "El código es obligatorio")]
        public string Afiliado { get; set; }
        [Required(ErrorMessage = "Field required!")]
        public int DNI { get; set; }
        [Required(ErrorMessage = "Field required!")]
        public int Precio { get; set; }
    }
}
