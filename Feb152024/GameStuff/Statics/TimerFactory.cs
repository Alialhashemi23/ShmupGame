using Microsoft.Xna.Framework;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Feb152024.GameStuff.Statics
{
    public class TimerFactory
    {
        private List<GameTimer> gameTimers = new List<GameTimer>(); 

        public TimerFactory()
        {
        }
        
        public GameTimer CreateTimer(float target)
        {
            GameTimer newTimer = new GameTimer(target);

            gameTimers.Add(newTimer);

            return newTimer;
        }

        public void Update(GameTime gameTime)
        {
            foreach (GameTimer timer in gameTimers)
            {
                timer.Update(gameTime);
            }
        }

        public void Dispose()
        {
            gameTimers.RemoveAll(x => x.Dispose == true);
        }
    }
}
