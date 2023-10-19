void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 4}", matrix[i,j]);
        }
        Console.WriteLine();
    }
}


int[,] CreatMatrixRbdInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


int[] MartixToArray(int[,] matrix)
{
    int k = 0;
    int[] array = new int[matrix.Length];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}


void CountDictory(int[] array)
{
    int temp = 1;
    int currentName = array[0];

    for (int i = 1; i < array.length; i++)
    {
        if (array[i] == currentName)
        {
            count++;
        }
        else
        {
            Console.Write($"{correntName} > {temp}");
            currentName = array[i];
            count = 1;
        }

    }
}



int[,] matrix2d = CreatMatrixRbdInt(3, 4, 1, 10);
PrintMatrix(matrix2d);
Console.WriteLine();

int[] martixToArray = MartixToArray(matrix2d);
Array.Sort(martixToArray);

