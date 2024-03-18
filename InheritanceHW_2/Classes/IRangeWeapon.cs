using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes
{
    public interface IRangeWeapon : IWeapon
    {
        public enum WeaponState { Idle, Charged }
        public IItem ammoType { get; set; }
        public int Range { get; set; }
        public int ChargeUp { get; set; }
        public void Shoot();
    }
}
