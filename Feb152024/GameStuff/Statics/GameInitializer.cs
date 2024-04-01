using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Entities;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff;
using Feb152024.GameStuff.ShotStuff.ShootBehaviors;
using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Statics
{
    public class GameInitializer
    {
        public bool resetGame = true;
       
        public void Initialize()
        {
            if (resetGame)
            {


                Battlefield.Characters = new List<Character>();
                Battlefield.Shots = new List<Shot>();

                var Reisen = new EnemyBuilder()
                                               .AddEnemyData(Enemies.Reisen, 250, 650, 50, 75, 1)
                                               .AddCharacterType(CharacterTypeEnum.Player)
                                               .AddBehavior(new MoveRightBehavior())
                                               .AddBehavior(new MoveLeftBehavior())
                                               .AddBehavior(new MoveDownBehavior())
                                               .AddBehavior(new MoveUpBehavior())
                                               .AddShotBehavior(new ZigZagShotBehavior(200, false), 100)
                                               .AddShotBehavior(new BigShotBehavior(500), 300)
                                               .BuildEnemy();
                            
                Battlefield.Characters.Add(Reisen);
                resetGame = false;
            }
        }
    }
}
