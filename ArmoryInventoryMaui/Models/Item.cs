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

    public enum Type 
    {
        None,
        Antenna,
        Radio,
        HandMic,
        DAGGR,
        SKL
    }

    public enum TrueOrFalse
    {
        None,
        True,
        False
    }
}
