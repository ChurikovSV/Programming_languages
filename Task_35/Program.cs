int[] CreatArrayRbdInt(int size,int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int CountToDigit(int[] arr, int min, int max)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max) count ++;
    }

    return count;
}




int[] array = CreatArrayRbdInt(123, 1, 123);

Console.Write($"[");
PrinArray(array);
Console.WriteLine($"]");

int count = CountToDigit(array, 10, 99);
Console.WriteLine($"->{count}");