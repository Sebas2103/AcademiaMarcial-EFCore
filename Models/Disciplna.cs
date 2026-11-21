using System.ComponentModel.DataAnnotations;

namespace AcademiaMarcial.Models
{
    public class Disciplina
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(80)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(300)]
        public string? Descripcion { get; set; }

        [Range(1, 5, ErrorMessage = "El nivel va de 1 a 5")]
        [Display(Name = "Nivel de dificultad")]
        public int NivelDificultad { get; set; }

        public ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
    }
}