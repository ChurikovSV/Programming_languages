Console.WriteLine("Enter Number:");
int number = Convert.ToInt32(Console.ReadLine());

int CountNumber(int num)
{
    if(num == 0) return 1;
    
    int i = 0;

    while (num != 0)
    {
        num /= 10;
        i++;
    }
    return i;
}

int result = CountNumber(number);
Console.WriteLine($"{result}");
