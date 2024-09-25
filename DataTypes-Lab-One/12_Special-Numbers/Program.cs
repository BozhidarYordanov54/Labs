// int count = int.Parse(Console.ReadLine());

// for (int i = 1; i <= count; i++)
// {
//     int sum = 0;
//     int currentNum = i;

//     while (currentNum > 0)
//     {
//         sum += currentNum % 10;
//         currentNum = currentNum / 10;
//     }

//     bool isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
//     Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
// }

int dayOfWeek = int.Parse(Console.ReadLine());

string[] daysOfWeek = new string[]
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

if(daysOfWeek.Length < dayOfWeek)
{
    Console.WriteLine("Invalid day!");
    return;
}

Console.WriteLine($"{daysOfWeek[dayOfWeek - 1]}");