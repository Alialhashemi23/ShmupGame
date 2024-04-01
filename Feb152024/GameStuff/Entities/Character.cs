using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;

namespace Feb152024.GameStuff.Entities
{
    public class Character
    {
        public Texture2D Texture;
        public Rectangle Location;
        public int Speed = 5;
        public int Hp;
        public int Ammo = 3;
        private List<IBehavior> Behaviors;
        private List<ISlave> Slaves;
        public CharacterTypeEnum Type;

        public Character(
            Texture2D texture2D,
            Rectangle location,
            List<IBehavior> behaviors,
            List<ISlave> slaves,
            CharacterTypeEnum characterType,
            int hp)
        {
            Texture = texture2D;
            Location = location;
            Behaviors = behaviors;
            Slaves = slaves;
            Type = characterType;
            Hp = hp;
        }

        public void Update(GameTime gameTime)
        {
            foreach (var behavior in Behaviors)
            {
                if (behavior.CheckCondition())
                {
                    behavior.Act(this);
                }
            }
            foreach (var slave in Slaves)
            {
                if (slave.CheckCondition())
                {
                    slave.Shoot(this);
                }
            }
        }
    }
}
