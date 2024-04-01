using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Entities;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff;
using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior;
using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShootBehaviors
{
    internal class EnemyShootBehavior : IShootBehavior
    {
        private GameTimer Timer;
        private Shot Shot;

        public EnemyShootBehavior(int shootCoolDown, Shot shot)
        {
            Timer = Globals.TimerSpawner.CreateTimer(shootCoolDown);
            Shot = shot;
        }
        public void Act(Character character)
        {
            if (Timer.CheckTimer())
            {
                Battlefield.Shots.Add(Shot.CreateShot(character, ShotTypeEnum.Enemy));
            };
        }

        public bool CheckCondition()
        {
            return true;
        }
    }
}
