using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Tool_Classes
{
    public class Axe : Tool, IWeapon
    {
        public Axe(IMaterial.MaterialType _type) : base(_type)
        {
            Damage = 5;
        }

        public int Damage { get; set; }

        public override void SetModifiers()
        {
            //Override method.
            //Have the tool set it's damage, then get it modified by the modifier.
            base.SetModifiers();
        }
        public override void UseTool()
        {
            base.UseTool();
        }
    }
}
