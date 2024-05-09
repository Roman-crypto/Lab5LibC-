using Lab5Lib;
using static Lab5Lib.ClassLib;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Town[] arrTowns;
Console.Write("Введіть кількість міст: ");
int cntTowns = int.Parse(Console.ReadLine());
arrTowns = new Town[cntTowns];
for (int i = 0; i < cntTowns; i++)
{
    Console.Write("Введіть назву міста: ");
    string sName = Console.ReadLine();
    Console.Write("Введіть назву країни: ");
    string sCountry = Console.ReadLine();
    Console.Write("Введіть назву регіону: ");
    string sRegion = Console.ReadLine();
    Console.Write("Введіть кількість населення: ");
    string sPopulation = Console.ReadLine();
    Console.Write("Введіть річний дохід: ");
    string sYearIncome = Console.ReadLine();
    Console.Write("Введіть площу, кв. км: ");
    string sSquare = Console.ReadLine();
    Console.Write("Чи є у місті порт? (y-так, n-ні): ");
    ConsoleKeyInfo keyHasPort = Console.ReadKey();
    Console.WriteLine();
    Console.Write("Чи є у місті аеропорт? (y-так, n-ні): ");
    ConsoleKeyInfo keyHasAirport = Console.ReadKey();
    Console.WriteLine();
    Console.WriteLine();
    Town theTown = new Town();
    theTown.Name = sName;
    theTown.Country = sCountry;
    theTown.Region = sRegion;
    theTown.Population = int.Parse(sPopulation);
    theTown.YearIncome = double.Parse(sYearIncome);
    theTown.Square = double.Parse(sSquare);
    theTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false;
    theTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;
    arrTowns[i] = theTown;
}
foreach (Town t in arrTowns)
{
    Console.WriteLine();
    Console.WriteLine(" ");
    Console.WriteLine("Дані про місто {0}", t.Name);
    Console.WriteLine();
    Console.WriteLine("Країна: " + t.Country);
    Console.WriteLine("Регіон: " + t.Region);
    Console.WriteLine("Кількість населення: " + t.Population.ToString());
    Console.WriteLine("Річний дохід: " + t.YearIncome.ToString("0.00"));
    Console.WriteLine("Площа: " + t.Square.ToString("0.000"));
    Console.WriteLine(t.HasPort ? "У місті є порт" : "У місті нема порту");
    Console.WriteLine(t.HasAirport ? "У місті є аеропорт" : "У місті нема аеропорту");
    Console.WriteLine();
    Console.WriteLine("Середній річний дохід на одного громадянина: " + t.yearIncomePerInhabitant.ToString("0.00"));
}
Console.ReadKey();

