using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono_2_assingment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectText, circleText;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferHeight = 400;
            _graphics.PreferredBackBufferWidth = 700;

            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleText = Content.Load<Texture2D>("circle");
            rectText = Content.Load<Texture2D>("rectangle");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(circleText, new Rectangle(0,0,700,400), Color.Beige);
            _spriteBatch.Draw(circleText, new Rectangle(250, 20, 50, 70), Color.Black);
            _spriteBatch.Draw(circleText, new Rectangle(360, 20, 50, 70), Color.Black);
            _spriteBatch.Draw(circleText, new Rectangle(260, 40, 25, 35), Color.White);
            _spriteBatch.Draw(circleText, new Rectangle(370, 40, 25, 35), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}