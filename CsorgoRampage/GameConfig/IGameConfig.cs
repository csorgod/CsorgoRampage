using CsorgoRampage.Controls;
using CsorgoRampage.Player;
using CsorgoRampage.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsorgoRampage.GameConfig
{
    public interface IGameConfig
    {
        IControl GetControl();
        IPlayer GetPlayer();
        IWindow GetWindow();

        void SetControl(IControl control);
        void SetPlayer(IPlayer player);
        void SetWindow(IWindow window);
    }
}
