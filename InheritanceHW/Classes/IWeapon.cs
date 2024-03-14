using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes
{
    public interface IWeapon : IItem, IBreakable
    {
        public int Damage {  get; set; }
    }
}
