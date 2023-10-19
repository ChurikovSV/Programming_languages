Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int DesToBinary(int num)
{
    int result = 0;
    int mult = 1;

    while (num > 0)
    {
        result += num % 2 * mult;
        num /= 2;
        mult *= 10;
    }

    return result;
}

Console.WriteLine(DesToBinary(number));