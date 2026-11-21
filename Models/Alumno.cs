using System.ComponentModel.DataAnnotations;

namespace AcademiaMarcial.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de inscripción")]
        public DateTime FechaInscripcion { get; set; } = DateTime.Today;

        [StringLength(30)]
        [Display(Name = "Cinturón")]
        public string Cinturon { get; set; } = "Blanco";

        [Display(Name = "Disciplina")]
        public int DisciplinaId { get; set; }
[StringLength(20)]
public string? Telefono { get; set; }
        public Disciplina? Disciplina { get; set; }
    }
}