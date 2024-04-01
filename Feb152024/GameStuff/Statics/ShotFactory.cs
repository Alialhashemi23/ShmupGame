//using Feb152024.GameStuff.Entities;
//using Feb152024.GameStuff.Enums;
//using Feb152024.GameStuff.ShotStuff.ShotPatternBehavior;
//using Feb152024.GameStuff.ShotStuff;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Feb152024.GameStuff.Statics
//{
//    public class ShotFactory
//    {
//        public void CreateShot(ShotPatternEnum shotPattern, Character character, ShotTypeEnum shotType)
//        {
//            Shot shot = new Shot(Globals.ContentManager.Load<Texture2D>(Texture.Name),
//            new Rectangle(character.Location.X + character.Location.Width / 2, character.Location.Y, 4, 4),
//            character.Speed,
//                     shotTypeEnum,
//                     ShotPatternBehavior);
//        }

//        private IShotPatternBehavior DetermineShotPattern(ShotPatternEnum shotPattern)
//        {
//            switch(shotPattern)
//            {
//                case ShotPatternEnum.Straight:
//                    return new StraightShotBehavior();
//                case ShotPatternEnum.Big:
//                    return new BigShotBehavior(200);
//                case ShotPatternEnum.Zigzag:
//                    return new ZigZagShotBehavior();
//                case ShotPatternEnum.Fast:
//                    return new FastShotBehavior(200);
//            }
//        }
//    }
//}
