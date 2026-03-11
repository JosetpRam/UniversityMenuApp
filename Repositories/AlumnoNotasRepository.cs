using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class AlumnoNotasRepository : IAlumnoNotasRepository
    {
        public List<AlumnoNotas> GetAllAsync()
        {
            return new List<AlumnoNotas>
            {
                new AlumnoNotas { IdAlumno = 1, IdMateria = 1, IdNota = 85 },
                new AlumnoNotas { IdAlumno = 1, IdMateria = 2, IdNota = 90 },
                new AlumnoNotas { IdAlumno = 2, IdMateria = 1, IdNota = 78 },
                new AlumnoNotas { IdAlumno = 2, IdMateria = 2, IdNota = 88 },
                
            };
        }



    }
}
