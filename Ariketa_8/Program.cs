/*
Zenbaki oso bat zenbaki erromatar bihurtzea.
*/

int number;
bool isValid = false;

do
{
    Console.WriteLine("Sartu 1 eta 3999999 arteko zenbaki oso bat: ");
    var input = Console.ReadLine();

    if (int.TryParse(input, out number))
    {
        isValid = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Errorea: Mesedez, sartu zenbaki oso baliodun bat.");
        Console.ResetColor();
    }
} while (!isValid);

try
{
    string roman = Utils.ConvertToRoman(number);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Zenbaki erromatarra: {roman}");
    Console.ResetColor();
}
catch (ArgumentOutOfRangeException e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    Console.ResetColor();
}


