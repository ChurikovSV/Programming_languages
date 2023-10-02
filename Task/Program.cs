int MaxDigit(int num)
{
    int fDigit = num / 10;
    int sDigit = num % 10;
    return fDigit > sDigit ? fDigit : sDigit;
} 

int number = new Random().Next(10, 99 + 1);

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшее {maxDigit}");

