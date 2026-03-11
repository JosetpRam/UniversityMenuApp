using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMenuApp.Models
{
    public class ReporteCalificaciones
    {
        public int IdAlumno { get; set; }
        public string Alumno { get; set; } = "";
        public int IdMateria { get; set; }
        public string Materia { get; set; } = "";
        public int Nota { get; set; }


    }
}
