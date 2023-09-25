int MaxDigit(int num)
{
    int fDigit = num / 10;
    int sDigit = num % 10;
    return fDigit > sDigit ? fDigit : sDigit;
} 

int number = new Random().Next(10, 99 + 1);
// int fDigit = number / 10;
// int sDigit = number % 10;

// if(fDigit > sDigit)
// {
//     Console.WriteLine($"Наибольшее число {fDigit}");

// }
// else {
//     Console.WriteLine($"Наибольшее число {sDigit}");
// }

// int maxDigit = fDigit > sDigit ? fDigit : sDigit;

// Console.WriteLine($"Наибольшее {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшее {maxDigit}");

