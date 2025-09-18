/*
Zenbaki natural bat eta edozein karaktere emanda, laukizuzen
bat, triangelu bat eta triangelu alderantzikatu bat marraztu.
ADIBIDEA (zenbakia 5 bada eta karakterea *):

*****   *       *****
*****   **      ****  
*****   ***     ***
*****   ****    **
*****   *****   *
*/

Console.WriteLine("Sartu zenbaki oso bat.");
var input = Console.ReadLine();

var num = int.Parse(input);

Console.WriteLine();
Console.WriteLine("Laukia:");

//Laukia
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
        Console.Write("*");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Triangelua:");

//Triangelua
for (int i = 0; i < num; i++)
{
    for (int j = 0; j <= i; j++)
        Console.Write("*");
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("Triangelu alderantzizkatua:");

//Triangelu alderantzizkatua
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num - i; j++)
        Console.Write("*");
    Console.WriteLine();
}