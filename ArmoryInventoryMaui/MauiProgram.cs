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


            //Dependency Injections//
            
            //Repository
            builder.Services.AddSingleton<IRepository, InMemoryRepository>();

            //Pages
            builder.Services.AddTransient<InventoryMainPage>();
            builder.Services.AddTransient<MissionsPage>();
            builder.Services.AddTransient<RetransPage>();
            builder.Services.AddTransient<AddItemPage>();
            builder.Services.AddTransient<EditItemPage>();

            //View Models
            builder.Services.AddTransient<InventoryMainViewModel>();
            builder.Services.AddTransient<ItemViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
