using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Plugin.Maui.Audio;
using Tuunes_Assessment.Services;
using Tuunes_Assessment.ViewModels;
using Tuunes_Assessment.Views;

namespace Tuunes_Assessment;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMediaElement()
			.UseMauiCommunityToolkit()

			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<ListenPage>();
		builder.Services.AddTransient<DetailPage>();

		builder.Services.AddSingleton<ListenViewModel>();
		builder.Services.AddTransient<DetailViewModel>();

		builder.Services.AddSingleton<INavigationService, NavigationService>();

		builder.Services.AddSingleton(AudioManager.Current);


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

