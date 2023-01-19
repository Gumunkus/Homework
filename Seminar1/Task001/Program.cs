/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


int max = 0;
int min = 0;

Console.WriteLine("Введите первое число  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число  ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber){
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
System.Console.WriteLine($" большее число = {max} , меньшее число = {min}");