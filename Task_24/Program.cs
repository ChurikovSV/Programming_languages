int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Enter Number:");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Incorrect input!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Summ Number {number}: {sumNumbers}");