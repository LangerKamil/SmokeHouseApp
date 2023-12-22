using Microsoft.Extensions.Logging;
using SmokeHouseApp.Views.Home;
using SmokeHouseApp.Views.Home.ViewModels;
using SmokeHouseApp.Views.Sensor;
using SmokeHouseApp.Views.Sensor.ViewModels;
using SmokeHouseApp.Views.Settings;
using SmokeHouseApp.Views.Settings.ViewModels;

namespace SmokeHouseApp.Extensions
{
    public static class BuilderExtensions
    {
        public static void ConfigureApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
        }

        public static void RegisterTypes(this MauiAppBuilder builder)
        {
            builder.RegisterViews();
        }

        public static void AddDebugLogger(this MauiAppBuilder builder)
        {
#if DEBUG
            builder.Logging.AddDebug();
#endif
        }

        private static void RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HomeMainViewModel>();
            builder.Services.AddTransient<SensorMainViewModel>();
            builder.Services.AddTransient<SettingsMainViewModel>();

            builder.Services.AddTransient<HomeMainView>();
            builder.Services.AddTransient<SensorMainView>();
            builder.Services.AddTransient<SettingsMainView>();
        }

        private static void RegisterServices(this MauiAppBuilder builder)
        {
        }
    }
}
