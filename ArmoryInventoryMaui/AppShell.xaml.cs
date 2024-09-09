using ArmoryInventoryMaui.Views;

namespace ArmoryInventoryMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(InventoryMainPage), typeof(InventoryMainPage));
        }
    }
}
