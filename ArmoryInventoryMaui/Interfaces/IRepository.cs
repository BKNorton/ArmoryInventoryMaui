using ArmoryInventoryMaui.Models;

namespace ArmoryInventoryMaui.Interfaces
{
    public interface IRepository
    {
        public Task AddItemAsync(Item item);
        public Task RemoveItemAsync(Item item);
        public Task<List<Item>> GetItemsAsync();
        public Task<Item> GetItemByIdAsync(string id);
        public Task UpdateItemAsync(Guid Id, Item item);
    }
}
