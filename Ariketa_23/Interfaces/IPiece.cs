using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_23.Interfaces
{
    internal interface IPiece
    {
        string[,] Form { get; }
        int Rotation { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
    }
}
