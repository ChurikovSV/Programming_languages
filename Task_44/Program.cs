Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int[] FiboArray (int num)
{
    int[] arr = new int[num];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }

    return arr;
} 

void PrinArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

int[] fiboArray = FiboArray(number);

Console.Write($"[");
PrinArray(fiboArray);
Console.WriteLine($"]");