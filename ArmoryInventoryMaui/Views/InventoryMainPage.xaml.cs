using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.ViewModels;

namespace ArmoryInventoryMaui.Views;

public partial class InventoryMainPage : ContentPage
{
    private readonly InventoryMainViewModel mainViewModel;

    public InventoryMainPage(InventoryMainViewModel mainViewModel)
    {
        InitializeComponent();
        this.mainViewModel = mainViewModel;
        this.BindingContext = mainViewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        this.EditBttn.IsEnabled = true;

        await this.mainViewModel.LoadContactsAsync();
    }

    private void Collection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        mainViewModel.SelectedItem = (Item)Collection.SelectedItem;
    }
}