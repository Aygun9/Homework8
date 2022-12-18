// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
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

void MultiplyMatrix(int[,] matrix, int[,] matrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int n = 0; n < matrix.GetLength(1); n++)
      {
        sum += matrix[i,n] * matrix2[n,j];
      }
      matrix3[i,j] = sum;
    }
  }
}

int[,] matrix = CreateRandomArray(3, 3, 1, 10);
PrintArr(matrix);
Console.WriteLine();
int[,] matrix2= CreateRandomArray(3, 3, 1, 10);
PrintArr(matrix2);
Console.WriteLine();
int[,] matrix3=CreateRandomArray(3,3,1,10);
MultiplyMatrix(matrix,matrix2,matrix3);
PrintArr(matrix3);