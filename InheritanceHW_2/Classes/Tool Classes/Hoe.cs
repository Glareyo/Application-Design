using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Tool_Classes
{
    public class Hoe : Tool
    {
        public Hoe(IMaterial.MaterialType _type) : base(_type)
        {
            MiningStat = 1;
        }
    }
}
