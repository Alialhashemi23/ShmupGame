using Feb152024.GameStuff.Statics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.GameStates
{
    internal class TitleScreenState : IGameState
    {
        Texture2D background;


        public TitleScreenState()
        {
            background = Globals.ContentManager.Load<Texture2D>("TitleScreen");

        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(background, new Rectangle(0, 0, 600, 800), Color.White);
        }

        public void Update(GameTime gameTime, GameStateManager gameStateManager)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                gameStateManager._gameStates.Push(new PlayState());
            }
        }
    }
}
