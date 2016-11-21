using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Diagnostics;

namespace Frogger
{
    class Obstacle
    {
        private Color c;
        private int speed;
        private Rectangle bb;
        private Texture2D carTex;
        private Game gm;
        private DateTime control;

        private static Random random = new Random();

        public Obstacle(Game g, SpriteBatch sb, Texture2D tx)
        {
            c = Color.White;
            speed = random.Next(1, 8);
            bb = new Rectangle(0, 383, 25, 20);
            gm = g;
            carTex = gm.Content.Load<Texture2D>("car right");
            control = DateTime.Parse("2012/12/12 15:00.00.000");
        }

        public void Update()
        {
           
            bb.X++;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(carTex, bb, c);
        }
    }
}
