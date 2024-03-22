using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior;
using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;

namespace Feb152024.GameStuff.ShotStuff
{
    public class Shot
    {
        public Texture2D Texture;
        public Rectangle Location;
        public int Speed;
        public int Hp = 1;
        public IShotPatternBehavior ShotPatternBehavior;

        public ShotTypeEnum Type { get; }

        public Shot(
                    Texture2D texture2D,
                    Rectangle location,
                    int speed,
                    ShotTypeEnum shotType,
                    IShotPatternBehavior shotPatternBehavior)
        {
            Texture = texture2D;
            Location = location;
            Speed = speed;
            Type = shotType;
            ShotPatternBehavior = shotPatternBehavior;
        }

        public void Update()
        {
            ShotPatternBehavior.Act(this);
        }

        public Shot CreateShot(Character character, ShotTypeEnum shotTypeEnum)
        {
            Shot shot = new Shot(Globals.ContentManager.Load<Texture2D>(Texture.Name),
                     new Rectangle(character.Location.X + character.Location.Width / 2, character.Location.Y, 4, 4),
                     character.Speed,
                     shotTypeEnum,
                     ShotPatternBehavior);

            return shot;
        }
    }
}
