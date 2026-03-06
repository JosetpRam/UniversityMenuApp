using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using UniversityMenuApp.Models;
using UniversityMenuApp.Repositories;

namespace UniversityMenuApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IMenuRepository _menuRepo;

    public ObservableCollection<MenuOption> MenuOptions { get; } = new();

    [ObservableProperty]
    private object? currentViewModel;

    public MainViewModel(IMenuRepository menuRepo)
    {
        _menuRepo = menuRepo;

        foreach (var option in _menuRepo.GetMenuOptions())
            MenuOptions.Add(option);

        CurrentViewModel = new HomeViewModel();
    }

    [RelayCommand]
    private void Navigate(MenuOption? option)
    {
        if (option is null) return;

        CurrentViewModel = option.Route switch
        {
            "Home" => new HomeViewModel(),
            "Students" => new StudentsViewModel(),
            "Teachers" => new TeachersViewModel(),
            "Subjects" => new SubjectsViewModel(),
            _ => new HomeViewModel()
        };
    }
}
