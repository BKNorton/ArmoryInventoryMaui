using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.ViewModels
{
    public partial class InventoryMainViewModel : ObservableObject
    {
        public ObservableCollection<Item> Items { get; set; }
        private IRepository repository;

        public InventoryMainViewModel(IRepository repository)
        {
            this.Items = new ObservableCollection<Item>();
            this.repository = repository;
        }

        public async Task LoadContactsAsync()
        {
            this.Items.Clear();

            var items = await repository.GetItemsAsync();
            if (items != null && items.Count > 0)
            {
                foreach (var item in items)
                {
                    this.Items.Add(item);
                }
            }
        }

        [RelayCommand]
        public async Task GoToAddItemPageAsync()
        {
            await Shell.Current.GoToAsync(nameof(AddItemPage));
        }
    }  
}
