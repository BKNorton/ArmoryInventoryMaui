﻿using ArmoryInventoryMaui.Models.Enums;
using Type = ArmoryInventoryMaui.Models.Enums.Type;

namespace ArmoryInventoryMaui.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string? SerialNumber { get; set; }
        public Type ItemType { get; set; }
        public TrueOrFalse HasAllComponents { get; set; }
        public TrueOrFalse MissionCapable { get; set; }
        public TrueOrFalse CheckedOut { get; set; }
        public List<string>? Defects { get; set; }
        public List<string>? MissingComponents { get; set; }
        public string? ItemBackgroundColor { get; set; }
    }
}
