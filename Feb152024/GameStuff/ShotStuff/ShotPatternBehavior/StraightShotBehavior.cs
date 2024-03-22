using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShotPatternBehavior
{
    public class StraightShotBehavior : IShotPatternBehavior
    {
        public void Act(Shot shot)
        {
                shot.Location.Y -= shot.Speed;
        }
    }
}
