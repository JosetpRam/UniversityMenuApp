using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repositories;
using UniversityMenuApp.Service;

namespace UniversityMenuApp.ViewModels
{
    public partial class AlumnoNotasViewModel : ObservableObject
    {
        private readonly ICalificaciones _calificaciones;

        public ObservableCollection<ReporteCalificaciones> Calificaciones { get; } = new();
        public ObservableCollection<Student> Alumnos { get; } = new();
        public ObservableCollection<Subject> Materias { get; } = new();

        [ObservableProperty]
        private Student? selectedAlumno;

        [ObservableProperty]
        private Subject? selectedMateria;

        public AlumnoNotasViewModel() 
        {
            var alumnoRepo = new AlumnoRepository();
            var materiaRepo = new MateriaRepository();
            var notaRepo = new NotaRepository();

            _calificaciones = new Calificaciones(alumnoRepo, materiaRepo, notaRepo);

            foreach (var a in alumnoRepo.GetAll())
                Alumnos.Add(a);

            foreach (var m in materiaRepo.GetAll())
                Materias.Add(m);

            CargarTodas();
        }

        private void CargarTodas()
        {
            throw new NotImplementedException();
        }
    }
}
