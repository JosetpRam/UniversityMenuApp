using ClosedXML.Excel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
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

    [RelayCommand]

    private void ExportToExcel()
    {
        var dialog = new SaveFileDialog
        {
            Filter = "Excel Files|*.xlsx",
            Title = "Export Subjects to Excel"
        };
        if (dialog.ShowDialog() != true)
            return;

        using var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("Subjects");

        ws.Cell(1, 1).Value = "Id";
        ws.Cell(1, 2).Value = "Name";
        ws.Row(1).Style.Font.Bold = true;

        int row = 2;
        foreach (var subject in Subjects)
        {
            ws.Cell(row, 1).Value = subject.Id;
            ws.Cell(row, 2).Value = subject.Name;
            row++;
        }

        ws.Columns().AdjustToContents();
        wb.SaveAs(dialog.FileName);

    }

}

