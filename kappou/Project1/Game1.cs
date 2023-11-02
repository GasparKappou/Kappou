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
        private static GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
		static Texture2D star;
		static Texture2D texture;
        public Rectangle r;
        public Random rnd = new Random();

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
            star = Content.Load<Texture2D>("starChar");
            character = new Character(star, new Vector2(_graphics.PreferredBackBufferWidth / 2 - 8, _graphics.PreferredBackBufferHeight / 2 - 8));

            texture = Content.Load<Texture2D>("platform");
            for (int i = 0; i < 15; i++) {
                r = new Rectangle(rnd.Next(500, 1500), rnd.Next(800, 1000), texture.Width, texture.Height);
                plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));

            }
        }
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();
                        
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
			character.Caer();
            foreach(Platform p in plataformas)
                if (character.characterRec.Intersects(p.rectangle))
                {
                    character.position.Y -= 100f;
                }
			if (keyboardState.IsKeyDown(Keys.Up))
                character.position.Y -= character.velocidad;
            if (keyboardState.IsKeyDown(Keys.Left))
                character.position.X -= character.velocidad;
            if (keyboardState.IsKeyDown(Keys.Right))
                character.position.X += character.velocidad;

			// Update input, game objects, collision detection, etc.
			character.Update(gameTime);

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            _spriteBatch.Begin();
            character.Draw(_spriteBatch);
            foreach (Platform platform in plataformas)
            {
				platform.Draw(_spriteBatch);
			}
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}