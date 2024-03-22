using Feb152024.GameStuff.Statics;
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
    public class PauseState : IGameState
    {
        public Texture2D background;
        public PauseState()
        {
            background = Globals.ContentManager.Load<Texture2D>("pause");

        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(background, new Rectangle(0, 0, 600, 800), Color.White);

        }

        public void Update(GameTime gameTime, GameStateManager gameStateManager)
        {
            if (KeyBoardHelper.IsKeyPressed(Keys.P))
            {
                gameStateManager._gameStates.Pop();
            }
        }
    }
}
