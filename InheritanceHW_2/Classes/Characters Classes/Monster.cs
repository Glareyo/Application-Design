using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW_2.Classes.Characters_Classes
{
    public class Monster : ICreature, ILootable
    {
        public enum MonsterState { Idle, Attacking }
        public MonsterState State;

        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public float Speed { get; set; }


        public List<IItem> DroppedItems { get; set; }
        public int MaxNumOfItems { get; set; }
        public int MinNumOfItems { get; set; }

        List<ICreature> TargetCreatures;
        public int Damage { get; set; }

        public virtual void Move()
        {

        }
        public virtual void Wander()
        {

        }
        public virtual void TargetCreature(ICreature creature)
        {

        }


        public virtual void Dead()
        {
            DropItems();
        }

        public void DropItems()
        {
            foreach(IItem item in DroppedItems)
            {
                //Drop Items
            }
        }
    }
}
