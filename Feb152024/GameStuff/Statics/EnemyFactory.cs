//using Feb152024.GameStuff.CharacterBehaviors;
//using Feb152024.GameStuff.Enums;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Feb152024.GameStuff.Statics
//{
//    public static class EnemyFactory
//    {
//        public static Character CreateCharacter(Enemies name, int x, int y, CharacterTypeEnum characterType, params IBehavior[] behaviors)
//        {
//            return new Character(
//                Globals.ContentManager.Load<Texture2D>(enemies[name]),
//                new Rectangle(x, y, 50, 75),
//                behaviors.ToList(),
//                characterType);
//        }
//    }
//}
