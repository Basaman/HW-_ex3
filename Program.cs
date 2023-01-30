//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.Clear();

Console.WriteLine();

Console.Write("Введите кол-во строк матрицы A: ");
int rowsA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов матрицы A: ");
int columnsA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во строк матрицы B: ");
int rowsB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов матрицы B: ");
int columnsB = int.Parse(Console.ReadLine() ?? "");

Console.Clear();

int[,] arrayA = GetArrayA(rowsA, columnsA, 1, 5);
Console.WriteLine("Матрица А: ");
printArray(arrayA);

Console.WriteLine();

int[,] arrayB = GetArrayB(rowsB, columnsB, 1, 5);
Console.WriteLine("Матрица В: ");
printArray(arrayB);

Console.WriteLine();

int[,] GetArrayA(int m, int c, int minValue, int maxValue)
{
    int[,] result = new int[m, c];
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < c; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

int[,] GetArrayB(int m, int c, int minValue, int maxValue)
{
    int[,] result = new int[m, c];
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < c; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

int rowsC = rowsA;
int columnsC = columnsB;
if (columnsA == rowsB)
{
    int[,] arrayC = GetArrayC(rowsC, columnsC);
    int[,] GetArrayC(int m, int c)
    {
        int[,] result = new int[m, c];
        {
            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayB.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int x = 0; x < arrayA.GetLength(1); x++)
                    {
                        result[i, j] = arrayA[i, x] * arrayB[x, j] + sum;
                        sum = result[i, j];
                        result[i, j] = sum;
                    }
                }
            }
        }
        return result;
    }
    Console.WriteLine("Произведение матрицы А и матрицы В равно матрице С: ");
    printArray(arrayC);
}
else Console.WriteLine("Невозможно найти произведение двух матриц!");

void printArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}