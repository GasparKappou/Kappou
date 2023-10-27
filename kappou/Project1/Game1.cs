﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Net.Mime;
using System.Threading;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        static Texture2D star;
        Character character;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
            _graphics.IsFullScreen = true;
            _graphics.PreferredBackBufferHeight = 135;
            _graphics.PreferredBackBufferWidth = 240;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            star = Content.Load<Texture2D>("starChar");
            character = new Character(star, new Vector2(100, 100));
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Down))
            {
                float y = character.position.Y + 1;
                character.position = new Vector2(character.position.X, y);
            }
            if(keyboardState.IsKeyDown(Keys.Up))
            {
                float y = character.position.Y - 1;
                character.position = new Vector2(character.position.X, y);
            }
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                float x = character.position.X - 1;
                character.position = new Vector2(x, character.position.Y);
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                float x = character.position.X + 1;
                character.position = new Vector2(x, character.position.Y);
            }
            // Update input, game objects, collision detection, etc.
            character.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Draw game objects
            character.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}