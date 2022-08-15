/*Задача 21
/
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите кординату точки А  по оси oX:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату точки А по оси oY:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату точки А по оси oZ:");
int zA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите кординату точки В  по оси oX:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату точки В по оси oY:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату точки B по оси oZ:");
int zB = Convert.ToInt32(Console.ReadLine());

double LenghAB = Math.Sqrt(Math.Pow(xB-xA,2) + (Math.Pow(yB-yA,2)) + (Math.Pow(zB-zA,2)));

Console.WriteLine($" Расстояние: {Math.Round(LenghAB,2)}");