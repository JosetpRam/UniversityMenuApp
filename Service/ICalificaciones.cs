using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repos;

namespace UniversityMenuApp.Service
{
    public interface ICalificaciones
    {

        List<ReporteCalificaciones> NotasxAlumno(int id);
        List<ReporteCalificaciones> NotasxMateria(int id);
        List<ReporteCalificaciones> ObtenerNotasDetalladas();
    }
}
