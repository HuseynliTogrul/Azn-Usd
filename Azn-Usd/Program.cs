using Azn_Usd;

Console.WriteLine("value daxil et:");
double.TryParse(Console.ReadLine(), out double request);

Azn azn = new Azn(request);
Console.WriteLine($"Azn:{azn.Value}");

Usd usd = azn;
Console.WriteLine($"Usd:{usd.Value}");