using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsorgoRampage.Controls;
using CsorgoRampage.Player;

namespace CsorgoRampage.GameConfig
{
    class DefaultGameConfig : IGameConfig
    {
        public DefaultGameConfig()
        {
            Control = new KeyboardControl();
            Player = new DefaultPlayer();
        }

        public IControl Control { get; set; }
        
        public IPlayer Player { get; set; }
    }
}
