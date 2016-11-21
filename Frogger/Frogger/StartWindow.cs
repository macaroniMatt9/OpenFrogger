using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Frogger
{
    public class StartWindow : Window
    {
        private Rectangle bb;
        private Color c;
        Texture2D testTexture;

        public StartWindow(Game g, SpriteBatch sb, Texture2D tx) : base(g, sb, tx)
        {
            bb = new Rectangle(100, 100, 25, 25);
            c = Color.White;
            testTexture = tx;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Draw(testTexture, bb, c);
        }
    }
}
