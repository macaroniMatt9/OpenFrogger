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
    public class GamePlayWindow : Window
    {
        private Rectangle bb;
        private Color c;
        Texture2D testTexture;
        private Frog frogger;

        public GamePlayWindow(Game g, SpriteBatch sb, Texture2D tx) :base(g, sb, tx)
        {
            testTexture = tx;
            c = Color.Wheat;
            bb = new Rectangle(200, 250, 50, 50);
            frogger = new Frog(g);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            frogger.Update();
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Draw(testTexture, bb, c);
            frogger.Draw(spriteBatch);
        }
    }
}
