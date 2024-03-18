using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes
{
    public interface ILootable : IItem
    {
        List<IItem> DroppedItems { get; set; }
        int MaxNumOfItems { get; set; }
        int MinNumOfItems { get; set; }


        public void DropItems();
    }
}
