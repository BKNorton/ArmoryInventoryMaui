using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.Models.Pickers
{
    public class TrueOrFalsePicker : ObservableObject
    {
        public ObservableCollection<PickerItem> TrueOrFalseCollection;

        public TrueOrFalsePicker()
        {
            TrueOrFalseCollection =
            [
                new PickerItem()
                {
                    Text = "True",
                    ListIndex = 0,
                },
                new PickerItem()
                {
                    Text = "False",
                    ListIndex = 1,
                }
            ];
        }
    }
}
