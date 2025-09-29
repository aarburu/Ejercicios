using Ariketa_22.Interfaces;
using Ariketa_22.Models.Abstract;
namespace Ariketa_22.Models
{
    internal class Computer : GameMember, IComputer
    {
        public Computer() { }

        public Computer(string Name)
        {
            this.Name = Name;
        }

        public int GenerateNumber()
        {
            var rnd = new Random();
            return rnd.Next(1,10);
        }


        public override void SelectGuess()
        {
            var rnd = new Random();
            this.Guess = rnd.Next(0, 1);
        }

        public override void SelectNumber()
        {
            var rnd = new Random();
            this.SelectedNumber = rnd.Next(0, 10);
        }
    }
}
