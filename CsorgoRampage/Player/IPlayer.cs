using CsorgoRampage.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CsorgoRampage.Player
{
    interface IPlayer
    {
        //Texture2D Texture { get; set; }
        //Vector2 Position { get; set; }
        //State State { get; set; }

        //string Name { get; set; }
        //int HitPoints { get; set; }
        //float MoveSpeed { get; set; }

        //int Width { get; set; }
        //int Height { get; set; }

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
