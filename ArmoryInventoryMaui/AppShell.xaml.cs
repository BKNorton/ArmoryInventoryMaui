using ArmoryInventoryMaui.Views;

namespace ArmoryInventoryMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(InventoryMainPage), typeof(InventoryMainPage));
            Routing.RegisterRoute(nameof(MissionsPage), typeof(MissionsPage));
            Routing.RegisterRoute(nameof(RetransPage), typeof(RetransPage));
            Routing.RegisterRoute(nameof(AddItemPage), typeof(AddItemPage));
        }
    }
}
