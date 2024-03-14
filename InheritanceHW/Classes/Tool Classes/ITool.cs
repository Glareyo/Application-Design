using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes
{
    public interface ITool : IItem, IBreakable, IMaterial
    {
        /// <summary>
        /// Determines the amount of mining it takes to mine a block or item.
        /// </summary>
        public float MiningStat { get; set; }

        public void UseTool();
    }
}
