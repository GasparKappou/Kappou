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
    internal class Platform
    {
        private Texture2D texture;
        public Vector2 position;
        public Rectangle rectangle;

        public Platform(Texture2D texture, Vector2 position, Rectangle rectangle)
        {
            this.texture = texture;
            this.position = position;
            this.rectangle = rectangle;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}
