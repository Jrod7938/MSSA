﻿using Microsoft.Extensions.Logging;
using W12D3C1.Services;
using W12D3C1.View;
using W12D3C1.ViewModel;

namespace W12D3C1
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
            builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
            builder.Services.AddSingleton<IMap>(Map.Default);
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MonkeyService>();
            builder.Services.AddSingleton<MonkeysViewModel>();
            builder.Services.AddTransient<MonkeyDetailsViewModel>();
            builder.Services.AddTransient<DetailsPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
