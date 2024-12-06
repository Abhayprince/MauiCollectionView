using MauiCollectionView.MultiSelection.Model;
using MauiCollectionView.MultiSelection.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiCollectionView.MultiSelection;
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

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<SeatViewModel>().AddSingleton<MainPage>();
        return builder.Build();
    }
}
