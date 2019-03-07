using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsorgoRampage.Window
{
    public interface IWindow
    {
        void SetWidth(int width);

        void SetHeight(int height);

        int GetWidth();

        int GetHeight();
    }
}
