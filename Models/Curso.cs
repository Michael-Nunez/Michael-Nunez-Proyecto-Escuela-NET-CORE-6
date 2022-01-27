using System.ComponentModel.DataAnnotations;

namespace ASP_NetCore_Proyecto.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre del curso es requerido.")]        
        public override string Nombre { get => base.Nombre; set => base.Nombre = value; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        [Display(Prompt = "Dirección Correspondencia.", Name = "Address")]
        [Required(ErrorMessage = "La dirección del curso es requerida.")]
        [MinLength(10, ErrorMessage = "El tamaño minimo de caracteres es 10.")]
        public string Dirección { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
    }
}