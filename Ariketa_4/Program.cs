/*
Mezu elektroniko bat sartzeko eskatzen da, eta pantailaren bidez
erakusten da posta elektronikoa zuzena den (formatua: xxx@xxx.xxx).
*/

using System.Text.RegularExpressions;

bool validEmail = false;
do
{
    Console.WriteLine("Sartu email helbide bat.");
    var emailAddress = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(emailAddress))
    {
        var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        validEmail = regex.Match(emailAddress).Success;
        Console.ForegroundColor = ConsoleColor.Blue;
        if (!validEmail)
            Console.WriteLine($"{emailAddress} ez da email helbide bat.");
        else
            Console.WriteLine($"{emailAddress} helbide zuzena da.");
        Console.ResetColor();
    }
} while (!validEmail);