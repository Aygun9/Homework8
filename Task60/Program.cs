//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandomArray(int rows, int columns, int blocks, int leftRange, int rightRange)
{
    int[,,] array = new int[rows, columns, blocks];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < blocks; k++)
            {
                array[i, j, k] = new Random().Next(leftRange, rightRange);

                count= array[i, j, k];
                count++;

            }
        }
    }
    return array;
}


void PrintArr(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix = CreateRandomArray(2, 2, 2, 10, 100);
PrintArr(matrix);