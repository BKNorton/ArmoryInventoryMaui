using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Models.Pickers;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ArmoryInventoryMaui.ViewModels
{
    public partial class ItemViewModel : ObservableObject
    {
        private readonly IRepository repository;

        private Item item;
        public Item Item
        {
            get => item;
            set
            {
                SetProperty(ref item, value);
            }
        }

        private PickerItem itemTypeSelectedItem;
        public PickerItem ItemTypeSelectedItem
        {
            get => itemTypeSelectedItem;
            set
            {
                SetProperty(ref itemTypeSelectedItem, value);
            }
        }

        private PickerItem hasComponentsSelectedItem;
        public PickerItem HasComponentsSelectedItem
        {
            get => hasComponentsSelectedItem;
            set
            {
                SetProperty(ref hasComponentsSelectedItem, value);
            }
        }

        private PickerItem missionCapableSelectedItem;
        public PickerItem MissionCapableSelectedItem
        {
            get => missionCapableSelectedItem;
            set
            {
                SetProperty(ref missionCapableSelectedItem, value);
            }
        }

        private PickerItem checkedOutSelectedItem;
        public PickerItem CheckedOutSelectedItem
        {
            get => checkedOutSelectedItem;
            set
            {
                SetProperty(ref checkedOutSelectedItem, value);
            }
        }

        public ObservableCollection<PickerItem> HasAllComponents { get; set; }
        public ObservableCollection<PickerItem> MissionCapable { get; set; }
        public ObservableCollection<PickerItem> CheckedOut { get; set; }
        public ObservableCollection<PickerItem> ItemType { get; set; }

        public ItemViewModel(IRepository repository)
        {
            this.item = new Item();
            this.itemTypeSelectedItem = new PickerItem();
            this.hasComponentsSelectedItem = new PickerItem();
            this.missionCapableSelectedItem = new PickerItem();
            this.checkedOutSelectedItem = new PickerItem();
            this.repository = repository;

            HasAllComponents = new TrueOrFalsePicker().TrueOrFalseCollection;
            MissionCapable = new TrueOrFalsePicker().TrueOrFalseCollection;
            CheckedOut = new TrueOrFalsePicker().TrueOrFalseCollection;
            ItemType = new ItemTypePicker().ItemTypesCollection;
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
