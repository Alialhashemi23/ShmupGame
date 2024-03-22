using Feb152024.GameStuff.CharacterBehaviors;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.EnemyBehaviors
{
    internal class EnemyDownBehavior : IBehavior
    {
        public void Act(Character character)
        {
            character.Location.Y += 2;
        }

        public bool CheckCondition()
        {
            return true;
        }
    }
}
 