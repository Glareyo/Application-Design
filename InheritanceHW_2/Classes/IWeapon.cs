using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes
{
    public interface IWeapon : IItem, IBreakable
    {
        public int Damage {  get; set; }
    }
}
