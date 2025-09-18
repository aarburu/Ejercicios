/*
1 eta 10 arteko (biak barne) ausazko zenbaki bat sortu eta
erabiltzaileak asmatu arte zenbakiak eskatzen dizkion programa
idatzi. Kontrolatu sartzen den zenbakia 1 eta 10 tartean
egotea. Oharra: konprobatu 1 eta 10 arteko zenbaki guztiak ausaz
atera daitezkeela
*/

using System.Diagnostics.Contracts;

var rnd = new Random();
var randomNumber = rnd.Next(1, 10);

var validNumber = false;
var isGuessed = false;
var guessedNumbers = new List<string>();

do
{
    Console.WriteLine("Sartu 1 eta 10 arteko zenbaki bat.");
    var input = Console.ReadLine();
    var isNumeric = int.TryParse(input, out var num);
    if (isNumeric)
    {
        if (num < 1 && num > 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zenbakia 1 eta 10 artean egon behar da.");
            Console.ResetColor();
            validNumber = false;
        }
        else
        {
            validNumber = true;
            guessedNumbers.Add(num.ToString());
            if (randomNumber == num)
            {
                isGuessed = true;
            }
            else
            {
                Console.WriteLine($"{num} ez da ausazko zenbakia.");
                Console.WriteLine($"Sartutako zenbakiak: {string.Join(" ", guessedNumbers.ToArray())}");
            }

        }

    }
    if (isGuessed) {
        Console.WriteLine($"Ausezko zenbakia {num} zen. {guessedNumbers.Count()} saiakera izan dituzu: {string.Join(" ", guessedNumbers.ToArray())}");

    }
} while (!validNumber || !isGuessed);



