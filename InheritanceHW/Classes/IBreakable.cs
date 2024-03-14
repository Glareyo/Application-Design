using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes
{
    public interface IBreakable
    {
        public int Duration { get; set; }


        public void Break();
    }
}
