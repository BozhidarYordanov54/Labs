int distanceInMeters = int.Parse(Console.ReadLine());

double distanceInKilometers = distanceInMeters / 1000.0;

Console.WriteLine($"{distanceInKilometers:F2}");