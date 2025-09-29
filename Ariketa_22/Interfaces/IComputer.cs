using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_22.Interfaces
{
    internal interface IComputer: IGameMember
    {
        int GenerateNumber();
    }
}
