using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class TeachersViewModel : ObservableObject
{
    public ObservableCollection<Teacher> Teachers { get; } = new();
    [ObservableProperty]
    private Teacher? selectedTeacher;

    [ObservableProperty]
    private string? formName;
    [ObservableProperty]
    private int? formEmail;
    [ObservableProperty]
    private int? grid;

    public TeachersViewModel()
    {
        LoadTeachers();
    }

    private void LoadTeachers()
    {
        Teachers.Clear();
        Teachers.Add(new Teacher { Id = 1, FullName = "Aron Claros", Email = "arcla@unicah.edu" });
        Teachers.Add(new Teacher { Id = 2, FullName = "Johana Claros", Email = "johanac@unicah.edu" });
    }

}
