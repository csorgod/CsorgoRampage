using CsorgoRampage.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static CsorgoRampage.Helpers.Enum;

namespace CsorgoRampage.Player
{
    public class DefaultPlayer : IPlayer
    {
        private Texture2D Texture;
        private Vector2 Position;
        private State State;

        private string Name;
        private int HitPoints;
        private float MoveSpeed;

        private int Width;
        private int Height;

        private Rectangle ColisionArea;
        
        #region Position 

        public float GetPositionX()
        {
            return Position.X;
        }

        public float GetPositionY()
        {
            return Position.Y;
        }

        public void SetPositionX(float value)
        {
            Position.X = value;
        }

        public void SetPositionY(float value)
        {
            Position.Y = value;
        }

        #endregion

        #region MoveSpeed

        public void SetMoveSpeed(float moveSpeed)
        {
            MoveSpeed = moveSpeed;

        }

        public float GetMoveSpeed()
        {
            return MoveSpeed;
        }

        #endregion

        #region Width



        #endregion

        #region Height



        #endregion

        #region ColisionArea

        public void SetColisionArea()
        {
            ColisionArea = new Rectangle(
                (int)GetPositionX(),
                (int)GetPositionY(),
                Width,
                Height);

        }

        public bool GetColisionArea(Rectangle rectangle)
        {
            return ColisionArea.Intersects(rectangle);
        }

        #endregion

        public void Initialize(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
            State = State.Active;
            HitPoints = 100;
            MoveSpeed = 4.0f;
            SetColisionArea();
        }
        
        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.Blue, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);
        }
        
        public void UpdatePosition(KeyboardState currentState, IControl control, Viewport viewPort)
        {
            SetPositionX(MathHelper.Clamp(GetPositionX(), 0, viewPort.Width - Width));
            SetPositionY(MathHelper.Clamp(GetPositionY(), 0, viewPort.Height - Width));
            
            if (currentState.IsKeyDown(control.Left))
                SetPositionX(GetPositionX() - GetMoveSpeed());
            if (currentState.IsKeyDown(control.Right))
                SetPositionX(GetPositionX() + GetMoveSpeed());
            if (currentState.IsKeyDown(control.Up))
                SetPositionY(GetPositionY() - GetMoveSpeed());
            if (currentState.IsKeyDown(control.Down))
                SetPositionY(GetPositionY() + GetMoveSpeed());
        }
        
    }
}
