using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.EnemyBehaviors;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior;
using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior.Enemies;
using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Systems
{
    public class EnemySpawner
    {
        private GameTimer timer;
        private Random Rand = new Random();

        public EnemySpawner()
        {
            timer = Globals.TimerSpawner.CreateTimer(2000);
        }

        public void Update(GameTime gameTime)
        { 

            if(timer.CheckTimer())
            {
                EnemyBuilder EnemyBuilder = new EnemyBuilder();
                var characters = EnemyBuilder.AddEnemyData(Enemies.Tewi, Rand.Next(0,600), 0)
                                             .AddCharacterType(CharacterTypeEnum.Enemy)
                                             .AddBehavior(new EnemyDownBehavior())
                                             .AddShotBehavior(new EnemyStraightShotBehavior(), 1000)
                                             .BuildEnemy();

                //var characters = EnemyBuilder.CreateCharacter(
                //    Enemies.Tewi,
                //    Rand.Next(0,600),
                //    0,
                //    CharacterTypeEnum.Enemy,
                //    new EnemyDownBehavior(),
                //    new EnemyShootBehavior(1000));
            
                Battlefield.Characters.Add(characters);
            }
        }
    }
}
