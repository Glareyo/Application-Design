using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes
{
    public interface IHasInventory
    {
        public List<IItem> Items { get; }


        public IItem GetItem(IItem TargetItem);
        public void AddItem(IItem Item, int Qty);
        public void RemoveItem(IItem Item, int Qty);
        public void DiscardInventory();
    }
}
