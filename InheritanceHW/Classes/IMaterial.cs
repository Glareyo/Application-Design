using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes
{
    public interface IMaterial
    {
        /// <summary>
        /// The material of the tool, such as Diamonds, Gold, Stone, etc...
        /// </summary>
        public enum MaterialType { Wood, Stone,Iron,Gold,Diamond,Netherite};
        public MaterialType type { get; set; }
        public int Modifier { get;set; }
        public void SetModifiers();
    }
}
