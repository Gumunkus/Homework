/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
 */

int PromptInt(string mess)
{
    System.Console.Write($"{mess} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[] PrintRowMatrix(int[,] matr, int indexRow)
{
    int[] row = new int[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        row[j] = matr[indexRow, j];
    }
    PrintArray(row);
    return row;
}

int[,] CreateMatrix(
    int rows,
    int columns,
    int minLimit = 0,
    int maxLimit = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(minLimit, maxLimit);
        }
    }
    return matrix;
}


(int[] sumElements, int indexRowMinSum) FindRowMinSumElements(int[,] matrix)
{
    int[] sumElements = new int[matrix.GetLength(0)]; 
    int indexRowMinSum = 0, valueMinSum = 0;   

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumElements[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElements[i] += matrix[i, j];
        }
        if (i == 0)
        {
            valueMinSum = sumElements[i];
            indexRowMinSum = 0;
        }
        else
        {
            if (sumElements[i] < valueMinSum)
            {
                valueMinSum = sumElements[i];
                indexRowMinSum = i;
            }
        }
    }
    return (sumElements, indexRowMinSum);
}


int m = PromptInt("Введите количество строк массива: ");
int n = PromptInt("Введите количество столбцов массива: ");
if (m < 1) { System.Console.WriteLine($"Некорректное количество строк: {m}"); return; }
if (n < 1) { System.Console.WriteLine($"Некорректное количество столбцов: {n}"); return; }

int[,] matrix = CreateMatrix(rows: m, columns: n);
PrintMatrix(matrix);

(int[] sumElements, int indexRowMinSum) = FindRowMinSumElements(matrix);
Console.WriteLine("Массив сумм элементов по строкам матрицы:");
PrintArray(sumElements); System.Console.WriteLine();
Console.WriteLine($"Индекс строки с минимальной суммой: {indexRowMinSum}");

Console.WriteLine("Строка матрицы с минимальной суммой:");
PrintRowMatrix(matrix, indexRowMinSum);