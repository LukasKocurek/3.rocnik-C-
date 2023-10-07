Console.WriteLine("Zadaj prve cislo: ");
string s = Console.ReadLine();
float a = float.Parse(s);

Console.WriteLine("Zadaj druhe cislo: ");
string t=Console.ReadLine();
float b=float.Parse(t);

float sucet, rozdiel, sucin, podiel;
sucet = a + b;
rozdiel = a - b;
sucin = a * b;
podiel = a / b;

Console.WriteLine("Sucet je: "+sucet);
Console.WriteLine("Rozdiel je: "+rozdiel);
Console.WriteLine("Sucin je: "+sucin);
Console.WriteLine("Podiel je: "+podiel);

Console.ReadKey();