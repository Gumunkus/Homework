/*  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GenerateArray(int len)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-100, 100);
  }
  return array;
}

void PrintArray(int[] array)
{
  int sum = 0;
  System.Console.WriteLine();
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write(array[i] + $"\t");
    if (i % 2 > 0)
      sum = sum + array[i - 1];
    }
       System.Console.WriteLine();
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, соcтавляет {sum} ");
    System.Console.WriteLine();
  }

int[] array = GenerateArray(10);
PrintArray(array);