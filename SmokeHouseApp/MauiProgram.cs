using SmokeHouseApp.Extensions;

namespace SmokeHouseApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            MauiAppBuilder builder = MauiApp.CreateBuilder();

            builder.ConfigureApp();
            builder.RegisterTypes();
            builder.AddDebugLogger();

            return builder.Build();
        }
    }
}
