using CsorgoRampage.GameConfig;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CsorgoRampage.Core
{
    public class GameCore : Game
    {
        protected IGameConfig GameConfig;
        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;
        protected KeyboardState CurrentState, PreviousState;

        public GameCore()
        {
            graphics = new GraphicsDeviceManager(this);

            GameConfig = new DefaultGameConfig();
            GameConfig.GetWindow().SetWidth(graphics.PreferredBackBufferWidth);
            GameConfig.GetWindow().SetHeight(graphics.PreferredBackBufferHeight);
            
        }
    }
}
