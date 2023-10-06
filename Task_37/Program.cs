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

int[] Composition(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    
    int[] arrNew = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    if (arr.Length % 2 != 0) arrNew[arrNew.Length - 1] = arr[arr.Length /2];
    return arrNew;
}


void PrinArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreatArrayRbdInt(4, 1, 9);

Console.Write($"[");
PrinArray(array);
Console.WriteLine($"]");

int[] composition = Composition(array);
PrinArray(composition);