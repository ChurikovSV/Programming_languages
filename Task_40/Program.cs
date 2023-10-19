Console.Write("Введите первую сторону ");
int fNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую сторону ");
int sNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью сторону ");
int tNumber = Convert.ToInt32(Console.ReadLine());


bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b; 
}

bool isExistTriangle = IsExistTriangle(fNumber, sNumber, tNumber);

Console.WriteLine(isExistTriangle ? "Сущесвует": "Не существует");
