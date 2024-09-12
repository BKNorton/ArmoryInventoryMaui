using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.ViewModels
{
    class ItemViewModel : ObservableObject
    {
        private Item item;

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
        }
    }
}
