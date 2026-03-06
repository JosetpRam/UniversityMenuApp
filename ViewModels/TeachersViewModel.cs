using ClosedXML.Excel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
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

    [RelayCommand]

    private void ExportToExcel()
    {
        var dialog = new SaveFileDialog
        {
            Filter = "Excel Files|*.xlsx",
            Title = "Export Teachers to Excel"
        };
        if (dialog.ShowDialog() != true)
            return;

        using var wb = new XLWorkbook();
        var ws = wb.Worksheets.Add("Teachers");

        ws.Cell(1, 1).Value = "Id";
        ws.Cell(1, 2).Value = "Full Name";
        ws.Cell(1, 3).Value = "Email";
        ws.Row(1).Style.Font.Bold = true;

        int row = 2;
        foreach (var teacher in Teachers)
        {
            ws.Cell(row, 1).Value = teacher.Id;
            ws.Cell(row, 2).Value = teacher.FullName;
            ws.Cell(row, 3).Value = teacher.Email;
            row++;
        }

        ws.Columns().AdjustToContents();
        wb.SaveAs(dialog.FileName);

    }

}
