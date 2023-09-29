Console.WriteLine("Ahoj ja som virtualny papousek Lora, rad opakujem!");
Console.WriteLine("Napis nieco, co budem opakovat:");

string vstup;
vstup = Console.ReadLine();

string vystup;
vystup = vstup + ",  " + vstup + "!";
Console.WriteLine(vystup);
Console.ReadKey();