using ArmoryInventoryMaui.Interfaces;
using ArmoryInventoryMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = ArmoryInventoryMaui.Models.Type;

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
                    Id = Guid.NewGuid(),
                    SerialNumber = "111N5",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Radio
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "222NF",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "272N8",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "342N7",
                    HasAllComponents = false,
                    MissionCapable = false,
                    CheckedOut = false,
                    ItemType = Type.HandMic
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "233N7",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Type.Radio
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "522F4",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "442F4",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "523F5",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.HandMic
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "372F4",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Radio
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "522N4",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "624N2",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "623N5",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Type.HandMic
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "124N8",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Type.HandMic
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "367N2",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = true,
                    ItemType = Type.Radio
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "355N3",
                    HasAllComponents = false,
                    MissionCapable = false,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "557N2",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "363S2",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.HandMic
                    //Defects = {"Mic key does not work"},
                    //MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "867N2",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Radio
                    //Defects = {"Back connectors bent", "Front Light does'nt work" },
                    //MissingComponents = new List<string>(),
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "865N3",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 2 stakes", "Missing one blue pole"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "637N2",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
                    //Defects = new List<string>(),
                    //MissingComponents = {"Missing 1 stake", "Missing 2 blue pole", "Missing Hammer"},
                },
                new Item()
                {
                    Id = Guid.NewGuid(),
                    SerialNumber = "467N9",
                    HasAllComponents = true,
                    MissionCapable = true,
                    CheckedOut = false,
                    ItemType = Type.Antenna
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

        public Task<Item> GetItemByIdAsync(string id)
        {
            var item = items.Where(x => x.Id.ToString() == id).FirstOrDefault();
            if (item != null)
            {
                return Task.FromResult(item);
            }
            return (Task<Item>)Task.CompletedTask;
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
            }

            return Task.CompletedTask;
        }
    }
}
