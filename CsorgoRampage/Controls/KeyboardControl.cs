using Microsoft.Xna.Framework.Input;
using static CsorgoRampage.Helpers.Enum;

namespace CsorgoRampage.Controls
{
    class KeyboardControl : IControl
    {
        public KeyboardControl()
        {
            ControlType = ControlType.Keyboard;
            Up = Keys.W;
            Down = Keys.S;
            Left = Keys.A;
            Right = Keys.D;
            Attack = Keys.Space;
        }

        public ControlType ControlType { get; set; }

        public Keys Up { get; set; }

        public Keys Down { get; set; }

        public Keys Left { get; set; }

        public Keys Right { get; set; }

        public Keys Attack { get; set; }
    }
}
