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


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j], 6}");
        }
        Console.WriteLine(" |");

    }
    
}


int[] GetIndexMinEl(int[,] matrix)
{
    int rowMin = 0;
    int columnMin = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMin, columnMin])
            {
                rowMin = i;
                columnMin = j;
            }
        }
    }

    return new int[] {rowMin, columnMin};
}


int[,] DeleteRowColumnMinEl(int[,] matrix, int delrow, int delcolem)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0, m = 0; i < newMatrix.GetLength(0); i++, m++)
    {
        if(i == delrow) m++;
        for (int j = 0, n = 0; j < newMatrix.GetLength(1); j++, n++)
        {
            if(j == delcolem) n++;
            newMatrix[i, j] = matrix[m, n];

        }
    }

    return newMatrix;
}


int[,] matrix2d = CreatMatrixRbdInt(5, 5, 1, 10);
PrintMatrix(matrix2d);
Console.WriteLine();

int[] getIndexMinEl = GetIndexMinEl(matrix2d);
int[,] deleteRowColumnMinEl = DeleteRowColumnMinEl(matrix2d, getIndexMinEl[0], getIndexMinEl[1]);
PrintMatrix(deleteRowColumnMinEl);