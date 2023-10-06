int Composition (int num)
{
    int com = 1;

    for (int i = 1; i <= num; i++)
    {
        com *= i;
    }
    return com;
}

Console.WriteLine("Enter Number:");
int number = Convert.ToInt32(Console.ReadLine());

int result = Composition(number);
Console.WriteLine($"{result}");