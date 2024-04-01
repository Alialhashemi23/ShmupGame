using Feb152024.GameStuff.ShotStuff.ShootBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Entities
{
    public class Slave : ISlave
    {
        private IShootBehavior _shootBehavior;

        public Slave(IShootBehavior shootBehavior)
        {
            _shootBehavior = shootBehavior;
        }
        public void Shoot(Character character)
        {
            _shootBehavior.Act(character);
        }

        public bool CheckCondition()
        {
            return _shootBehavior.CheckCondition();
        }
    }
}
