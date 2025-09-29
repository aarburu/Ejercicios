using Ariketa_22.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_22.Models.Abstract
{
    public abstract class GameMember : IGameMember
    {
        public string Name { get; set; } = "";
        public int Score { get; set; } = 5;

        public int SelectedNumber { get; set; }
        public int Guess { get; set; }

        public void AddScore(int score)
        {
            Score += score;
        }

        public abstract void SelectNumber();
        public abstract void SelectGuess();
        public void HasWon(int WinningNumber)
        {
            if (WinningNumber % 2 == this.Guess)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{this.Name}-(e)k irabazi du erronda.");
                Console.ResetColor();
                this.Score++;
            }
            else { 
                this.Score--;
            }
        }
    }
}
