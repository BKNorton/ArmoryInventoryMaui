using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ArmoryInventoryMaui.ViewModels
{
    public partial class InventoryMainViewModel : ObservableObject
    {
        public ObservableCollection<Item> Items { get; set; }
        private Item selectedItem;

        public Item SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
            }
        }

        public string ItemBackgroundColorNormal { get; set; }
        public string ItemBackgroundAltColorNormal { get; set; }
        public string ItemBackgroundColorSelected { get; set; }

        public string ItemTextColorNormal { get; set; }
        public string ItemTextColorSelected { get; set; }

        private IRepository repository;

        public InventoryMainViewModel(IRepository repository)
        {
            this.Items = [];
            this.selectedItem = new Item();
            this.repository = repository;

            ItemBackgroundColorNormal = "White";
            ItemBackgroundAltColorNormal = "LightGrey";
            ItemBackgroundColorSelected = "Blue";

            ItemTextColorNormal = "Black";
            ItemTextColorSelected = "White";
        }

        public async Task LoadContactsAsync()
        {
            this.Items.Clear();

            var items = await repository.GetItemsAsync();
            if (items != null && items.Count > 0)
            {
                for (int i = 0; i<items.Count; i++)
                {
                    this.Items.Add(items[i]);
                }
            }
        }

        [RelayCommand]
        public async Task GoToAddItemPageAsync()
        {
            await Shell.Current.GoToAsync(nameof(AddItemPage));
        }

        [RelayCommand]
        public async Task GoToEditItemPageAsync()
        {
            if (this.SelectedItem.Id == Guid.Empty) return;
            await Shell.Current.GoToAsync($"{nameof(EditItemPage)}?Id={selectedItem.Id}");
        }

        [RelayCommand]
        public async Task DeleteItemAsync()
        {
            if (SelectedItem == null || this.SelectedItem.Id == Guid.Empty) return;
            await repository.RemoveItemAsync(this.SelectedItem);
            await LoadContactsAsync();
        }
    }  
}
