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
        private Color c;
        Texture2D testTexture;
        private Frog frogger;
        private Level levels;
        private Obstacle car;
        private int time = 0;

        

        public GamePlayWindow(Game g, SpriteBatch sb, Texture2D tx) :base(g, sb, tx)
        {
            testTexture = tx;
            c = Color.Wheat;
            frogger = new Frog(g);
            car = new Obstacle(g, sb, tx);
            levels = new Level(g, sb, tx);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            frogger.Update();
            levels.Update(gameTime);
            car.Update();
        }

        public override void Draw(GameTime gameTime)
        {
            levels.Draw(gameTime);
            base.Draw(gameTime);
            frogger.Draw(spriteBatch);
            car.Draw(spriteBatch);
           
        }
    }
}
