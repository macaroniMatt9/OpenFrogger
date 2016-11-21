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
    class Frog
    {
        private Color c;
        private int speed;
        private Rectangle bb;
        private Texture2D frogTex;
        private Keys Direction;
        private Game gm;

        public Frog(Game g)
        {
            c = Color.White;
            speed = 5;
            bb = new Rectangle(400, 500, 25, 25);
            gm = g;
            frogTex = gm.Content.Load<Texture2D>("froggerUp");

            Direction = Keys.Up;
        }

        public void Update()
        {

            // Determines the direction the frog is facing;

            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Direction = Keys.Up;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Direction = Keys.Down;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Direction = Keys.Left;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Direction = Keys.Right;
            }

            if (Direction == Keys.Up)
            {
                bb.Y--;
                frogTex = gm.Content.Load<Texture2D>("froggerUp");
            }

            if (Direction == Keys.Down)
            {
                bb.Y++;
                frogTex = gm.Content.Load<Texture2D>("froggerDown");
            }

            if (Direction == Keys.Left)
            {
                bb.X--;
                frogTex = gm.Content.Load<Texture2D>("froggerLEft");
            }

            if (Direction == Keys.Right)
            {
                bb.X++;
                frogTex = gm.Content.Load<Texture2D>("froggerRight");
            }



        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(frogTex, bb, c);
            
        }
    }
}
