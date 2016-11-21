using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frogger
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Window activeWindow;
        StartWindow start;
        GamePlayWindow gamePlay;
        EndWindow end;
       
        Texture2D basicTexture;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";  
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {


            spriteBatch = new SpriteBatch(GraphicsDevice);

            basicTexture = new Texture2D(GraphicsDevice, 1, 1);
            basicTexture.SetData(new[] { Color.DarkMagenta });

            start = new StartWindow(this, spriteBatch, basicTexture);
            Components.Add(start);
            start.Hide();

            gamePlay = new GamePlayWindow(this, spriteBatch, basicTexture);
            Components.Add(gamePlay);
            gamePlay.Hide();

            end = new EndWindow(this, spriteBatch, basicTexture);
            Components.Add(end);
            end.Hide();

            activeWindow = start;

            activeWindow.Show();
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                activeWindow.Hide();
                activeWindow = gamePlay;
                activeWindow.Show();     
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                activeWindow.Hide();
                activeWindow = end;
                activeWindow.Show();
            }

            base.Update(gameTime);
        }


        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            base.Draw(gameTime);

            spriteBatch.End();
        }
    }
}
