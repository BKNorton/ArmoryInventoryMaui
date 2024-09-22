using ArmoryInventoryMaui.ViewModels;

namespace ArmoryInventoryMaui.Views;

public partial class AddItemPage : ContentPage
{
    private readonly ItemViewModel itemViewModel;

    public AddItemPage(ItemViewModel itemViewModel)
    {
        InitializeComponent();
        this.itemViewModel = itemViewModel;
        this.BindingContext = itemViewModel;
    }
}