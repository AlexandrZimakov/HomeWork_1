int GetCoordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

int x1 = GetCoordinate("x", "A");
int y1 = GetCoordinate("y", "A");
int z1 = GetCoordinate("z", "A");
int x2 = GetCoordinate("x", "B");
int y2 = GetCoordinate("y", "B");
int z2 = GetCoordinate("z", "B");

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
