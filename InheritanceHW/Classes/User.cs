using InheritanceHW.Classes.Characters_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes
{
    public class User : ICreature
    {
        
        
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }


    }
}
