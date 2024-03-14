using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes.Tool_Classes
{
    public class Sword : Tool, IWeapon
    {
        public Sword(IMaterial.MaterialType _type) : base(_type)
        {
            MiningStat = 0;
            Damage = 10;
        }

        public int Damage { get; set; }

        public override void SetModifiers()
        {
            base.SetModifiers();
        }

    }
}
