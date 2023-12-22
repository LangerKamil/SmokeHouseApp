using SmokeHouseApp.Views.Settings.ViewModels;

namespace SmokeHouseApp.Views.Settings;

public partial class SettingsMainView : ContentPage
{
	public SettingsMainView(SettingsMainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}