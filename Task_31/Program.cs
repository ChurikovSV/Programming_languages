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

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
        
    }

    return new int[]{sumPositive, sumNegative};

}

int GetSumPositive(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int GetSumNegative(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }

    return sum;
}


int[] array = CreatArrayRbdInt(12, -9, 9);

Console.Write($" -> [");
PrinArray(array);
Console.WriteLine($"]");

int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);

Console.WriteLine($"Positive -> {sumPositiveNegativeElem[0]}, Negative -> {sumPositiveNegativeElem[1]}");

int sumPositive = GetSumPositive(array);
int sumNegativeElem = GetSumNegative(array);

Console.WriteLine($"Positive -> {sumPositive}, Negative -> {sumNegativeElem}");

