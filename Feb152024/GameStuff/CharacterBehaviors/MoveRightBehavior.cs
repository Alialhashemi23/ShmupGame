using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.CharacterBehaviors
{
    internal class MoveRightBehavior : IBehavior
    {
        public void Act(Character character)
        {
            character.Location.X += character.Speed;
        }

        public bool CheckCondition()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                return true;
            }

            return false;
        }
    }
}
