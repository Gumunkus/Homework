/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int [] array = new int[8];
Console.Write("");
for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 11);
    Console.Write($" {ShowArray (i)}");
 }
Console.Write("");
int ShowArray (int a)
{
    return array[a];
}
