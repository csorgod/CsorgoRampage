using CsorgoRampage.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CsorgoRampage.Player
{
    public interface IPlayer
    {
        #region Default Methods

        void Initialize(Texture2D texture, Vector2 position);
        void Update();
        void Draw(SpriteBatch spriteBatch);

        #endregion

        #region Member Access

        void SetPositionX(float value);

        void SetPositionY(float value);

        float GetPositionX();

        float GetPositionY();

        void SetMoveSpeed(float moveSpeed);

        float GetMoveSpeed();

        void UpdatePosition(KeyboardState CurrentState, IControl control, Viewport viewPort);

        #endregion
    }
}
