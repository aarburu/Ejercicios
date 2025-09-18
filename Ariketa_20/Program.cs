/*
Idatzi erabiltzaileari zenbaki oso bat eskatu eta zenbaki horretan oinarrituta jarraian
agertzen den patroia idazten duen programa.
*/

Console.WriteLine("Sartu zenbaki oso bat.");
var input = Console.ReadLine();

var num = int.Parse(input);

Console.WriteLine();
var fullLength = num * 2;
for (int i = 0; i < fullLength; i++)
{
    for (int j = 0; j < i && i <= num; j++)
        Console.Write("*");
    for (int j = 0; j < i-num && i > num; j++)
        Console.Write(" ");
    for (int j = num; j > i-num && i > num; j--)
        Console.Write("*");
    Console.WriteLine();
}