using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_22.Interfaces
{
    internal interface IGameMember
    {
        string Name { get; }
        int Score { get; }

        int SelectedNumber { get; }
        int Guess { get; set; }
        

        void AddScore(int score);

        void SelectNumber();
        void SelectGuess();
        void HasWon(int WinningNumber);
    }
}
