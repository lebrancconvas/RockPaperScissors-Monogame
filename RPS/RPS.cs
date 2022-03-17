using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPS
{
    public class RPS : Game
    {
        public const int WIDTH = 800;
        public const int HEIGHT = 600;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D _rockOpponent, _paperOpponent, _scissorOpponent;
        Texture2D _rockPlayer, _paperPlayer, _scissorPlayer;
        SpriteFont _font;

        public RPS()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = WIDTH;
            _graphics.PreferredBackBufferHeight = HEIGHT;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _rockOpponent = this.Content.Load<Texture2D>("Sprite/Rock32");
            _paperOpponent = this.Content.Load<Texture2D>("Sprite/Paper32");
            _scissorOpponent = this.Content.Load<Texture2D>("Sprite/Scissor32");

            _rockPlayer = this.Content.Load<Texture2D>("Sprite/Rock32");
            _paperPlayer = this.Content.Load<Texture2D>("Sprite/Paper32");
            _scissorPlayer = this.Content.Load<Texture2D>("Sprite/Scissor32");

            _font = this.Content.Load<SpriteFont>("Font/GameFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) 
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            // Drawing.
            _spriteBatch.Draw(_rockOpponent, new Vector2(170, 100), Color.White);
            _spriteBatch.Draw(_paperOpponent, new Vector2(370, 100), Color.White);
            _spriteBatch.Draw(_scissorOpponent, new Vector2(570, 100), Color.White);

            _spriteBatch.Draw(_rockPlayer, new Vector2(170, 500), Color.White);
            _spriteBatch.Draw(_paperPlayer, new Vector2(370, 500), Color.White);
            _spriteBatch.Draw(_scissorPlayer, new Vector2(570, 500), Color.White); 

            _spriteBatch.End();

            base.Draw(gameTime); 
        }
    }
}
