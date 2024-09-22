using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ArmoryInventoryMaui.ViewModels
{
    public partial class ItemViewModel : ObservableObject
    {
        private Item item;
        private readonly IRepository repository;

        public Item Item
        {
            get => item;
            set
            {
                SetProperty(ref item, value);
            }
        }
        public ItemViewModel(IRepository repository)
        {
            this.item = new Item();
            this.repository = repository;
            
        }

        public async Task LoadItem(string itemId)
        {
            this.Item = await this.repository.GetItemByIdAsync(itemId);
        }


        [RelayCommand]
        public async Task GoToInventoryMainPageAsync()
        {
            await Shell.Current.GoToAsync($"/{nameof(InventoryMainPage)}");
        }

        [RelayCommand]
        public async Task AddContact()
        {
            await this.repository.AddItemAsync(this.item);
            await Shell.Current.GoToAsync($"/{nameof(InventoryMainPage)}");
        }
    }
}
