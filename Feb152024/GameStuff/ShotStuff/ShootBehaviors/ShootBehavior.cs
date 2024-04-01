using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Entities;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff;
using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior;
using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.ShotStuff.ShootBehaviors
{
    internal class ShootBehavior : IShootBehavior
    {
        private GameTimer Timer;
        private Shot Shot;

        public ShootBehavior(int shotCooldown, Shot shot)
        {
            Timer = Globals.TimerSpawner.CreateTimer(shotCooldown);
            Shot = shot;
        }

        public void Act(Character character)
        {
            if (Timer.CheckTimer())
            {
                Battlefield.Shots.Add(Shot.CreateShot(character, ShotTypeEnum.Player));
            };
        
        }

        public bool CheckCondition()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                return true;
            }

            return false;
        }
    }
}
