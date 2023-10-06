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

void InverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] *= -1;
    }
}

int[] array = CreatArrayRbdInt(12, -9, 9);

Console.Write($" -> [");
PrinArray(array);
Console.WriteLine($"]");

InverseArray(array);

Console.Write($" -> [");
PrinArray(array);
Console.WriteLine($"]");