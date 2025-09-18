/*
Edozein data emanda, formatu honekin: uuuu/hh/ee, adibidez:
1980/05/18, pantailan dagokion asteko eguna agertzen da; aurreko
kasurako, hau izango litzateke pantailako irteera: Igandea
*/
Console.WriteLine("Sartu data bat 'uuuu/hh/ee' formatuan.");
var inputDate = Console.ReadLine();
var format = "yyyy/MM/dd";
var dDate = DateTime.ParseExact(inputDate, format, System.Globalization.CultureInfo.InvariantCulture);
var iDay = (int)dDate.DayOfWeek;

var EgunakDictionary = new Dictionary<int, string>()
{
    {0, "Igandea"},
    {1, "Astelehena"},
    {2, "Asteartea"},
    {3, "Asteazkena"},
    {4, "Osteguna"},
    {5, "Ostirala"},
    {6, "Larunbata"}
};

Console.WriteLine($"{inputDate}-ri dagokion eguna {EgunakDictionary[iDay]} da.");