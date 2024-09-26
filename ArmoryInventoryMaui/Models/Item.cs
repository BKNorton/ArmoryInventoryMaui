using ArmoryInventoryMaui.Models.Pickers;

namespace ArmoryInventoryMaui.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public PickerItem ItemType { get; set; }
        public PickerItem HasAllComponents { get; set; }
        public PickerItem MissionCapable { get; set; }
        public PickerItem CheckedOut { get; set; }
        public List<string>? Defects { get; set; }
        public List<string>? MissingComponents { get; set; }
    }
}
