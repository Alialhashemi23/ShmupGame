using Feb152024.GameStuff.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShootBehaviors
{
    public interface IShootBehavior
    {
        void Act(Character character);

        bool CheckCondition();
    }
}
