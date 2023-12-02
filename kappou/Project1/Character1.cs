using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;
using Microsoft.Xna.Framework.Input;

namespace Project1
{
    class Character1
    {
        private Texture2D texture;
        public Vector2 position;
        private Vector2 velocity;
        private float rotation;
        public float gravedad = 3f;
		public float velocidad = 2f;
		public Rectangle characterRec;
        public int score;
        public int dif = 1;
        public List<Platform> plataformas = new List<Platform> { };
        public Character1(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            this.velocity = Vector2.Zero;
            this.rotation = 0f;
        }
        
        public void Update(GameTime gameTime)
        {
			characterRec = new Rectangle((int)position.X, (int)position.Y, 16, 16);
		}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, new Rectangle(0, 0, texture.Width, texture.Height),
                            Color.White, rotation, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
        public void Caer()
        {
            position.Y += gravedad;
        }

        public void Mover(KeyboardState k)
        {
            if (k.IsKeyDown(Keys.W)) position.Y -= velocidad;
            if (k.IsKeyDown(Keys.S)) position.Y += velocidad;
            if (k.IsKeyDown(Keys.D)) position.X += velocidad;
            if (k.IsKeyDown(Keys.A)) position.X -= velocidad;
        }
        public void MantenerDentro(GraphicsDeviceManager graphics)
        {
            if (position.X > graphics.PreferredBackBufferWidth) position.X = 0;
            else if (position.X < 0) position.X = graphics.PreferredBackBufferWidth;
            else if (position.Y > graphics.PreferredBackBufferHeight) position.Y = 0;
        }
        public void NuevasPlataformas(int dif, Random rnd, int resX, int resY, Rectangle r, int cantJu, Texture2D texture)
        {
            if (cantJu == 1)
            {
                if (!(plataformas.Count <= 0))
                    plataformas.Clear();
                for (int i = 0; i < dif * 14; i++)
                {
                    r = new Rectangle(rnd.Next(0, resX - 16), rnd.Next(resY - (resY / 3), resY), texture.Width, 3);
                    plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));
                }
            }
            else if (cantJu == 2)
            {
                if (!(plataformas.Count <= 0))
                    plataformas.Clear();
                for (int i = 0; i < dif * 6; i++)
                {
                    r = new Rectangle(rnd.Next(0, resX - 16), rnd.Next(resY - (resY / 3), resY), texture.Width, 3);
                    plataformas.Add(new Platform(texture, new Vector2(r.X, r.Y), r));
                }
            }
            this.dif += 1;
        }
    }
}
