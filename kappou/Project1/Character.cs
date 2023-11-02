using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Project1
{
    class Character
    {
        private Texture2D texture;
        public Vector2 position;
        private Vector2 velocity;
        private float rotation;
        public float gravedad = 3f;
		public float velocidad = 2f;
		public Rectangle characterRec;
        public Character(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            this.velocity = Vector2.Zero;
            this.rotation = 0f;
        }
        
        public void Update(GameTime gameTime)
        {
			// Implement bird movement and physics logic here
			// Update position, velocity, rotation, etc.
			characterRec = new Rectangle((int)position.X, (int)position.Y, 16, 16);
		}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, new Rectangle(0, 0, texture.Width, texture.Height),
                            Color.White, rotation, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
        Rectangle a = new Rectangle();
        public void Caer()
        {
            position.Y += gravedad;
        }
    }
}
