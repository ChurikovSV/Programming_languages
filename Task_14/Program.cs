int fNumber = 7;
int sNumber = 23;
int number = Convert.ToInt32(Console.ReadLine());

// if (number % fNumber == 0 && number % sNumber == 0)
// {
//     Console.WriteLine($"да");
// }
// else
//     Console.WriteLine($"нет");


bool MulNumber(int num1, int num2, int num3)
{
    return num1 % num2 == 0 && num1 % num3 == 0;
}

bool result = MulNumber(number, fNumber, sNumber);

Console.WriteLine(result ? $"да" : $"Нет");