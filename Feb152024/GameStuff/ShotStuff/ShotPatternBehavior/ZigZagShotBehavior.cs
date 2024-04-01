using Feb152024.GameStuff.Enums;
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
        private int AdjustableTimer;
        private int Xspeed = 5;
        private int Yspeed = 5;
        private bool South;
        public ZigZagShotBehavior(int adjustableTimer, bool south)
        {
            AdjustableTimer = adjustableTimer;
            South = south;
            timer = Globals.TimerSpawner.CreateTimer(adjustableTimer);
            if(south)
            {
                Yspeed *= -1;
            }
        }
        public void Act(Shot shot)
        {

            shot.Location.Y -= Yspeed;
            shot.Location.X += Xspeed;

            if(timer.CheckTimer()) 
            {
                Xspeed *= -1;
            }
        }

        public IShotPatternBehavior ReturnSelf()
        {
            return new ZigZagShotBehavior(AdjustableTimer, South);
        }
    }
}
