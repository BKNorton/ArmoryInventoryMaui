using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Models.Enums;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Type = ArmoryInventoryMaui.Models.Enums.Type;

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

        //Enums used for filter pickers
        public List<string> ItemTypePicker
        {
            get => Enum.GetNames(typeof(Type)).ToList();
        }

        public List<string> TrueOrFalsePicker
        {
            get => Enum.GetNames(typeof(TrueOrFalse)).ToList();
        }

        //User input to search for Item based on serial number
        private string filterText;
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                LoadSearchItemsAsync(filterText).GetAwaiter().GetResult();
            }
        }

        //User selections to filter Inventory
        //Whenever a filter selection is made call LoadFilterdItemsAsync to refresh the view with the filterd data
        private int itemTypeFilterIndex;
        public int ItemTypeFilterIndex
        {
            get => itemTypeFilterIndex;
            set
            {
                itemTypeFilterIndex = value;
                LoadFilteredItemsAsync().GetAwaiter().GetResult();
            }
        }

        private int hasCompFilterIndex;
        public int HasCompFilterIndex

        {
            get => hasCompFilterIndex;
            set
            {
                hasCompFilterIndex = value;
                LoadFilteredItemsAsync().GetAwaiter().GetResult();
            }
        }

        private int missCapFilterIndex;
        public int MissCapFilterIndex

        {
            get => missCapFilterIndex;
            set
            {
                missCapFilterIndex = value;
                LoadFilteredItemsAsync().GetAwaiter().GetResult();
            }
        }
        private int checkOutFilterIndex;
        public int CheckOutFilterIndex

        {
            get => checkOutFilterIndex;
            set
            {
                checkOutFilterIndex = value;
                LoadFilteredItemsAsync().GetAwaiter().GetResult();
            }
        }


        public InventoryMainViewModel(IRepository repository)
        {
            ItemCollection = [];
            selectedItem = new Item();
            filterText = string.Empty;
            this.repository = repository;
        }


        /// <summary>
        /// Clears Item collection and uses repository to refill collection 
        /// </summary>
        /// <returns></returns>
        public async Task ReFreshItemsAsync()
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
        

        /// <summary>
        /// User input in searchbar used to search database by serial number
        /// </summary>
        /// <param name="filterText"></param>
        /// <returns></returns>
        public async Task LoadSearchItemsAsync(string filterText)
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

        // Helper method. Clears Item Collection and reload it based off of filter selections. This will be called every time a filter selection is made in the view.
        private async Task LoadFilteredItemsAsync()
        {
            ItemCollection.Clear();
            var items = await repository.GetItemsByFiltersAsync(itemTypeFilterIndex, hasCompFilterIndex, missCapFilterIndex, checkOutFilterIndex);

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
                await ReFreshItemsAsync();
            }
        }
    }  
}
