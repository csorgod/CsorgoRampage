using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsorgoRampage.Window
{
    class GameWindow : IWindow
    {
        private int Width;
        private int Height;

        public GameWindow()
        {
            Width = 800;
            Height = 800;
        }

        public void SetWidth(int width)
        {
            Width = width;
        }

        public int GetWidth()
        {
            return Width;
        }

        public void SetHeight(int height)
        {
            Height = height;
        }

        public int GetHeight()
        {
            return Height;
        }

    }
}
