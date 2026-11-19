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
        NumberPlateApp.Data.Models.Numberplate n = new();
        n.Name = this.Name;
        n.LicensePlate = this.Numberplate;
        bool result = _repository.Add(n);
        if (result)
        {
            Numberplate = string.Empty;
            Name = string.Empty;
            System.Diagnostics.Debug.WriteLine($"Added: {n.Name} - {n.LicensePlate}");
        }
        else
        {
            System.Diagnostics.Debug.WriteLine($"Failed to add: {n.Name} - {n.LicensePlate}");
        }
    }

    [RelayCommand]
    private void load()
    {
        System.Diagnostics.Debug.WriteLine("MainViewModel loading....");

        _repository.Load();
    }
}
