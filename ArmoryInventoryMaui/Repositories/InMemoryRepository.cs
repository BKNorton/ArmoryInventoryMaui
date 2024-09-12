using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.Repositories
{
    public class InMemoryRepository : IRepository
    {
        private static List<Item> items;
        public InMemoryRepository()
        {
            items = new List<Item>()
            {
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "111N5",
                    Name = "Radio",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "222NF",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "272N8",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "342N7",
                    Name = "Hand Mic",
                    HasAllComponents = false,
                    MissionCapable = false,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "233N7",
                    Name = "Radio",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "522F4",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "442F4",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "523F5",
                    Name = "Hand Mic",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "372F4",
                    Name = "Radio",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "522N4",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "624N2",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "623N5",
                    Name = "Hand Mic",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "124N8",
                    Name = "Hand Mic",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "367N2",
                    Name = "Radio",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "355N3",
                    Name = "Antenna",
                    HasAllComponents = false,
                    MissionCapable = false,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "557N2",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "363S2",
                    Name = "Hand Mic",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "867N2",
                    Name = "Radio",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "865N3",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "637N2",
                    Name = "Antenna",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = new Guid(),
                    SerialNumber = "467N9",
                    Name = "Hand Mic",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Item.Type.Antenna
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
            };
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

        public Task<Item> GetItemByIdAsync(Guid id)
        {
            var item = items.Where(x => x.Id == id).FirstOrDefault();
            return Task.FromResult(item);
        }

        public Task UpdateItemAsync(Guid Id, Item item)
        {
            if (Id != item.Id) return Task.CompletedTask;

            var itemToUpdate = items.FirstOrDefault(x => x.Id == Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.SerialNumber = item.SerialNumber;
                itemToUpdate.Name = item.Name;
                itemToUpdate.Defects = item.Defects;
                itemToUpdate.HasAllComponents = item.HasAllComponents;
                itemToUpdate.MissingComponents = item.MissingComponents;
            }

            return Task.CompletedTask;
        }
    }
}
