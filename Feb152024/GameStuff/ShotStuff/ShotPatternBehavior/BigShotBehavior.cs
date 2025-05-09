﻿using Feb152024.GameStuff.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShotPatternBehavior
{
    public class BigShotBehavior : IShotPatternBehavior
    {
        private GameTimer timer;
        private int AdjustableTimer;
        public BigShotBehavior(int adjustableTimer)
        {
            AdjustableTimer = adjustableTimer;
            timer = Globals.TimerSpawner.CreateTimer(adjustableTimer);
        }
        public void Act(Shot shot)
        {

            shot.Location.Y -= 5;

            if (timer.CheckTimer())
            {
                shot.Location.Width += 5;
                shot.Location.Height += 5;
            }
        }

        public IShotPatternBehavior ReturnSelf()
        {
            return new BigShotBehavior(AdjustableTimer);
        }
    }
}
