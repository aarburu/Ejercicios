/*
Euro, libera esterlina eta dolar estatubatuarren bihurgailu bat
sortzea. Adibidez, teklatutik 5€ jartzen bada, emaitza (gaurko
egunarekin) izango litzateke: $5,54 – £4,22.

1€ = $1,17 = £0,86

*/

Console.InputEncoding = System.Text.Encoding.Default;
Console.OutputEncoding = System.Text.Encoding.Default;

Console.WriteLine("Sartu bihurtu nahi duzun kantitatea txanponaren sinboloarekin (Euroaren kasuan E sartu).");
var input = Console.ReadLine();
List<char> symbols = new List<char> { '€', '$', '£', 'E' };
var symbolPosition = input.Trim().IndexOfAny(symbols.ToArray());
var currencySymbol = input.Skip(symbolPosition).Take(1).FirstOrDefault().ToString();
input = input.Replace(currencySymbol, "").Trim();
var inputValue = double.Parse(input);

var euroValue = inputValue;
var dollarValue = inputValue;
var GBPValue = inputValue;
switch (currencySymbol)
{
    case "E": case "€":
        dollarValue = inputValue * 1.17;
        GBPValue = inputValue * 0.86;
        break;
    case "$":
        euroValue = inputValue / 1.17;
        GBPValue = inputValue * 0.86 / 1.17;
        break;
    case "£":
        euroValue = inputValue / 0.86;
        dollarValue = inputValue * 1.17 / 0.86;
        break;
    default:
        break;
}

Console.WriteLine($"${dollarValue}, {euroValue}€, £{GBPValue}");

