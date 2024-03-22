using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShotPatternBehavior
{
    public class ZigZagShotBehavior : IShotPatternBehavior
    {
        private GameTimer timer;
        private int Xspeed = 5;
        public ZigZagShotBehavior(int adjustableTimer)
        {
            timer = Globals.TimerSpawner.CreateTimer(adjustableTimer);
        }
        public void Act(Shot shot)
        {

            shot.Location.Y -= 5;
            shot.Location.X += Xspeed;

            if(timer.CheckTimer()) 
            {
                Xspeed *= -1;
            }
        }
    }
}
