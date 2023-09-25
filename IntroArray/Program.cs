int[] array = {9, 10, 25};

int n = array.Length;
int find = 10;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}