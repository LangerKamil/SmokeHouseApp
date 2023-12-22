using SmokeHouseApp.Views.Home.ViewModels;

namespace SmokeHouseApp.Views.Home;

public partial class HomeMainView : ContentPage
{
	public HomeMainView(HomeMainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}