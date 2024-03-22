using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Systems
{
    public class DeathDetector
    {

        public bool Update(GameInitializer gameInitializer)
        {
            var character = Battlefield.Characters.Where(x => x.Type == CharacterTypeEnum.Player)?.FirstOrDefault();

            if (character?.Hp <= 0)
            {
                gameInitializer.resetGame = true;
                return true;
            }
            return false;
        }
    }
}
