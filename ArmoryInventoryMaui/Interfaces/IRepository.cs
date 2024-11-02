using ArmoryInventoryMaui.Models;
using Type = ArmoryInventoryMaui.Models.Type;

namespace ArmoryInventoryMaui.Interfaces
{
    public interface IRepository
    {
        public Task AddItemAsync(Item item);
        public Task RemoveItemAsync(Item item);
        public Task<List<Item>> GetItemsAsync();
        public Task<Item> GetItemByIdAsync(string id);
        public Task<List<Item>> GetItemsBySearchAsync(string filterText);
        public Task<List<Item>> GetItemsByFiltersAsync(int typeIndex, int hasCompIndex, int missCapIndex, int checkOutIndex);
        public Task UpdateItemAsync(Guid Id, Item item);
    }
}
