﻿using Microsoft.Extensions.Logging;
using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<MonkeyService>();
        builder.Services.AddTransient<DetailsPage>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MonkeysViewModel>();
		builder.Services.AddTransient<MonkeyDetailsViewModel>();


		return builder.Build();
	}
}
