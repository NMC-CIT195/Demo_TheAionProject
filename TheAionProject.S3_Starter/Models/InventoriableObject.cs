using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public class InventoriableObject : GameObject
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override int SpaceTimeLocationId { get; set; }
        public bool IsInInventory { get; set; }
        public bool HasValue { get; set; }
        public int Value { get; set; }
    }
}
