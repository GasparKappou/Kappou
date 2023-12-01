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
        static Texture2D star1;
        static Texture2D star2;
        static Texture2D texture;
        public Rectangle r;
        public Random rnd = new Random();
        public int resX = 800;
        public int resY = 600;
        public SpriteFont fuente;
        Character1 character1;
        Character2 character2;
        List<Platform> plataformas = new List<Platform> { };
        public double timer = 0;
        public int anchoLetra = 18;
        public bool juego = false;
        public int alturaCursor = 0;
        public bool estado = false;
        public int cantJugadores = 1;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
            _graphics.IsFullScreen = false;
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
            star1 = Content.Load<Texture2D>("starChar");
            star2 = Content.Load<Texture2D>("starChar2");
            character1 = new Character1(star1, new Vector2((resX - star1.Width) / 2, (resY - star1.Height) / 2));
            character2 = new Character2(star2, new Vector2((resX - star2.Width) / 2, (resY - star2.Height) / 2));

            texture = Content.Load<Texture2D>("platform");

            plataformas.Add(new Platform(texture, new Vector2(character1.position.X, character1.position.Y + 150),
                            new Rectangle((int)character1.position.X, (int)character1.position.Y + 150, texture.Width, 3)));
            fuente = Content.Load<SpriteFont>("monocraft");
        }
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();


            if (juego == false)
            {
                if (keyboardState.IsKeyDown(Keys.Up) && estado == true)
                {
                    alturaCursor -= 2;
                    estado = false;
                }
                if (keyboardState.IsKeyDown(Keys.Down) && estado == false)
                {
                    alturaCursor += 2;
                    estado = true;
                }
                if (keyboardState.)
                if (Keyboard.GetState().IsKeyDown(Keys.Enter) && alturaCursor == 2)
                    Exit();
                if (Keyboard.GetState().IsKeyDown(Keys.Enter) && alturaCursor == 0)
                    juego = !juego;
                base.Update(gameTime);
            }
            else
            {
                timer += 0.016;
                if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                    juego = !juego;
                if ((int)timer == 1)
                {
                    timer = 0;
                    if (!keyboardState.IsKeyDown(Keys.W) && character1.dif != 1)
                        character1.score++;
                    if (keyboardState.IsKeyDown(Keys.S) && character1.dif != 1)
                        character1.score++;
                    if (!keyboardState.IsKeyDown(Keys.Up) && character2.dif != 1)
                        character2.score++;
                    if (keyboardState.IsKeyDown(Keys.Down) && character2.dif != 1)
                        character2.score++;
                }
                if (cantJugadores == 1)
                {
                    if (character1.position.Y > resY)
                        NuevasPlataformas(character1.dif);

                    character1.MantenerDentro(_graphics);

                    if (character1.position.Y == 0)
                        character1.score += 10;

                    character1.Caer();

                    foreach (Platform p in plataformas)
                        if (character1.characterRec.Intersects(p.rectangle))
                        {
                            character1.position.Y -= 100f;
                            if (character1.score > 0)
                                character1.score--;
                        }

                    character1.Mover(keyboardState);
                    character1.Update(gameTime);
                }
                else
                {
                    if (character1.position.Y > resY)
                        NuevasPlataformas1(character1.dif);

                    character1.MantenerDentro(_graphics);

                    if (character1.position.Y == 0)
                        character1.score += 10;

                    character1.Caer();

                    foreach (Platform p in plataformas)
                        if (character1.characterRec.Intersects(p.rectangle))
                        {
                            character1.position.Y -= 100f;
                            if (character1.score > 0)
                                character1.score--;
                        }

                    character1.Mover(keyboardState);

                    if (character2.position.Y > resY)
                        NuevasPlataformas2(character2.dif);

                    character2.MantenerDentro(_graphics);

                    if (character2.position.Y == 0)
                        character2.score += 10;

                    character2.Caer();

                    foreach (Platform p in plataformas)
                        if (character2.characterRec.Intersects(p.rectangle))
                        {
                            character2.position.Y -= 100f;
                            if (character2.score > 0)
                                character2.score--;
                        }

                    character2.Mover(keyboardState);
                    character1.Update(gameTime);
                    character2.Update(gameTime);
                }
            }
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            _spriteBatch.Begin();

            if (juego == false)
            {
                Texture2D selector;
                selector = Content.Load<Texture2D>("blanco");
                r = new Rectangle(anchoLetra - 3, 6 + anchoLetra * alturaCursor, anchoLetra * 6, anchoLetra * 2);
                _spriteBatch.Draw(selector, r, Color.White);
                _spriteBatch.DrawString(fuente, "Jugar", new Vector2(anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, "Salir", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
            }
            else if (cantJugadores == 1)
            {
                character1.Draw(_spriteBatch);
                foreach (Platform platform in plataformas)
                    platform.Draw(_spriteBatch);
                _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character1.dif), new Vector2(8 * anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character1.score), new Vector2(8 * anchoLetra, anchoLetra * 2), Color.Black);
            }
            else
            {
                character1.Draw(_spriteBatch);
                foreach (Platform platform in plataformas)
                    platform.Draw(_spriteBatch);
                _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character1.dif), new Vector2(8 * anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character1.score), new Vector2(8 * anchoLetra, anchoLetra * 2), Color.Black);

                character2.Draw(_spriteBatch);
                foreach (Platform platform in plataformas)
                    platform.Draw(_spriteBatch);
                _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra * 22, 0), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character2.dif), new Vector2(29 * anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra * 22, anchoLetra * 2), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character2.score), new Vector2(29 * anchoLetra, anchoLetra * 2), Color.Black);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        public void NuevasPlataformas(int dif)
        {
            if (!(plataformas.Count <= 0))
                plataformas.Clear();
            for (int i = 0; i < dif * 14; i++)
            {
                r = new Rectangle(rnd.Next(0, resX - 17), rnd.Next(resY - (resY / 3), resY), texture.Width, 3);
                plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));
            }
            character1.dif += 1;
        }
        public void NuevasPlataformas1(int dif)
        {
            if (!(plataformas.Count <= 0))
                plataformas.Clear();
            for (int i = 0; i < dif * 5; i++)
            {
                r = new Rectangle(rnd.Next(0, resX - 17), rnd.Next(resY - (resY / 3), resY), texture.Width, 3);
                plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));
            }
            character1.dif += 1;
        }
        public void NuevasPlataformas2(int dif)
        {
            if (!(plataformas.Count <= 0))
                plataformas.Clear();
            for (int i = 0; i < dif * 5; i++)
            {
                r = new Rectangle(rnd.Next(0, resX - 17), rnd.Next(resY - (resY / 3), resY), texture.Width, 3);
                plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));
            }
            character2.dif += 1;
        }
    }
}