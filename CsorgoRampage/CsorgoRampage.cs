using CsorgoRampage.Enemies;
using CsorgoRampage.GameConfig;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CsorgoRampage.Core;

namespace CsorgoRampage
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class CsorgoRampage : GameCore
    {
        
        #region Custom Variables
        
        IEnemy PacMan = new PacMan();

        #endregion

        public CsorgoRampage()
        {
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            graphics.PreferredBackBufferWidth = GameConfig.GetWindow().GetWidth(); //GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GameConfig.GetWindow().GetHeight(); //GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            var playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.Width / 2, GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            
            GameConfig.GetPlayer().Initialize(Content.Load<Texture2D>("Player\\player"), playerPosition);
            PacMan.Initialize(Content.Load<Texture2D>("Enemy\\pacman"), GameConfig.GetWindow().GetWidth(), GameConfig.GetWindow().GetHeight());
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            #region PlayerPosition 

            PreviousState = CurrentState;
            CurrentState = Keyboard.GetState();
            GameConfig.GetPlayer().UpdatePosition(CurrentState, GameConfig.GetControl(), GraphicsDevice.Viewport);

            #endregion
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            GameConfig.GetPlayer().Draw(spriteBatch);
            PacMan.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
