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
        private readonly IAlumnoRepository _alumnoRepository;
        private readonly IMateriaRepository _materiaRepository;
        private readonly INotaRepository _notaRepository;

        public Calificaciones(
            IAlumnoRepository alumnoRepository,
            IMateriaRepository materiaRepository,
            INotaRepository notaRepository)
        {
            _alumnoRepository = alumnoRepository;
            _materiaRepository = materiaRepository;
            _notaRepository = notaRepository;
        }



    }
}
