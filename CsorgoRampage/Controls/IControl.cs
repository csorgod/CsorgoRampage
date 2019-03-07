using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CsorgoRampage.Helpers.Enum;

namespace CsorgoRampage.Controls
{
    public interface IControl
    {
        ControlType ControlType { get; }
        Keys Up { get; }
        Keys Down { get; }
        Keys Left { get; }
        Keys Right { get; }
        Keys Attack { get; }
        
    }
}
