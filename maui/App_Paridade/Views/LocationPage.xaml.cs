using App_Paridade.ViewModels;
namespace App_Paridade.Views; 
public partial class LocationPage : ContentPage 
{ 
    private readonly LocationViewModel _viewModel; 
    public LocationPage(LocationViewModel viewModel) 
    { 
        InitializeComponent(); 
        BindingContext = _viewModel = viewModel; 
    } 
    protected override async void OnAppearing() 
    { 
        base.OnAppearing(); 
        
        // Carregar localiza��o automaticamente ao abrir a p�gina 
        await _viewModel.GetLocationAsync(); 
    } 
}