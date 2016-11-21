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
    class Level : Window
    {
        private Game gameHolder;
        private Texture2D testMap;
        private Rectangle boundingBox;

        public Level(Game g, SpriteBatch sb, Texture2D tx) : base(g, sb, tx) {
            gameHolder = g;
            testMap = gameHolder.Content.Load<Texture2D>("Frogger Mapv0.3");
            boundingBox = new Rectangle(0, 0, 800, 600);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Draw(testMap, boundingBox, Color.White);
            base.Draw(gameTime);
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
