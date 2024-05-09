using static Lab5._1Lib.ClassLib1;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Country[] arrCountries;
Console.Write("Введіть кількість країн: ");
int cntCountries = int.Parse(Console.ReadLine());
arrCountries = new Country[cntCountries];
for (int i = 0; i < cntCountries; i++)
{
    Console.Write("Введіть назву країни: ");
    string sName = Console.ReadLine();
    Console.Write("Введіть назву столиці: ");
    string sCapital = Console.ReadLine();
    Console.Write("Введіть кількість населення: ");
    string sPopulation = Console.ReadLine();
    Console.Write("Введіть площу країни, кв. км: ");
    string sArea = Console.ReadLine();
    Console.Write("Введіть мову(-и) країни: ");
    string sLanguage = Console.ReadLine();
    Console.Write("Чи є країна членом ООН? (y-так, n-ні): ");
    ConsoleKeyInfo keyIsUNMember = Console.ReadKey();
    Console.WriteLine();
    Console.Write("Рівень розвитку країни: ");
    string sDevelopmentLevel = Console.ReadLine();
    Console.WriteLine();
    Country theCountry = new Country();
    theCountry.Name = sName;
    theCountry.Capital = sCapital;
    theCountry.Population = long.Parse(sPopulation);
    theCountry.Area = double.Parse(sArea);
    theCountry.Language = sLanguage;
    theCountry.IsUNMember = keyIsUNMember.Key == ConsoleKey.Y ? true : false;
    theCountry.DevelopmentLevel = sDevelopmentLevel;
    arrCountries[i] = theCountry;
}
foreach (Country c in arrCountries)
{
    Console.WriteLine();
    Console.WriteLine(" ");
    Console.WriteLine("Дані про країну {0}", c.Name);
    Console.WriteLine();
    Console.WriteLine("Столиця: " + c.Capital);
    Console.WriteLine("Кількість населення: " + c.Population.ToString());
    Console.WriteLine("Площа: " + c.Area.ToString("0.000"));
    Console.WriteLine("Мова(-и): " + c.Language);
    Console.WriteLine(c.IsUNMember ? "Країна є членом ООН" : "Країна не є членом ООН");
    Console.WriteLine("Рівень розвитку: " + c.DevelopmentLevel);
    Console.WriteLine("Густина населення: " + c.PopulationDensity.ToString("0.00"));
}
Console.ReadKey();
