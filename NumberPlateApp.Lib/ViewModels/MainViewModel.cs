using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NumberPlateApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPlateApp.Lib.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private IRepository _repository;
    public MainViewModel(IRepository repository)
    {
        _repository = repository;
    }

    [ObservableProperty]
    public partial string Name { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string Numberplate { get; set; } = string.Empty;

    [RelayCommand]
    private void Add()
    {

    }

    [RelayCommand]
    private void load()
    {

    }
}
