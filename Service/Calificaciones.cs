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
        private AlumnoRepository alumnoRepo;
        private MateriaRepository materiaRepo;
        private NotaRepository notaRepo;

        public Calificaciones(
            IAlumnoRepository alumnoRepository,
            IMateriaRepository materiaRepository,
            INotaRepository notaRepository)
        {
            _alumnoRepository = alumnoRepository;
            _materiaRepository = materiaRepository;
            _notaRepository = notaRepository;
        }

        public Calificaciones(AlumnoRepository alumnoRepo, MateriaRepository materiaRepo, NotaRepository notaRepo)
        {
            this.alumnoRepo = alumnoRepo;
            this.materiaRepo = materiaRepo;
            this.notaRepo = notaRepo;
        }

        public List<ReporteCalificaciones> NotasxAlumno(int id)
        {
            var alumnos = _alumnoRepository.GetAll();
            var materias = _materiaRepository.GetAll();
            var notas = _notaRepository.GetAll();

            var resultado = (
                from nota in notas
                where nota.IdAlumno == id
                join alumno in alumnos on nota.IdAlumno equals alumno.Id
                join materia in materias on nota.IdMateria equals materia.Id
                select new ReporteCalificaciones
                {
                    IdAlumno = alumno.Id,
                    Alumno = alumno.FullName,
                    IdMateria = materia.Id,
                    Materia = materia.Name,
                    Nota = nota.IdNota
                }
            ).ToList();

            return resultado;
        }

        public List<ReporteCalificaciones> NotasxMateria(int id)
        {
            var alumnos = _alumnoRepository.GetAll();
            var materias = _materiaRepository.GetAll();
            var notas = _notaRepository.GetAll();

            var resultado = (
                from nota in notas
                where nota.IdMateria == id
                join alumno in alumnos on nota.IdAlumno equals alumno.Id
                join materia in materias on nota.IdMateria equals materia.Id
                select new ReporteCalificaciones
                {
                    IdAlumno = alumno.Id,
                    Alumno = alumno.FullName,
                    IdMateria = materia.Id,
                    Materia = materia.Name,
                    Nota = nota.IdNota
                }
            ).ToList();

            return resultado;
        }

        public List<ReporteCalificaciones> ObtenerNotasDetalladas()
        {
            var alumnos = _alumnoRepository.GetAll();
            var materias = _materiaRepository.GetAll();
            var notas = _notaRepository.GetAll();

            var resultado = (
                from nota in notas
                join alumno in alumnos on nota.IdAlumno equals alumno.Id
                join materia in materias on nota.IdMateria equals materia.Id
                select new ReporteCalificaciones
                {
                    IdAlumno = alumno.Id,
                    Alumno = alumno.FullName,
                    IdMateria = materia.Id,
                    Materia = materia.Name,
                    Nota = nota.IdNota
                }
            ).ToList();

            return resultado;
        }
    }
}
