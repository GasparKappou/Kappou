using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Net.Mime;
using System.Threading;
using System; //gaspar te amo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

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
        public int resX = 800;
        public int resY = 600;
        public int dif = 1;
        public SpriteFont fuente;
        public int contador;
        Character character;
        List<Platform> plataformas = new List<Platform> { };
        public double timer = 0;
        public int anchoLetra = 18;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.IsFullScreen = true;
			_graphics.PreferredBackBufferWidth = resX;
			_graphics.PreferredBackBufferHeight = resY;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            star = Content.Load<Texture2D>("starChar");
            character = new Character(star, new Vector2((resX - star.Width) / 2, (resY - star.Height) / 2));
			
            texture = Content.Load<Texture2D>("platform");

            plataformas.Add(new Platform(texture, new Vector2(character.position.X, character.position.Y + 150),
                            new Rectangle((int)character.position.X, (int)character.position.Y + 150, texture.Width, 3)));
            fuente = Content.Load<SpriteFont>("monocraft");
        }
        protected override void Update(GameTime gameTime)
        {
            timer += 0.016;
            KeyboardState keyboardState = Keyboard.GetState();

            if ((int)timer == 1)
            {
                timer = 0;
                if (!keyboardState.IsKeyDown(Keys.Up) && dif != 1)
                    contador++;
                if (keyboardState.IsKeyDown(Keys.Down) && dif != 1)
                    contador++;
            }

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (character.position.Y > resY)
                NuevasPlataformas(dif);

            character.MantenerDentro(_graphics);

            if (character.position.Y == 0)
                contador += 10;

            character.Caer();

            foreach(Platform p in plataformas)
                if (character.characterRec.Intersects(p.rectangle))
                {
                    character.position.Y -= 100f;
                    if (contador > 0)
                        contador--;
                }

            character.Mover(keyboardState);

			character.Update(gameTime);

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            _spriteBatch.Begin();

            character.Draw(_spriteBatch);
            foreach (Platform platform in plataformas)
                platform.Draw(_spriteBatch);
            _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra, 0), Color.Black);
            _spriteBatch.DrawString(fuente, Convert.ToString(dif), new Vector2(8 * anchoLetra, 0), Color.Black);
            _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
            _spriteBatch.DrawString(fuente, Convert.ToString(contador), new Vector2(8 * anchoLetra, anchoLetra * 2), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
        public void NuevasPlataformas(int dif)
        {
            if (!(plataformas.Count <= 0))
			    plataformas.Clear();
            for (int i = 0; i < dif*14; i++)
			{
				r = new Rectangle(rnd.Next(0, resX-17), rnd.Next(resY - (resY / 3), resY), texture.Width, 3);
				plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));
			}
            this.dif += 1; 
		}
    }
}