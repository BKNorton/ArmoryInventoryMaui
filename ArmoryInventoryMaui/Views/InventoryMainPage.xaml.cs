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
        await this.mainViewModel.LoadFreshItemsAsync();
    }

}