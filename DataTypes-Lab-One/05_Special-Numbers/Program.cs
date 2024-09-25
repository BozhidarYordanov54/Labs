int countOfNumbers = int.Parse(Console.ReadLine());

for (int i = 1; i <= countOfNumbers; i++)
{
    int currentNumber = i;

    int sumOfDigits = 0;
    
    if(currentNumber > 9)
    {
        while (currentNumber > 0)
        {
            sumOfDigits += currentNumber % 10;
            currentNumber /= 10;
        }
    }
    else
    {
        sumOfDigits = currentNumber;
    }

    bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;

    Console.WriteLine($"{i} -> {isSpecial} {isSpecial ? $"\u2705" : "\u274C"}"); 
}