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
    public class EndWindow : Window
    {
        private Rectangle bb;
        private Color c;
        private Texture2D testTexture;
        private Game gs;

        public EndWindow(Game g, SpriteBatch sb, Texture2D tx) : base(g, sb, tx)
        {
            testTexture = tx;
            c = Color.Purple;
            bb = new Rectangle(0, 0, 100, 200);
            gs = g;
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.gs.Exit();        
        }

        public override void Draw(GameTime gameTime)
        {

            base.Draw(gameTime);

            spriteBatch.Draw(testTexture, bb, c);
        }

        
    }
}
