/*
Teklatutik testu bat txertatu (ENTER sakatzean amaituko da) eta
pantailan modu bertikalean erakutsi.
*/

var text = "";
do
{
    Console.WriteLine("Sartu textu bat.");
    text = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(text));

foreach (var item in text) 
    Console.WriteLine(item);