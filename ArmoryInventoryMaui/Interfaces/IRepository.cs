using ArmoryInventoryMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.Interfaces
{
    public interface IRepository
    {
        public Task AddItemAsync(Item item);
        public Task RemoveItemAsync(Item item);
        public Task<List<Item>> GetItemsAsync();
        public Task<Item> GetItemByIdAsync(Guid id);
        public Task UpdateItemAsync(Guid Id, Item item);
    }
}
