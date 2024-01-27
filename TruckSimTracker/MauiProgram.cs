using Microsoft.Extensions.Logging;
using TruckSimTracker.Data.Repositories;

namespace TruckSimTracker
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            string dbPath = FileAccessHelper.GetLocalFilePath("truck-sim-tracker.db3");
            builder.Services.AddSingleton<ITruckSimTrackerRepository>(s => ActivatorUtilities.CreateInstance<TruckSimTrackerRepository>(s, dbPath));


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
