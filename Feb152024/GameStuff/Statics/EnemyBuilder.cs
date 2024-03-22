using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.EnemyBehaviors;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff;
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
        private int LocX, LocY;
        private int ShotCoolDown;
        private CharacterTypeEnum CharacterType;
        private List<IBehavior> behaviors = new List<IBehavior>();
        private List<IShotPatternBehavior> shotPatternBehaviors = new List<IShotPatternBehavior>();

        private static Dictionary<Enemies, string> enemies = new Dictionary<Enemies, string>()
        {
            { Enemies.Tewi, "tewi" },
        };

        public EnemyBuilder()
        {
        }

        public EnemyBuilder AddEnemyData(Enemies name, int x, int y)
        {
            Name = enemies[name];
            LocX = x;
            LocY = y;

            return this;
        }

        public EnemyBuilder AddBehavior(IBehavior behavior)
        {
            behaviors.Add(behavior);

            return this;
        }

        public EnemyBuilder AddShotBehavior(IShotPatternBehavior behavior, int shotCoolDown)
        {
            ShotCoolDown = shotCoolDown;
            shotPatternBehaviors.Add(behavior);

            return this;
        }

        public EnemyBuilder AddCharacterType(CharacterTypeEnum characterType)
        {
            CharacterType = characterType;

            return this;
        }

        private void CreateShootBehavior()
        {
            if(CharacterType == CharacterTypeEnum.Enemy)
            {
                var enemyshootbehavior = new EnemyShootBehavior(ShotCoolDown, new Shot(Globals.ContentManager.Load<Texture2D>("Shot"),
                                                    new Rectangle(0, 0, 4, 4),
                                                    5,
                                                    ShotTypeEnum.Enemy,
                                                    shotPatternBehaviors.FirstOrDefault()
                                                    ));
                behaviors.Add(enemyshootbehavior);
            }
            else
            {

            }
        }

        public Character BuildEnemy()
        {
            CreateShootBehavior();
            var character = new Character(
                Globals.ContentManager.Load<Texture2D>(Name),
                new Rectangle(LocX,LocY,50,75),
                behaviors,
                CharacterType);

            return character;
        }
    }
}