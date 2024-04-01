using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Entities;
using Feb152024.GameStuff.ShotStuff;
using Feb152024.GameStuff.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.EnemyBehaviors
{
    public class BossMoveBehavior : IBehavior
    {

        private GameTimer timer;
        private int Xspeed = 1;

        public BossMoveBehavior(int adjustableTimer)
        {
            timer = Globals.TimerSpawner.CreateTimer(adjustableTimer);
        }
        public void Act(Character character)
        {
            character.Location.X += Xspeed;

            if (timer.CheckTimer())
            {
                Xspeed *= -1;
            }
        }

        public bool CheckCondition()
        {
            return true;
        }
    }
}
