using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Enviroment
{
    public class HazardBlock : ILootable, IPlaceable
    {
        public List<IItem> DroppedItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxNumOfItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MinNumOfItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Damage;

        public void DropItems()
        {
            throw new NotImplementedException();
        }

        public void Place()
        {
            throw new NotImplementedException();
        }

        
    }
}
