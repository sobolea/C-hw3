/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int xa, xb, ya, yb, za, zb;
Console.Write("Введите координату x точки А: ");
int.TryParse(Console.ReadLine(), out xa);
Console.Write("Введите координату y точки А: ");
int.TryParse(Console.ReadLine(), out ya);
Console.Write("Введите координату z точки А: ");
int.TryParse(Console.ReadLine(), out za);
Console.Write("Введите координату x точки B: ");
int.TryParse(Console.ReadLine(), out xb);
Console.Write("Введите координату y точки B: ");
int.TryParse(Console.ReadLine(), out yb);
Console.Write("Введите координату z точки B: ");
int.TryParse(Console.ReadLine(), out zb);

double rast;
rast = Math.Round(Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb)), 2);
Console.Write($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}) -> {rast}");
