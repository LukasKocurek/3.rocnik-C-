Console.WriteLine("Vitaj v kalkuacke.");
int p;
do {
    Console.WriteLine("Zadaj prve cislo: ");
    float a = float.Parse(Console.ReadLine());

    Console.WriteLine("Zadaj druhe cislo: ");
    float b = float.Parse(Console.ReadLine());

    Console.WriteLine("Napis cislo operacie,ktoru chces pouzit: ");
    Console.WriteLine("1. Sucet");
    Console.WriteLine("2. Rozdiel");
    Console.WriteLine("3. Sucin");
    Console.WriteLine("4. Podiel");

    int operacia = int.Parse(Console.ReadLine());

    float sucet, rozdiel, sucin, podiel;
    sucet = a + b;
    rozdiel = a - b;
    sucin = a * b;
    podiel = a / b;

    switch (operacia)
    {
        case 1:
            Console.WriteLine("Sucet je: " + sucet);
            break;
        case 2:
            Console.WriteLine("Rozdiel je: " + rozdiel);
            break;
        case 3:
            Console.WriteLine("Sucin je: " + sucin);
            break;
        case 4:
            Console.WriteLine("Podiel je: " + podiel);
            break;
    }
    if (operacia > 4)
        Console.WriteLine("Nezadal si spravnu operaciu.");

    Console.WriteLine("Ak chces pokracovat, zadaj cislo 1, ak nie, hocico ine");
    p = int.Parse(Console.ReadLine());

} while (p == 1);

Console.WriteLine("Dakujem za pouzitie kalkulacky.");
Console.ReadKey();



