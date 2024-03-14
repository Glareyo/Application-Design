using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes
{
    public interface ILootable : IItem, IBreakable
    {
        List<IItem> Items { get; set; }

        int MaxNumOfItems { get; set; }
        int MinNumOfItems { get; set; }


        public void DropItems();
    }
}
