using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.EnemyBehaviors;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;

namespace Feb152024.GameStuff.Statics
{
    public class EnemyBuilder
    {
        private string Name;
        private int LocX, LocY, Width, Height, HP;
        private CharacterTypeEnum CharacterType;
        private List<IBehavior> behaviors = new List<IBehavior>();
        private List<ISlave> slaves = new List<ISlave>();
        
        private static Dictionary<Enemies, string> enemies = new Dictionary<Enemies, string>()
        {
            { Enemies.Tewi, "tewi" },
            {Enemies.Marisa, "marisa" },
            {Enemies.Reisen, "reisen" }
        };

        public EnemyBuilder()
        {
        }

        public EnemyBuilder AddEnemyData(Enemies name, int x, int y, int width, int height, int hp)
        {
            Name = enemies[name];
            LocX = x;
            LocY = y;
            Width = width;
            Height = height;
            HP = hp;

            return this;
        }

        public EnemyBuilder AddBehavior(IBehavior behavior)
        {
            behaviors.Add(behavior);

            return this;
        }

        public EnemyBuilder AddCharacterType(CharacterTypeEnum characterType)
        {
            CharacterType = characterType;

            return this;
        }

       
        public EnemyBuilder AddShotBehavior(IShotPatternBehavior behavior, int shotCoolDown)
        {
            if (CharacterType == CharacterTypeEnum.Enemy)
            {
                var enemyshootbehavior = new EnemyShootBehavior(shotCoolDown,
                                                                   new Shot(Globals.ContentManager.Load<Texture2D>("Shot"),
                                                                            new Rectangle(0, 0, 4, 4),
                                                                            5,
                                                                            ShotTypeEnum.Enemy,
                                                                            behavior));
                slaves.Add(new Slave(enemyshootbehavior));
            }
            else if(CharacterType == CharacterTypeEnum.Player)
            {

                var playershootbehavior = new ShootBehavior(shotCoolDown,
                                                                   new Shot(Globals.ContentManager.Load<Texture2D>("Shot"),
                                                                            new Rectangle(0, 0, 4, 4),
                                                                            5,
                                                                            ShotTypeEnum.Player,
                                                                            behavior));
                slaves.Add(new Slave(playershootbehavior));
            }

            return this;
        }

        public Character BuildEnemy()
        {
            var character = new Character(
                Globals.ContentManager.Load<Texture2D>(Name),
                new Rectangle(LocX,LocY,Width,Height),
                behaviors,
                slaves,
                CharacterType,
                HP);

            return character;
        }
    }
}