using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repositories;

namespace UniversityMenuApp.ViewModels;

public partial class SubjectsViewModel : ObservableObject
{
    private readonly ISubjectRepository _subjectRepo;

    public ObservableCollection<Subject> Subjects { get; } = new();

    [ObservableProperty]
    private Subject? selectedSubject;

    [ObservableProperty]
    private string? formName;

    public SubjectsViewModel()
    {
        LoadSubjects();
    }
    private void LoadSubjects()
    {
        Subjects.Clear();
        Subjects.Add(new Subject { Id = 1, Name = "Matemáticas" });
        Subjects.Add(new Subject { Id = 2, Name = "Programación I" });
        Subjects.Add(new Subject { Id = 3, Name = "Base de Datos" });
        Subjects.Add(new Subject { Id = 4, Name = "Estructuras de Datos" });
    }
}

