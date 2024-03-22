using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.CharacterBehaviors
{
    internal class BombBehavior : IBehavior
    {
        public void Act(Character character)
        {

            if (character.Ammo > 0)
            {
                foreach (var enemy in Battlefield.Characters)
                {
                    if (enemy.Type == CharacterTypeEnum.Enemy)
                    {
                        enemy.Hp = 0;
                    }
                }

                foreach (var shot in Battlefield.Shots)
                {
                    if (shot.Type == ShotTypeEnum.Enemy)
                    {
                        shot.Hp = 0;
                    }
                }
                character.Ammo--;
            }
        }

        public bool CheckCondition()
        {
            if(KeyBoardHelper.IsKeyPressed(Keys.B))
            {
                return true;
            }

            return false;
        }
    }
}
