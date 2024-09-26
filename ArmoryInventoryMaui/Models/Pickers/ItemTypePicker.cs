using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.Models.Pickers
{
    public class ItemTypePicker : ObservableObject 
    {
        public ObservableCollection<PickerItem> ItemTypesCollection;

        public ItemTypePicker()
        {
            ItemTypesCollection = 
            [
                new PickerItem()
                {
                    Text = "Antenna",
                    ListIndex = 0,
                },
                new PickerItem()
                {
                    Text = "Radio",
                    ListIndex = 1,
                },
                new PickerItem()
                {
                    Text = "Hand-Mic",
                    ListIndex = 2,
                },
                new PickerItem()
                {
                    Text = "Daggr",
                    ListIndex = 3,
                },
                new PickerItem()
                {
                    Text = "SKL",
                    ListIndex = 4,
                }
            ];
        }
    }
}
