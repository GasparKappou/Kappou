using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Character
    {
        private Texture2D texture;
        private Vector2 position;
        private Vector2 velocity;
        private float rotation;

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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, rotation, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
