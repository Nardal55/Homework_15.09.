Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Result(int argX1, int argY1, int argZ1, int argX2, int argY2, int argZ2)
{
double lenght = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2) + Math.Pow((argZ2 - argZ1), 2));
return lenght;
}
double result = Result(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));

