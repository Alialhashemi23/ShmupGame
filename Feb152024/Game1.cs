using Feb152024.GameStuff;
using Feb152024.GameStuff.CharacterBehaviors;
using Feb152024.GameStuff.EnemyBehaviors;
using Feb152024.GameStuff.Enums;
using Feb152024.GameStuff.GameStates;
using Feb152024.GameStuff.ShotStuff;
using Feb152024.GameStuff.Statics;
using Feb152024.GameStuff.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Feb152024
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _font;

        public GameStateManager gameStateManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.PreferredBackBufferWidth = 600;
        }

        protected override void Initialize()
        {

            base.Initialize();
            Globals.ContentManager = Content;
            gameStateManager = new GameStateManager();
            gameStateManager.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _font = Content.Load<SpriteFont>("Arial");
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Globals.CreateFactory();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Globals.TimerSpawner.Update(gameTime);
            gameStateManager.Update(gameTime);
            KeyBoardHelper.Update();
            Globals.TimerSpawner.Dispose();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            _spriteBatch.Begin();
            base.Draw(gameTime);
            gameStateManager.Draw(_spriteBatch);
            _spriteBatch.End();
        }
    }
}
