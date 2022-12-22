/*  Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */

int b1, b2, k1, k2;
Console.Write("Enter the value of the first vertex of the first line: ");
int.TryParse(Console.ReadLine()!, out b1);
Console.Write("Enter the value of the second vertex of the first line: ");
int.TryParse(Console.ReadLine()!, out b2);
Console.Write("Enter the value of the first vertex of the second line: ");
int.TryParse(Console.ReadLine()!, out k1);
Console.Write("Enter the value of the second vertex of the second line: ");
int.TryParse(Console.ReadLine()!, out k2);

double x=(double)(b2-b1)/(k1-k2);
double y=(double)k1*x+b1;
Console.WriteLine();
Console.Write($"The intersection point of two straight lines of the given value of the points of their vertices will be the vertex ({x};{y})");
