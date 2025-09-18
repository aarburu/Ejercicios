/*
• Edozein erradio emanda, kalkulatu zer area eta perimetro osatuko lukeen
zirkunferentziak.
Formulak:
• Perimetroa: 2πr
• Area: πr²
*/
using System.Globalization;

var validNumber = false;
double radius = 0;
do {
    Console.WriteLine("Sartu zirkunferentziaren erradioa CM-tan.");
    var text = Console.ReadLine();
    validNumber = double.TryParse(text, out radius);
} while (!validNumber);

var perimeter = 2 * Math.PI * radius;
var area = Math.PI * Math.Pow(radius, 2);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"{radius} cm-ko erradioarekin, perimetroa {perimeter}cm da eta area {area} cm² da.");
Console.ResetColor();