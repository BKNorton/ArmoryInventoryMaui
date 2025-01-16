using Microsoft.VisualBasic;

namespace ArmoryInventoryMaui.Models
{
    public class Checkout
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public DateAndTime DateCheckedOut { get; set; }
        public DateAndTime DateCheckedIn { get; set; }
        public string CheckedOutTo { get; set; }
        public List<string> DefectsBefore { get; set; }
        public List<string> DefectsAfter { get; set; }

    }
}
