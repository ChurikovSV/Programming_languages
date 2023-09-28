int fNumber = Convert.ToInt32(Console.ReadLine());
int sNumber = Convert.ToInt32(Console.ReadLine());

int MulNumber (int num1, int num2)
{
    return num1 % num2;
}
int mul = MulNumber(fNumber, sNumber);

if (mul == 0)
{
    Console.WriteLine($"кратно");
}
else
{
    Console.WriteLine($"Не кратно");
}