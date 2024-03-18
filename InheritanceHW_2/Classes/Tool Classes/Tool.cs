using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InheritanceHW_2.Classes.IMaterial;

namespace InheritanceHW_2.Classes
{
    public class Tool : ITool
    {
        /// <summary>
        /// When making the tool, the tool, regardless, must be given a material type and have it's modifiers set
        /// </summary>
        /// <param name="_type">The Material type of the tool</param>
        public Tool(MaterialType _type)
        {

            type = _type;
            SetModifiers();
        }

        public string Name { get; set; }
        public int Duration { get; set; }
        public float MiningStat { get; set; }
        public string MaterialType { get; set; }
        public int Modifier { get; set; }
        public MaterialType type { get; set; }

        public virtual void Break()
        {
            //Destroy Tool when duration = 0
        }

        public virtual void SetModifiers()
        {
            //Set the modifers of the tool based on material type
        }

        public virtual void UseTool()
        {
            //Use the tool when mining. After animation, then call check
            //To see if duration <= 0, and if so, call Break();
        }
    }
}
