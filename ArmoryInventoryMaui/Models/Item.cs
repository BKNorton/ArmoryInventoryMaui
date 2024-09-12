using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventoryMaui.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public bool HasAllComponents { get; set; }
        public bool MissionCapable { get; set; }
        public bool CheckedOut { get; set; }
        public List<string> Defects { get; set; }
        public List<string> MissingComponents { get; set; }
        public Type ItemType { get; set; }

        public enum Type 
        {
            Antenna,
            Radio,
            HandMic,
            Daggr
        }
    }
}
