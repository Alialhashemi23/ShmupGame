using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.GameLevels;
using Feb152024.GameStuff.Statics;
using Feb152024.GameStuff.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.GameStates
{
    public class PlayState : IGameState
    {
        Texture2D sky;
        SpriteFont font;
        LevelManager levelManager = new LevelManager();
        CollisionDetector collisionDetector = new CollisionDetector();
        DeathDetector deathDetector = new DeathDetector();
        GameInitializer gameInitializer = new GameInitializer();

        public PlayState()
        {
            sky = Globals.ContentManager.Load<Texture2D>("sky");
            font = Globals.ContentManager.Load<SpriteFont>("Arial");
        }

        public void Update(GameTime gameTime, GameStateManager gameStateManager)
        {
            gameInitializer.Initialize();
            levelManager.Update(gameTime);
            collisionDetector.Update();
            collisionDetector.CheckCollisions();
            if (KeyBoardHelper.IsKeyPressed(Keys.P))
            {
                gameStateManager._gameStates.Push(new PauseState());
            }
            foreach (var shot in Battlefield.Shots)
            {
                shot.Update();
            }
            foreach (var character in Battlefield.Characters)
            {
                character.Update(gameTime);
            }
            if(deathDetector.Update(gameInitializer))
            {
                gameStateManager._gameStates.Push(new GameOverState());
            }
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            var player = Battlefield.Characters.FirstOrDefault(x => x.Type == CharacterTypeEnum.Player);

            _spriteBatch.Draw(sky, new Rectangle(0, 0, 600, 800), Color.White);
            foreach (var shot in Battlefield.Shots)
            {
                _spriteBatch.Draw(shot.Texture, shot.Location, Color.White);
            }
            foreach (var character in Battlefield.Characters)
            {
                _spriteBatch.Draw(character.Texture, character.Location, Color.White);
            }
            if (player != null)
            {
                _spriteBatch.DrawString(font, "Ammo: " + player.Ammo, new Vector2(10, 20), Color.White);
            }
            levelManager.Draw(_spriteBatch);
        }

    }
}