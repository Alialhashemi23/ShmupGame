using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb152024.GameStuff.GameStates
{
    public interface IGameState
    {
        void Update(GameTime gameTime, GameStateManager gameStateManager);

        void Draw(SpriteBatch _spriteBatch);
    }
}
