using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Enviroment
{
    public class Chest : InteractableBlock, IHasInventory
    {
        public List<IItem> Items { get; }

        public void AddItem(IItem Item, int Qty)
        {
        }

        public void DiscardInventory()
        {
        }

        public IItem GetItem(IItem TargetItem)
        {
            return TargetItem;
        }

        public void RemoveItem(IItem Item, int Qty)
        {
        }
    }
}
