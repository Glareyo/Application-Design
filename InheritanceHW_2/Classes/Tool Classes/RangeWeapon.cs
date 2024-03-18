using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Tool_Classes
{
    public class RangeWeapon : IRangeWeapon
    {
        public IItem ammoType { get; set; }
        public int Range { get; set; }
        public int ChargeUp { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        public void Break()
        {

        }

        public void Shoot()
        {

        }
    }
}
