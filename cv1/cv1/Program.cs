
Console.WriteLine("Vítajte v kalkulačke: ");
Console.WriteLine("Zadajte prvé číslo: ");
string s= Console.ReadLine();
float a= float.Parse(s);
Console.WriteLine("Zadajte druhé číslo: ");
string d = Console.ReadLine();
float b = float.Parse(d);
float sucet, sucin, rozdiel, podiel;
sucet = a + b;
sucin = a * b;
rozdiel = a - b;
podiel = a / b;
Console.WriteLine("Súčet je: ");
Console.WriteLine(sucet);
Console.WriteLine("Rozdiel je: ");
Console.WriteLine(rozdiel);
Console.WriteLine("Súčin je: ");
Console.WriteLine(sucin);
Console.WriteLine("Podiel je: ");
Console.WriteLine(podiel);

Console.ReadKey();