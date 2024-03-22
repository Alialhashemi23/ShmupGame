using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Statics
{
    public static class KeyBoardHelper
    {
        public static KeyboardState CurrentKeyboardState;
        public static KeyboardState LastKeyboardstate;
        public static bool IsKeyPressed(Keys keys)
        {
            if (CurrentKeyboardState.IsKeyUp(keys) && LastKeyboardstate.IsKeyDown(keys))
            {
                return true;
            }
            return false;
        }

        public static void Update()
        {
            LastKeyboardstate = CurrentKeyboardState;
            CurrentKeyboardState = Keyboard.GetState();
        }
    }
}
