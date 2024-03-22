using Feb152024.GameStuff.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShotPatternBehavior
{
    public class FastShotBehavior : IShotPatternBehavior
    {
        private GameTimer timer;

        public FastShotBehavior()
        {
            timer = Globals.TimerSpawner.CreateTimer(100);
        }
        public void Act(Shot shot)
        {
            shot.Location.Y -= shot.Speed;

            if (timer.CheckTimer())
            {
                shot.Speed *= 2;
            }
        }
    }
}
