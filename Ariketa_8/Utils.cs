public static class Utils {
    public static string ConvertToRoman(int numero)
    {
        var result = "";

        // Limito los numeros a 3999, pero descomentando y añadiendo elementos a la tupla podría subirse a cualquier valor.
        if (numero < 1 || numero > 3999999)
            throw new ArgumentOutOfRangeException("1 eta 3999999 arteko zenbaki oso bat izan behar du.");

        var simbolos = new List<(int valor, string simbolo)>
        {
            (1000000, "M̅"),
            (500000, "D̅"),
            (100000, "C̅"),
            (50000, "L̅"),
            (10000, "X̅"),
            (5000, "V̅"),
            (1000, "M"),
            (500, "D"),
            (100, "C"),
            (50, "L"),
            (10, "X"),
            (5, "V"),
            (1, "I")
        };

        foreach (var item in simbolos)
        {
            var numericValue = item.valor;
            var repetitions = numero / numericValue;

            var indexOfValor = simbolos.FindIndex(t => t.valor == numericValue);

            // Al comprobar los numeros de la tupla, los que empiezan por 5 tienen algunas diferencias.
            // Gestiono las que NO empiezan por 5
            if (!item.valor.ToString().StartsWith("5"))
            {
                if (repetitions > 3)
                    result += item.simbolo + simbolos[indexOfValor - 1].simbolo;
                else if (repetitions > 0)
                    for (var i = 0; i < repetitions; i++)
                        result += item.simbolo;

                numero -= numericValue * repetitions;
            }
            // Gestiono las que empiezan por 5 (y existan al menos 1 vez dentro del número.
            // Ejemplo: En 63, existe una L pero no una V, en el caso de la V no entraría en este bloque.
            else if (repetitions > 0)
            {
                var nextRomanNumberValue = simbolos[indexOfValor + 1].valor;
                var repetitions2 = (numero - numericValue) / nextRomanNumberValue;

                if (repetitions2 > 3)
                    result += simbolos[indexOfValor + 1].simbolo + simbolos[indexOfValor - 1].simbolo;
                else
                    result += item.simbolo + string.Concat(Enumerable.Repeat(simbolos[indexOfValor + 1].simbolo, repetitions2));

                numero -= numericValue + nextRomanNumberValue * repetitions2;
            }
        }
        return result;
    }
}