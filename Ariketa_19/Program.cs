/*
Idatzi erabiltzaileari zenbaki oso bat eskatu eta zenbaki horretan
oinarrituta jarraian agertzen den patroia idazten duen programa.
Erabili tabulazioa triangelua txukun atera dadin.
*/

Console.WriteLine("Sartu zenbaki oso bat.");
var input = Console.ReadLine();

var num = int.Parse(input);

Console.WriteLine();

var sumValue = 0;
for (int i = 0; i < num; i++)
{
    for (int j = 0; j <= i; j++)
        Console.Write($"{++sumValue}\t");
    Console.WriteLine();
}
