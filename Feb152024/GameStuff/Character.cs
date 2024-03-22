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

namespace Feb152024.GameStuff
{
    public class Character
    {
        public Texture2D Texture;
        public Rectangle Location;
        public int Speed = 5;
        public int Hp = 1;
        public int Ammo = 3;
        private List<IBehavior> Behaviors;

        public CharacterTypeEnum Type;

        public Character(
            Texture2D texture2D,
            Rectangle location,
            List<IBehavior> behaviors,
            CharacterTypeEnum characterType)
        {
            Texture = texture2D;
            Location = location;
            Behaviors = behaviors;
            Type = characterType;
        }

        public void Update(GameTime gameTime)
        {
            foreach(var behavior in Behaviors)
            {
                if (behavior.CheckCondition())
                {
                    behavior.Act(this);
                }
            }
        }
    }
}
