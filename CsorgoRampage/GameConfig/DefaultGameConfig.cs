using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsorgoRampage.Controls;
using CsorgoRampage.Player;
using CsorgoRampage.Window;

namespace CsorgoRampage.GameConfig
{
    class DefaultGameConfig : IGameConfig
    {
        private IControl Control;

        private IPlayer Player;

        private IWindow Window;

        public DefaultGameConfig()
        {
            Control = new KeyboardControl();
            Player = new DefaultPlayer();
            Window = new GameWindow();
        }

        public IControl GetControl()
        {
            return Control;
        }

        public IPlayer GetPlayer()
        {
            return Player;
        }

        public IWindow GetWindow()
        {
            return Window;
        }
        
        public void SetControl(IControl control)
        {
            Control = control;
        }

        public void SetPlayer(IPlayer player)
        {
            Player = player;
        }

        public void SetWindow(IWindow window)
        {
            Window = window;
        }

    }
}
