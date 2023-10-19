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


int[] CopyArray(int[] arr)
{
    int[] arrTmp = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        arrTmp[i] = arr[i];
    }

    return arrTmp;
}



int[] array = CreatArrayRbdInt(5, 1, 10);
int[] copyArray = CopyArray(array);

Console.Write($"[");
PrinArray(array);
Console.WriteLine($"]");

Console.Write($"[");
PrinArray(copyArray);
Console.WriteLine($"]");