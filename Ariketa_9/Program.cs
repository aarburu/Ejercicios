/*
 Gutxienez 10 hitzetako edozein testu txertatu ondoren, pantailan
 agertuko da testuan zenbat aldiz agertzen den “i” hizkia.
 ********************************************************************/

var ValidText = true;
var characterCount = 0;
var character = "";
do
{
    Console.WriteLine("Sartu 10 hitzeko textu bat.");
    var text = Console.ReadLine();

    ValidText = !string.IsNullOrWhiteSpace(text);

    //Comprobamos el número de palabras que tiene el texto
    if (ValidText)
    {
        //Hago el trim para quitar los espacios al inicio del texto, y como tengo en cuenta las palabras que vienen despues 
        //de un espacio al realizar la cuenta, añado +1 al contador porque la primera palabra nunca se va a tener en cuenta.
        int count = text!.Trim().Where((c, i) => char.IsWhiteSpace(c) &&
                                    (i > 0 && !char.IsWhiteSpace(text![i - 1]) ||
                                    i < text!.Length - 1 && !char.IsWhiteSpace(text[i + 1]))).Count();

        count++;

        ValidText = count >= 10;
    }

    if (ValidText)
    {
        var ValidChar = true;
        do
        {
            Console.WriteLine("Sartu karaktere bat textuan kontatzekoa.");
            character = Console.ReadLine();

            ValidChar = !string.IsNullOrWhiteSpace(character) && character!.Length == 1;
        } while (!ValidChar);
        characterCount = text!.Count(f => f.ToString().ToUpper() == character![0].ToString().ToUpper());
    }
} while (!ValidText);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"'{character}' karakterea {characterCount} aldiz agertzen da.");
Console.ResetColor();