using Ariketa_22.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa_22.Models
{
    public class Game
    {
        List<IGameMember> PlayerList { get; set; }

        internal Game(List<IGameMember> PlayerList)
        {
            this.PlayerList = PlayerList;
        }

        internal void PlayRound()
        {
            var playerGuess = false;

            var NumericSum = 0;
            foreach (var player in PlayerList)
            {
                player.SelectNumber();
                player.SelectGuess();

                //En caso de que el juego se limita a 2 jugadores (1 jugador y 1 pc), hago que el pc tenga la condición contraria.
                // Si el jugador ha elegido pares, el pc tendrá nones.
                // En el caso de que haya más de 1 pc, cada uno seleccionará libremente su opción.
                if (PlayerList.Count() == 2 && player is Player)  
                    playerGuess = Convert.ToBoolean(player.Guess);
                else if (PlayerList.Count == 2) 
                    player.Guess = Convert.ToInt32(!playerGuess);

                NumericSum += player.SelectedNumber;
            }

            Console.WriteLine($"Zenbakien gehiketa totala {NumericSum} da.");

            foreach (var player in PlayerList)
                player.HasWon(NumericSum);
        }

        internal void ShowScoreboard()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jokalarien puntuazioa hau da:");
            PlayerList.ForEach(x => Console.WriteLine($"{x.Name}: {x.Score} puntu."));
            Console.ResetColor();
        }
    }
}
