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
        static Texture2D plataforma;
        static Texture2D plataforma1;
        static Texture2D plataforma2;
        public Rectangle r;
        public Random rnd = new Random();
        public int resX = 800;
        public int resY = 600;
        public SpriteFont fuente;
        Character1 character1;
        Character2 character2;
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
            character1 = new Character1(star1, new Vector2((resX - star1.Width) / 2 - 8, (resY - star1.Height) / 2));
            character2 = new Character2(star2, new Vector2((resX - star2.Width) / 2 + 8, (resY - star2.Height) / 2));

            plataforma = Content.Load<Texture2D>("platform");
            plataforma1 = Content.Load<Texture2D>("platform1");
            plataforma2 = Content.Load<Texture2D>("platform2");
            if (cantJugadores == 2)
            {
                character1.plataformas.Add(new Platform(plataforma1, new Vector2(character1.position.X, character1.position.Y + 150),
                            new Rectangle((int)character1.position.X, (int)character1.position.Y + 150, plataforma1.Width, 3)));
            }
            else if (cantJugadores == 1)
            {
                character1.plataformas.Add(new Platform(plataforma, new Vector2(character1.position.X, character1.position.Y + 150),
                            new Rectangle((int)character1.position.X, (int)character1.position.Y + 150, plataforma.Width, 3)));
            }
            character2.plataformas.Add(new Platform(plataforma2, new Vector2(character2.position.X, character2.position.Y + 150),
                            new Rectangle((int)character2.position.X, (int)character2.position.Y + 150, plataforma2.Width, 3)));

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
                if (Keyboard.GetState().IsKeyDown(Keys.Enter) && alturaCursor == 2)
                    Exit();
                if (Keyboard.GetState().IsKeyDown(Keys.Enter) && alturaCursor == 0)
                    juego = !juego;
                if (Keyboard.GetState().IsKeyDown(Keys.Add) && cantJugadores == 1)
                    cantJugadores = 2;
                if (Keyboard.GetState().IsKeyDown(Keys.OemMinus) && cantJugadores == 2)
                    cantJugadores = 1;
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
                        character1.NuevasPlataformas(character1.dif, rnd, resX, resY, r, cantJugadores, plataforma);

                    character1.MantenerDentro(_graphics);

                    if (character1.position.Y == 0)
                        character1.score += 10;

                    character1.Caer();

                    foreach (Platform p in character1.plataformas)
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
                        character1.NuevasPlataformas(character1.dif, rnd, resX, resY, r, cantJugadores, plataforma1);

                    character1.MantenerDentro(_graphics);

                    if (character1.position.Y == 0)
                        character1.score += 10;

                    character1.Caer();

                    foreach (Platform p in character1.plataformas)
                        if (character1.characterRec.Intersects(p.rectangle))
                        {
                            character1.position.Y -= 100f;
                            if (character1.score > 0)
                                character1.score--;
                        }

                    character1.Mover(keyboardState);

                    if (character2.position.Y > resY)
                        character2.NuevasPlataformas(character2.dif, rnd, resX, resY, r, plataforma2);

                    character2.MantenerDentro(_graphics);

                    if (character2.position.Y == 0)
                        character2.score += 10;

                    character2.Caer();

                    foreach (Platform p in character2.plataformas)
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
            Texture2D selector;
            selector = Content.Load<Texture2D>("blanco");
            if (juego == false)
            {
                selector = Content.Load<Texture2D>("blanco");
                r = new Rectangle(anchoLetra - 3, 6 + anchoLetra * alturaCursor - 6, anchoLetra * 6, anchoLetra * 2);
                _spriteBatch.Draw(selector, r, Color.White);
                _spriteBatch.DrawString(fuente, "Jugar", new Vector2(anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, "Salir", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
                _spriteBatch.DrawString(fuente, "Cantidad de jugadores", new Vector2(anchoLetra, anchoLetra * 4), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(cantJugadores), new Vector2(anchoLetra, anchoLetra * 6), Color.Black);
                _spriteBatch.DrawString(fuente, "'+' para agregarr '-' para restar", new Vector2(anchoLetra, anchoLetra * 8), Color.Black);
            }
            else if (cantJugadores == 1)
            {
                character1.Draw(_spriteBatch);
                foreach (Platform platform in character1.plataformas)
                    platform.Draw(_spriteBatch);
                _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character1.dif), new Vector2(8 * anchoLetra, 0), Color.Black);
                _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
                _spriteBatch.DrawString(fuente, Convert.ToString(character1.score), new Vector2(8 * anchoLetra, anchoLetra * 2), Color.Black);
            }
            else
            {
                if (character2.score <
                    character1.score)
                {
                    character1.Draw(_spriteBatch);
                    foreach (Platform platform in character1.plataformas)
                        platform.Draw(_spriteBatch);
                    _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character1.dif), new Vector2(8 * anchoLetra, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character1.score), new Vector2(8 * anchoLetra, anchoLetra * 2), Color.Black);

                    character2.Draw(_spriteBatch);
                    foreach (Platform platform in character2.plataformas)
                        platform.Draw(_spriteBatch);
                    _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra * 23, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character2.dif), new Vector2(30 * anchoLetra, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra * 23, anchoLetra * 2), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character2.score), new Vector2(30 * anchoLetra, anchoLetra * 2), Color.Black);
                }
                else
                {
                    character2.Draw(_spriteBatch);
                    foreach (Platform platform in character2.plataformas)
                        platform.Draw(_spriteBatch);
                    _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra * 23, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character2.dif), new Vector2(30 * anchoLetra, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra * 23, anchoLetra * 2), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character2.score), new Vector2(30 * anchoLetra, anchoLetra * 2), Color.Black);

                    character1.Draw(_spriteBatch);
                    foreach (Platform platform in character1.plataformas)
                        platform.Draw(_spriteBatch);
                    _spriteBatch.DrawString(fuente, "Level:", new Vector2(anchoLetra, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character1.dif), new Vector2(8 * anchoLetra, 0), Color.Black);
                    _spriteBatch.DrawString(fuente, "Score:", new Vector2(anchoLetra, anchoLetra * 2), Color.Black);
                    _spriteBatch.DrawString(fuente, Convert.ToString(character1.score), new Vector2(8 * anchoLetra, anchoLetra * 2), Color.Black);

                }
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}