using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.ShotStuff;
using Feb152024.GameStuff.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.Systems
{
    public class CollisionDetector
    {
        public void Update()
        {
            foreach (var character in Battlefield.Characters)
            {
                foreach (var shot in Battlefield.Shots)
                {
                    if (character.Location.Intersects(shot.Location) && character.Type == CharacterTypeEnum.Player && shot.Type == ShotTypeEnum.Enemy)
                    {
                        character.Hp -= 1;
                        shot.Hp -= 1;
                    }
                    else if (character.Location.Intersects(shot.Location) && character.Type == CharacterTypeEnum.Enemy && shot.Type == ShotTypeEnum.Player)
                    {
                        character.Hp -= 1;
                        shot.Hp -= 1;
                    }
                }
            }

            foreach (var shot in Battlefield.Shots)
            {
                if(shot.Location.Y >= 800)
                {
                    shot.Hp -= 1;
                }
            }

            foreach (var character in Battlefield.Characters)
            {
                if (character.Location.Y >= 800 && character.Type == CharacterTypeEnum.Enemy)
                {
                    character.Hp -= 1;
                }
            }

            Battlefield.Characters.RemoveAll(character => character.Hp <= 0 && character.Type == CharacterTypeEnum.Enemy);
            Battlefield.Shots.RemoveAll(shot => shot.Hp <= 0);
        }

        public void CheckCollisions()
        {
            var player = Battlefield.Characters.FirstOrDefault(x => x.Type == CharacterTypeEnum.Player);
            if (player.Type == CharacterTypeEnum.Player)
            {
                // Check if the character is going out of bounds
                if (player.Location.X < 0)
                {
                    player.Location.X = 0; // Prevent moving left beyond the boundary
                }
                else if (player.Location.X > 600 - player.Location.Width)
                {
                    player.Location.X = 600 - player.Location.Width; // Prevent moving right beyond the boundary
                }

                if (player.Location.Y < 0)
                {
                    player.Location.Y = 0; // Prevent moving up beyond the boundary
                }
                else if (player.Location.Y > 800 - player.Location.Height)
                {
                    player.Location.Y = 800 - player.Location.Height; // Prevent moving down beyond the boundary
                }
            }
        }
    }
}
