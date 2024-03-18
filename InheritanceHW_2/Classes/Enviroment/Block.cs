using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Enviroment
{
    public class Block : ILootable, IBreakable, IPlaceable
    {
        public List<IItem> DroppedItems { get; set; }
        public int MaxNumOfItems { get; set; }
        public int MinNumOfItems { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        public void Break()
        {
        }

        public void DropItems()
        {
        }

        public void Place()
        {
        }
    }
}
