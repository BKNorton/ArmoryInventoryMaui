using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

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
