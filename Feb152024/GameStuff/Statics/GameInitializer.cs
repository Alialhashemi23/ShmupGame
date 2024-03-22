using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff;
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

                var Reisen = new Character(
                            Globals.ContentManager.Load<Texture2D>("reisen"),
                            new Rectangle(250, 650, 50, 75),
                            new List<IBehavior>
                            {
                                        new MoveRightBehavior(),
                                        new MoveLeftBehavior(),
                                        new MoveDownBehavior(),
                                        new MoveUpBehavior(),
                                        new ShootBehavior(),
                                        new BombBehavior(),
                            },
                            CharacterTypeEnum.Player);
                Battlefield.Characters.Add(Reisen);
                resetGame = false;
            }
        }
    }
}
