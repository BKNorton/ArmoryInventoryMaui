using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Models.Pickers;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

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

        private string defects;
        public string Defects
        {
            get => defects;
            set
            {
                SetProperty(ref defects, value);
            }
        }

        private string missingComponents;
        public string MissingComponents
        {
            get => missingComponents;
            set
            {
                SetProperty(ref missingComponents, value);
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
            this.defects = string.Empty;
            this.missingComponents = string.Empty;
            this.repository = repository;

            HasAllComponents = new TrueOrFalsePicker().TrueOrFalseCollection;
            MissionCapable = new TrueOrFalsePicker().TrueOrFalseCollection;
            CheckedOut = new TrueOrFalsePicker().TrueOrFalseCollection;
            ItemType = new ItemTypePicker().ItemTypesCollection;

            
        }

        public async Task LoadItem(string itemId)
        {
            this.Item = await this.repository.GetItemByIdAsync(itemId);

            ItemTypeSelectedItem = ItemType[this.Item.ItemType.ListIndex];

            for (int i = 0; i < this.Item.Defects.Count; i++)
            {
                Defects += this.Item.Defects[i];

                if (i != this.Item.Defects.Count-1) Defects += ", ";
            }

            for (int i = 0; i < this.Item.MissingComponents.Count; i++)
            {
                MissingComponents += this.Item.MissingComponents[i];

                if (i != this.Item.MissingComponents.Count - 1) MissingComponents += ", ";
            }
        }


        [RelayCommand]
        public async Task GoToMainPageAsync()
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
