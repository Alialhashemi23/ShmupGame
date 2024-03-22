using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Statics
{
    public class GameTimer
    {
        private float Timer = 0;
        private float Target;
        public bool Dispose = false;


        public GameTimer(float target)
        {
            Target = target;
        }

        public void Update(GameTime gameTime) 
        {
            Timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public bool CheckTimer(bool dispose = false)
        {
            if(Timer >= Target)
            {
                Dispose = dispose;
                Timer = 0;
                return true;
            }
            return false;
        }
    }
}
