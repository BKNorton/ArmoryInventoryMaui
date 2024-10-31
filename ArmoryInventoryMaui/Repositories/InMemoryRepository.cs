using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
namespace ArmoryInventoryMaui.Repositories
{
    public class InMemoryRepository : IRepository
    {
        private List<Item> items;
        public InMemoryRepository()
        {
            items =
            [
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "111N5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Radio,
                    Defects = new List<string>() {"Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "222NF",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 2 stakes", "Missing one blue pole"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "272N8",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "342N7",
                    HasAllComponents = TrueOrFalse.False,
                    MissionCapable = TrueOrFalse.False,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.HandMic,
                    Defects = new List<string>() {"Mic key does not work"},
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "233N7",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Models.Type.Radio,
                    Defects = new List<string>() {"Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "522F4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 2 stakes", "Missing one blue pole"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "442F4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "523F5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.HandMic,
                    Defects = new List<string>() {"Mic key does not work"},
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "372F4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Models.Type.Radio,
                    Defects = new List<string>() {"Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "522N4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 2 stakes", "Missing one blue pole"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "624N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "623N5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Models.Type.HandMic,
                    Defects = new List<string>() {"Mic key does not work"},
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "124N8",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Models.Type.HandMic,
                    Defects = new List<string>() {"Mic key does not work"},
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "367N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Models.Type.Radio,
                    Defects = new List<string>() {"Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "355N3",
                    HasAllComponents = TrueOrFalse.False,
                    MissionCapable = TrueOrFalse.False,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 2 stakes", "Missing one blue pole"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "557N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "363S2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.HandMic,
                    Defects = new List<string>() {"Mic key does not work"},
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "867N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Radio,
                    Defects = new List<string>() {"Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "865N3",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 2 stakes", "Missing one blue pole"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "637N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.SKL,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                    ItemBackgroundColor = "White",
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "467N9",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Type.HandMic,
                    Defects = new List<string>() {"Mic key does not work"},
                    MissingComponents = new List<string>(),
                    ItemBackgroundColor = "White",
                },
            ];
        }

        public Task AddItemAsync(Item item)
        {
            items.Add(item);
            return Task.CompletedTask;
        }

        public Task RemoveItemAsync(Item item)
        {
            items.Remove(item);
            return Task.CompletedTask;
        }

        public Task<List<Item>> GetItemsAsync()
        {
            return Task.FromResult(items);
        }

        public Task<Item> GetItemByIdAsync(string id)
        {
            var item = items.Where(x => x.Id.ToString() == id).FirstOrDefault();
            if (item != null)
            {
                return Task.FromResult(item);
            }
            item = new Item();
            return Task.FromResult(item);
        }

        public Task UpdateItemAsync(Guid Id, Item item)
        {
            if (Id != item.Id) return Task.CompletedTask;

            var itemToUpdate = items.FirstOrDefault(x => x.Id == Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.SerialNumber = item.SerialNumber;
                itemToUpdate.ItemType = item.ItemType;
                itemToUpdate.Defects = item.Defects;
                itemToUpdate.HasAllComponents = item.HasAllComponents;
                itemToUpdate.MissingComponents = item.MissingComponents;
                itemToUpdate.CheckedOut = item.CheckedOut;
            }

            return Task.CompletedTask;
        }
    }
}
