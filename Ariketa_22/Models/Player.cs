using Ariketa_22.Models.Abstract;

namespace Ariketa_22.Models
{
    public class Player : GameMember
    {
        public Player()
        {
        }

        public Player(string Name)
        {
            this.Name = Name;
        }


        public override void SelectGuess()
        {
            var isNumeric = false;
            var guessValue = -1;
            do
            {
                Console.WriteLine($"[{this.Name}] Sartu bakoitia ala bikoitia izango den. Bakoitia = 1, Bikoitia = 0.");
                var guess = Console.ReadLine();
                isNumeric = int.TryParse(guess, out guessValue);
            } while (!isNumeric || guessValue < 0 || guessValue > 1);
            this.Guess = guessValue;
        }

        public override void SelectNumber()
        {
            var IsNumeric = false;
            var SelectedNumber = -1;
            do
            {
                Console.WriteLine($"[{this.Name}] Sartu 1 eta 10 arteko zenbakia.");
                var Num = Console.ReadLine();
                IsNumeric = int.TryParse(Num, out SelectedNumber);
            } while (!IsNumeric || SelectedNumber < 0 || SelectedNumber > 10);
            this.SelectedNumber = SelectedNumber;
        }


    }
}
