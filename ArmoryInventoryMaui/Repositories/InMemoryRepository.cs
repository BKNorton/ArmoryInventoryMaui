using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using ArmoryInventoryMaui.Models.Enums;
using Type = ArmoryInventoryMaui.Models.Enums.Type;
namespace ArmoryInventoryMaui.Repositories
{
    public class InMemoryRepository : IRepository
    {
        private List<Item> items;
        public InMemoryRepository()
        {
            //Seed data
            items =
            [
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "111N5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Models.Enums.Type.Radio,
                    Defects = new List<string>() {"Back connectors bent", "Front Light doesn't work" },
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.HandMic,
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
                    ItemType = Models.Enums.Type.Radio,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.HandMic,
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
                    ItemType = Models.Enums.Type.Radio,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.HandMic,
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
                    ItemType = Models.Enums.Type.HandMic,
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
                    ItemType = Models.Enums.Type.Radio,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.HandMic,
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
                    ItemType = Models.Enums.Type.Radio,
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
                    ItemType = Models.Enums.Type.Antenna,
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
                    ItemType = Models.Enums.Type.SKL,
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
                    ItemType = Models.Enums.Type.HandMic,
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


        //Searches for items by Serial Number with user input
        public Task<List<Item>> GetItemsBySearchAsync(string filterText)
        {
            if (string.IsNullOrWhiteSpace(filterText))
            {
                return Task.FromResult(this.items);
            }

            var items = this.items.Where( x => !string.IsNullOrWhiteSpace(x.SerialNumber)
                && x.SerialNumber.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (items is null || items.Count <= 0)
            {
                return Task.FromResult(new List<Item>());
            }

            return Task.FromResult(items);
        }


        //Searches for items using filter selections by user
        //Search has a top-down aproach, will search checking every filter selection and will be called every time a filter selection is made
        public Task<List<Item>> GetItemsByFiltersAsync(int type, int hasComp, int missCap, int checkOut)
        {
            if (type != 0)
            {
                var items = this.items.Where(x => (int)x.ItemType == type).ToList();
                if(hasComp != 0) items = items.Where(x => (int)x.HasAllComponents == hasComp).ToList();
                if (missCap != 0) items = items.Where(x => (int)x.MissionCapable == missCap).ToList();
                if (checkOut != 0) items = items.Where(x => (int)x.CheckedOut == checkOut).ToList();
                return Task.FromResult(items);
            }
            else if (hasComp != 0)
            {
                var items = this.items.Where(x => (int)x.HasAllComponents == hasComp).ToList();
                if (missCap != 0) items = items.Where(x => (int)x.MissionCapable == missCap).ToList();
                if (checkOut != 0) items = items.Where(x => (int)x.CheckedOut == checkOut).ToList();
                return Task.FromResult(items);
            }
            else if (missCap != 0)
            {
                var items = this.items.Where(x => (int)x.MissionCapable == missCap).ToList();
                if (checkOut != 0) items = items.Where(x => (int)x.CheckedOut == checkOut).ToList();
                return Task.FromResult(items);
            }
            else if (checkOut != 0)
            {
                var items = this.items.Where(x => (int)x.CheckedOut == checkOut).ToList();
                return Task.FromResult(items);
            }
            else return Task.FromResult(this.items); 
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
