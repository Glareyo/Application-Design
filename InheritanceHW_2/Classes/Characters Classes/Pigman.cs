using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Characters_Classes
{
    public class Pigman : Monster, ICanTrade
    {
        public List<IItem> Items => throw new NotImplementedException();

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

        public void InteractWithTrading()
        {
        }

        public void RemoveItem(IItem Item, int Qty)
        {
        }

        public IItem TradeItems(IItem RetrievingItem, IItem TradingItem)
        {
            Items.Add(RetrievingItem);
            Items.Remove(TradingItem);

            return TradingItem;
        }
    }
}
