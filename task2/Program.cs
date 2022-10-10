Console.WriteLine(" Введите координаты 1 точки");

int x1=Convert.ToInt32(Console.ReadLine());
int y1=Convert.ToInt32(Console.ReadLine());
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите координаты 2 точки");

int x2=Convert.ToInt32(Console.ReadLine());
int y2=Convert.ToInt32(Console.ReadLine());
int z2=Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"Длинна отрезка - {Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1))}");