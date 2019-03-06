using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsorgoRampage.Enemies
{
    interface IEnemy
    {
        #region Default Methods

        void Initialize(Texture2D texture, Vector2 position);
        void Update();
        void Draw(SpriteBatch spriteBatch);

        #endregion

        void SetPositionX(float value);

        void SetPositionY(float value);
        
        float GetPositionX();

        float GetPositionY();

        void SetCartesianPosition(float axisX, float axisY);

        void Die();

        void Respawn();

        Vector2 GetCartesianPosition();
    }
}
