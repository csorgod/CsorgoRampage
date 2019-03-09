using System;
using System.Globalization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static CsorgoRampage.Helpers.Enum;

namespace CsorgoRampage.Enemies
{
    class PacMan : IEnemy
    {
        public Texture2D Texture;
        public Vector2 Position;
        public State State;
        
        public int HitPoints;
        
        public int Width;
        public int Height;
        
        private Rectangle ColisionArea;

        public Vector2 GetCartesianPosition()
        {
            return Position;
        }

        public float GetPositionX()
        {
            return Position.X;
        }

        public float GetPositionY()
        {
            return Position.Y;
        }
        
        public void SetCartesianPosition(float axisX, float axisY)
        {
            Position = new Vector2(axisX, axisY);
        }

        public void SetPositionX(float value)
        {
            Position.X = value;
        }

        public void SetPositionY(float value)
        {
            Position.Y = value;
        }

        public void Initialize(Texture2D texture, int maxWidth, int maxHeight)
        {
            Texture = texture;
            Position = new Vector2
                (float.Parse(new Random().Next(000, maxWidth).ToString(), CultureInfo.InvariantCulture.NumberFormat),
                float.Parse(new Random().Next(000, maxHeight).ToString(), CultureInfo.InvariantCulture.NumberFormat));
            State = State.Active;
            HitPoints = 1;
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.Red, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);
        }

        public void Die()
        {
            State = State.Inactive;
        }

        public void Respawn()
        {

        }

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
    }
}