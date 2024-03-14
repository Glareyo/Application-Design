﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW.Classes.Characters_Classes
{
    public interface ICreature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
    }
}
