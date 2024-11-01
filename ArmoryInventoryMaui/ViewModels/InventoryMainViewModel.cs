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
        public ObservableCollection<Item> ItemCollection { get; set; }
        private IRepository repository;

        private Item selectedItem;
        public Item SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
            }
        }

        private string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                LoadFilteredContactsAsync(filterText).GetAwaiter().GetResult();
            }
        }

        public InventoryMainViewModel(IRepository repository)
        {
            ItemCollection = [];
            selectedItem = new Item();
            filterText = string.Empty;
            this.repository = repository;
        }

        public async Task LoadFreshContactsAsync()
        {
            ItemCollection.Clear();

            var items = await repository.GetItemsAsync();
            if (items != null && items.Count > 0)
            {
                for (int i = 0; i<items.Count; i++)
                {
                    ItemCollection.Add(items[i]);
                }
            }
        }

        public async Task LoadFilteredContactsAsync(string filterText)
        {
            ItemCollection.Clear();

            var items = await repository.GetItemsBySearchAsync(filterText);
            if (items != null && items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    ItemCollection.Add(items[i]);
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
            if (selectedItem is null) return;
            if (selectedItem.Id == Guid.Empty) return;
            await Shell.Current.GoToAsync($"{nameof(EditItemPage)}?Id={selectedItem.Id}");
        }

        [RelayCommand]
        public async Task DeleteItemAsync()
        {
            if (selectedItem is null) return;
            if (selectedItem.Id != Guid.Empty)
            {
                await repository.RemoveItemAsync(selectedItem);
                await LoadFreshContactsAsync();
            }
        }
    }  
}
