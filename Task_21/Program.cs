// задача 21. Напишите программу, которая принимает на входд координаты двух точек и находит расстояние между ними в 3D пространства
using static System.Console;
Clear();
WriteLine("Введите координату точки А (X1, Y1, Z1)");
Write("X1 = ");
int x1 = int.Parse(ReadLine());
Write("Y1 = ");
int y1 = int.Parse(ReadLine());
Write("Z1 = ");
int z1 = int.Parse(ReadLine());
WriteLine("Введите координату точки B (X2, Y2, Z2)");
Write("X2 = ");
int x2 = int.Parse(ReadLine());
Write("Y2 = ");
int y2 = int.Parse(ReadLine());
Write("Z2 = ");
int z2 = int.Parse(ReadLine());
double L = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
WriteLine($"Расстояние между точками = {L:f2}");