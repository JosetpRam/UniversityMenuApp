using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;
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
            
        }
    }
}
