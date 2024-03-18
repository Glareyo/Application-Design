﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Characters_Classes
{
    public interface ICanTrade : IHasInventory
    {
        public IItem TradeItems(IItem RetrievingItem, IItem TradingItem);
        public void InteractWithTrading();
    }
}
