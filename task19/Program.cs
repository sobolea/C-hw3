/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out number);

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Неверный ввод");
}
else
{
    if (number / 10000 == number % 10)
    {
        if (number / 1000 % 10 == number % 100 / 10)
        {
            Console.Write($"{number} -> да");
        }
        else 
        {
            Console.Write($"{number} -> нет");
        }
    }
    else 
        {
            Console.Write($"{number} -> нет");
        }
}