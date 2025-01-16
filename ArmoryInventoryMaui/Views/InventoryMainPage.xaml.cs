using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.ViewModels;
using Microsoft.Maui.Controls.Internals;
using System.Data;

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

        // Refresh the Inventory everytime you navigate back to mainpage so
        // that any changes that have been made are reflected
        await this.mainViewModel.ReFreshItemsAsync();
    }

}