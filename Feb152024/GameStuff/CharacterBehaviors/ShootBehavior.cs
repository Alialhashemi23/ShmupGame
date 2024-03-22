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

namespace Feb152024.GameStuff.CharacterBehaviors
{
    internal class ShootBehavior : IBehavior
    {
        private GameTimer timer;

        public ShootBehavior()
        {
            timer = Globals.TimerSpawner.CreateTimer(100);
        }

        public void Act(Character character)
        {
            if (timer.CheckTimer())
            { 
                Shot shot = new Shot(Globals.ContentManager.Load<Texture2D>("Shot"),
                                     new Rectangle(character.Location.X + character.Location.Width / 2, character.Location.Y, 4, 4),
                                     character.Speed,
                                     ShotTypeEnum.Player,
                                     new FastShotBehavior());
                Battlefield.Shots.Add(shot);
            }
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
