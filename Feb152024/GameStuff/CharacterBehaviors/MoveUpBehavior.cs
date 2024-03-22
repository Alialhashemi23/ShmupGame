using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.CharacterBehaviors
{
    internal class MoveUpBehavior : IBehavior
    {
        public void Act(Character character)
        {
            character.Location.Y -= character.Speed;
        }

        public bool CheckCondition()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                return true;
            }

            return false;
        }
    }
}
