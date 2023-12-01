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
    }
}
