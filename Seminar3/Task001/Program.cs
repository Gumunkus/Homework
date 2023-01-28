/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Не использовать строки
14212 -> нет
12821 -> да
23432 -> да */

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите пятизначное число");

if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}