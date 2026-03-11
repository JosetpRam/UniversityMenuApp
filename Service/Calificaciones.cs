using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repos;
using UniversityMenuApp.Repositories;

namespace UniversityMenuApp.Service
{
    public class Calificaciones : ICalificaciones
    {
        private readonly IStudentRepository studentRepository;

        private readonly ISubjectRepository subjectRepository;
        private readonly IAlumnoNotasRepository alumnoNotasRepository;

        public Service(IAlumno, INota, IMateria)
        { 

        }
        public List<Calificaciones> NotasxAlumno(int Id)
        {
            
        }

        public List<Calificaciones> NotasxMateria(int Id)
        {

        }



    }
}
