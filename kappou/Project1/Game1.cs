using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Net.Mime;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        static Texture2D texture;
        
        Character character;
        List<Platform> plataformas = new List<Platform> { };
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.IsFullScreen = true;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.PreferredBackBufferWidth = 1920;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>("starChar");
            character = new Character(texture, new Vector2(_graphics.PreferredBackBufferWidth / 2 - 8, _graphics.PreferredBackBufferHeight / 2 - 8));
            texture = Content.Load<Texture2D>("platform");
            plataformas.Add(new Platform(texture, new Vector2(928, 800)));
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            if (character.position.Y > _graphics.PreferredBackBufferHeight - 16)
                character.position.Y -= character.gravedad;

            if (keyboardState.IsKeyDown(Keys.Up))
                character.position.Y -= 1;
            if (keyboardState.IsKeyDown(Keys.Left))
                character.position.X -= 1;
            if (keyboardState.IsKeyDown(Keys.Right))
                character.position.X += 1;

            character.Caer();

            // Update input, game objects, collision detection, etc.
            character.Update(gameTime);

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            _spriteBatch.Begin();
            character.Draw(_spriteBatch);
            plataformas[0].Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}