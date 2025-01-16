using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Models.Enums;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Type = ArmoryInventoryMaui.Models.Enums.Type;

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

        private int itemTypeSelectedIndex;
        public int ItemTypeSelectedIndex
        {
            get => itemTypeSelectedIndex;
            set
            {
                SetProperty(ref itemTypeSelectedIndex, value);
            }
        }

        private int hasComponentsSelectedIndex;
        public int HasComponentsSelectedIndex
        {
            get => hasComponentsSelectedIndex;
            set
            {
                SetProperty(ref hasComponentsSelectedIndex, value);
            }
        }

        private int missionCapableSelectedIndex;
        public int MissionCapableSelectedIndex
        {
            get => missionCapableSelectedIndex;
            set
            {
                SetProperty(ref missionCapableSelectedIndex, value);
            }
        }

        private int checkedOutSelectedIndex;
        public int CheckedOutSelectedIndex
        {
            get => checkedOutSelectedIndex;
            set
            {
                SetProperty(ref checkedOutSelectedIndex, value);
            }
        }

        private string defects;
        public string Defects
        {
            get => defects;
            set
            {
                SetProperty(ref defects, value);
                Item.Defects = value.Split(',').ToList();
            }
        }

        private string missingComponents;
        public string MissingComponents
        {
            get => missingComponents;
            set
            {
                SetProperty(ref missingComponents, value);
                Item.MissingComponents = value.Split(",").ToList();
            }
        }

        public List<string> ItemTypePicker
        {
            get => Enum.GetNames(typeof(Type)).ToList();
        }

        public List<string> TrueOrFalsePicker
        {
            get => Enum.GetNames(typeof(TrueOrFalse)).ToList();
        }

        public ItemViewModel(IRepository repository)
        {
            item = new Item();
            defects = string.Empty;
            missingComponents = string.Empty;
            this.repository = repository;
        }

        public async Task LoadItem(string itemId)
        {
            if (string.IsNullOrWhiteSpace(itemId)) return;
            Item = await repository.GetItemByIdAsync(itemId);
            if (Item is null || Item.Id == Guid.Empty) return;

            ItemTypeSelectedIndex = (int)Item.ItemType;
            HasComponentsSelectedIndex = (int)Item.HasAllComponents;
            MissionCapableSelectedIndex = (int)Item.MissionCapable;
            CheckedOutSelectedIndex = (int)Item.CheckedOut;

            var defString = string.Empty;
            if (Item.Defects != null)
            {
                for (int i = 0; i < Item.Defects.Count; i++)
                {
                    defString += Item.Defects[i];

                    if (i != Item.Defects.Count - 1) defString += ", ";
                }
                Defects = defString;
            }

            var missString = string.Empty;
            if (Item.MissingComponents != null)
            {
                for (int i = 0; i < Item.MissingComponents.Count; i++)
                {
                    missString += Item.MissingComponents[i];

                    if (i != Item.MissingComponents.Count - 1) missString += ", ";
                }
                MissingComponents = missString;
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
            Item.Id = Guid.NewGuid();
            SetItem();

            await repository.AddItemAsync(item);
            await Shell.Current.GoToAsync($"/{nameof(InventoryMainPage)}");
        }

        [RelayCommand]
        public async Task UpdateItem()
        {
            SetItem();

            await repository.UpdateItemAsync(item.Id, item);
            await Shell.Current.GoToAsync($"/{nameof(InventoryMainPage)}");
        }

        private void SetItem()
        {
            if (Enum.TryParse(itemTypeSelectedIndex.ToString(), out Type typeValue))
            {
                Item.ItemType = typeValue;
            }

            if (Enum.TryParse(hasComponentsSelectedIndex.ToString(), out TrueOrFalse hasCompValue))
            {
                Item.HasAllComponents = hasCompValue;
            }

            if (Enum.TryParse(missionCapableSelectedIndex.ToString(), out TrueOrFalse missCapValue))
            {
                Item.MissionCapable = missCapValue;
            }

            if (Enum.TryParse(checkedOutSelectedIndex.ToString(), out TrueOrFalse checkOutValue))
            {
                Item.CheckedOut = checkOutValue;
            }
        }
    }
}
