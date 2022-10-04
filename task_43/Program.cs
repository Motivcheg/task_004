//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите координаты точки b1: "); 
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1,b1,k2,b2);

void CrossPoint(double k1, double b1, double k2, double b2)
 { 
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
if (k1 == k2)
 Console.Write("Прямые не пересекаются");
 if (k1 == k2 && b1 == b2)
 Console.Write(". Прямые совпадают.");
    else Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
 }  