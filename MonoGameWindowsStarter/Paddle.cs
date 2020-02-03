using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameWindowsStarter
{
    public class Paddle
    {
        Game1 game;
        BoundingRectangle bounds;
        Texture2D texture;

        public Paddle(Game1 game)
        {
            this.game = game;
            bounds.X = 0;
            bounds.Y = game.GraphicsDevice.Viewport.Height / 2;
            bounds.Width = 50;
            bounds.Height = 200;
        }

        public void LoadContent(ContentManager content)
        {
            texture = content.Load();
        }

        public void Update()
        {
            var keyboarstate = Keyboard.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                bounds.Y -= 20;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                bounds.Y += 20;
            }

            if (bounds.Y < 0)
            {
                bounds.Y = 0;
            }
            if (bounds.Y > (game.GraphicsDevice.Viewport.Height - bounds.Height))
            {
                bounds.Y = (game.GraphicsDevice.Viewport.Height - bounds.Height);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, bounds, Color.LawnGreen);

        }
    }
}
