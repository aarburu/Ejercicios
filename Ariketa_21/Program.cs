/*
Kontsolatik eskatu zenbaki osoak 20 zenbaki lortu arte. Denak positiboak izan behar dira eta ezin dira errepikatu.
• Bi array-etan lehenak (primos) eta konposatuak banatu.
• Zenbatu zenbat diren lehenak eta zenbat konposatuak.
• Kontsolatik erakutsi lehenak direnak handienetik txikienera ordenatuta eta adierazi zenbat diren.
• Kontsolatik erakutsi konposatuak direnak txikienetik handienera ordenatuta eta adierazi zenbat diren.
*/

var existingNumber = false;
var numberList = new List<int>();
var primeNumberList = new List<int>();
var compositeNumberList = new List<int>();

do
{
    Console.WriteLine($"Sartu zenbaki oso bat. {numberList.Count()} / 20 zenbaki sartu dituzu.");
    var input = Console.ReadLine();

    var num = int.Parse(input);

    existingNumber = numberList.Exists(p => p == num);
    if (!existingNumber)
        numberList.Add(num);
    else
        Console.WriteLine($"{num} errepikatuta dago.");
} while (numberList.Count() < 20);

foreach (var item in numberList)
{
    var divisorFound = false;
    var half = item / 2;
    for (int i = 2; i < half && !divisorFound; i++)
    {
        if (item % i == 0)
        {
            divisorFound = true;
            compositeNumberList.Add(item);
        }
    }
    if (!divisorFound)
        primeNumberList.Add(item);

}

Console.WriteLine($"Hay un total de {primeNumberList.Count()} números primos.");
Console.WriteLine($"--- Inicio ---");
Console.WriteLine($"{string.Join("\n", primeNumberList.OrderByDescending(p => p).Select(p => p))}");
Console.WriteLine($"--- Fin ---");


Console.WriteLine($"Hay un total de {compositeNumberList.Count()} números compuestos.");
Console.WriteLine($"--- Inicio ---");
Console.WriteLine($"{string.Join("\n", compositeNumberList.OrderBy(p => p).Select(p => p))}");
Console.WriteLine($"--- Fin ---");