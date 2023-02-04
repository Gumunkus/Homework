/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GenerateArray(int len = 15)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(99, 999);
  }
  return array;
}

int even = 0;

void PrintResult(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    even++;
  }
  {
    foreach (int item in array)
    System.Console.Write($"{item}\t");
  }
}

int[] array = GenerateArray(15);
PrintResult(array);

System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных чисел в массиве {even}");
System.Console.WriteLine();