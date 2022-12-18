// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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



int[,] matrix = CreateRandomArray(4, 4, 1, 10);
PrintArr(matrix);
Console.WriteLine();
int SumRowElements(int[,] matrix, int i)
{
  int sumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumRow += matrix[i,j];
  }
  return sumRow;
}
int minSumRow = 0;
int sumRow = SumRowElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(matrix, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}
System.Console.WriteLine($" min sum Row is {minSumRow+1} - ({sumRow})");
