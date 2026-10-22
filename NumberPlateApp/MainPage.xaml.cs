using NumberPlateApp.Lib.ViewModels;

namespace NumberPlateApp;

public partial class MainPage : ContentPage
{
    

    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

    
}
