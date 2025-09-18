/*
Pasahitz bat sartzeko eskatzen da, eta pantailan erakusten da ea segurua
den ala ez → Pasahitz segurua: gutxienez 8 karaktere eta gutxienez izaera
berezi bat du, adibidez: #, ∞, ÷
, $,...
*/

using System.Text.RegularExpressions;

bool validPassword = false;
do
{
    Console.WriteLine("Sartu pasahitz bat. Gutxienez 8 karaktere eta izaera berezi bat izan behar du");
    var password = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(password))
    {
        var regex = new Regex(@"(^(?=.*[a-zA-Z0-9}(?=.*[!@#$%^&*(),.?:{}_|<>])).{8,50}");
        validPassword = regex.Match(password).Success;
        Console.ForegroundColor = ConsoleColor.Blue;
        if (!validPassword)
            Console.WriteLine($"{password} ez da pasahitz segurua.");
        else
            Console.WriteLine($"{password} pasahitz segurua da.");
        Console.ResetColor();
    }
} while (!validPassword);