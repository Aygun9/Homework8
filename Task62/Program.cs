// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    int temp = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            while (temp <= array.GetLength(0) * array.GetLength(1))
            {
                array[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= array.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > array.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
        }
    }
    return array;
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}






int[,] matrix = CreateRandomArray(4, 4, 1, 17);
PrintArr(matrix);
Console.WriteLine();
