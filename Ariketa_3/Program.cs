/*
 Edozein zenbaki oso emanda, pantailaren arabera agertzen da 3ren
multiploa den ala ez.
*/

var isInteger = false;
int number;
do
{
    Console.WriteLine("Sartu zenbaki oso bat.");
    var text = Console.ReadLine();
    isInteger = int.TryParse(text, out number);
} while (!isInteger);

bool HirurenMultiploa = number % 3 == 0;

if (HirurenMultiploa)
    Console.WriteLine($"{number} hiruren multiploa da.");
else
    Console.WriteLine($"{number} ez da hiruren multiploa.");