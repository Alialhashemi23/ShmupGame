using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.GameStates
{
    public class GameStateManager
    {
        public Stack<IGameState> _gameStates;

        public void Initialize()
        {
            _gameStates = new Stack<IGameState>();
            _gameStates.Push(new TitleScreenState());
        }
        public void Update(GameTime gameTime)
        {
            _gameStates.Peek().Update(gameTime, this);
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _gameStates.Peek().Draw(_spriteBatch);
        }
    }
}
