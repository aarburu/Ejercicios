/*
Teklatuko zenbaki oso bat emanda, kalkulatu haren faktoriala.
(n! = n * (n-1) * (n-2)....) 
*/
var isInteger = false;
int number;
int originalNumber;
do
{
    Console.WriteLine("Sartu zenbaki oso bat.");
    var text = Console.ReadLine();
    isInteger = int.TryParse(text, out number);
} while (!isInteger);

int factorial = 0;
originalNumber = number;

var calcText = "";
while (number > 0)
{
    if (factorial == 0)
    {
        factorial = number;
        calcText = $"{factorial}";
    }
    else
    {
        factorial = factorial * number;
        calcText += $" * {number}";
        
    }
    number--;

}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{originalNumber}! = {calcText} = {factorial}");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{originalNumber}-(r)en faktoriala {factorial} da.");
Console.ResetColor();
