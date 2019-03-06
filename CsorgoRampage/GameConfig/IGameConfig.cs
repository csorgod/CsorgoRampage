using CsorgoRampage.Controls;
using CsorgoRampage.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsorgoRampage.GameConfig
{
    interface IGameConfig
    {
        IControl Control { get; set; }
        IPlayer Player { get; set; }
    }
}
