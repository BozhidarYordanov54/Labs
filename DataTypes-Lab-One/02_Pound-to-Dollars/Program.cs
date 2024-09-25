decimal britishPounds = decimal.Parse(Console.ReadLine());

decimal dollars = britishPounds * 1.31m;

Console.WriteLine($"{dollars:F3}");