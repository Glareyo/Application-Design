using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceHW_2.Classes;

namespace InheritanceHW_2.Classes.Characters_Classes
{
    public class Trader : ICreature ,ICanTrade
    {
        public List<IItem> Items { get; set; }

        public string Name { get; set;}
        public int Health { get; set; }
        public int Level { get; set; }
        public float Speed { get; set; }

        public void AddItem(IItem Item, int Qty)
        {
            Items.Add(Item);
        }

        public virtual void Dead()
        {
        }

        public void DiscardInventory()
        {
            Items.Clear();
        }

        public IItem GetItem(IItem TargetItem)
        {
            IItem retrievedItem = null;

            foreach (IItem item in Items)
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

        public void InteractWithTrading()
        {
            //Open trading Menu
        }

        public void RemoveItem(IItem Item, int Qty)
        {
            Items.Remove(Item);
        }

        public IItem TradeItems(IItem RetrievingItem, IItem TradingItem)
        {
            Items.Add(RetrievingItem);
            Items.Remove(TradingItem);

            return TradingItem;
        }
    }
}
