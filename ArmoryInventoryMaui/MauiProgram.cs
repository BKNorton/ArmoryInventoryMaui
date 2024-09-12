using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Repositories;
using ArmoryInventoryMaui.ViewModels;
using ArmoryInventoryMaui.Views;
using Microsoft.Extensions.Logging;

namespace ArmoryInventoryMaui
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

            builder.Services.AddSingleton<IRepository, InMemoryRepository>();

            builder.Services.AddTransient<InventoryMainPage>();
            builder.Services.AddTransient<MissionsPage>();
            builder.Services.AddTransient<RetransPage>();
            builder.Services.AddSingleton<AddItemPage>();

            builder.Services.AddSingleton<InventoryMainViewModel>();
            builder.Services.AddSingleton<ItemViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
