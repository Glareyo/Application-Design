using InheritanceHW_2.Classes.Characters_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes
{
    public class User : ICreature, IHasInventory
    {
        public UserController Controller { get; set; }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public List<IItem> Items { get; }
        public float Speed { get; set; }

        public void AddItem(IItem Item, int Qty)
        {
            Items.Add(Item);
        }

        public void Dead()
        {
            //Drop inventory
        }

        public void DiscardInventory()
        {
            Items.Clear();
        }

        public IItem GetItem(IItem TargetItem)
        {
            IItem retrievedItem = null;

            foreach(IItem item in Items)
            {
                if (item == TargetItem)
                {
                    retrievedItem = item;
                }
            }

            if (retrievedItem != null)
            {
                return retrievedItem;
            }
            else
            {
                return null;
            }
        }

        public void RemoveItem(IItem Item, int Qty)
        {
            Items.Remove(Item);
        }
    }
}
