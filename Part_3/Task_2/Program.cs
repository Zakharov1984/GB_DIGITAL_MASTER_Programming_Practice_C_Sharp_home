Console.Clear();
Console.WriteLine($"Пожалуйста, введите координаты первой точки.");
Console.Write("x1: ");
int x1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("y1: ");
int y1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("z1: ");
int z1 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine($"Пожалуйста, введите координаты второй точки.");
Console.Write("x2: ");
int x2 = Convert.ToInt32( Console.ReadLine() );
Console.Write("y2: ");
int y2 = Convert.ToInt32( Console.ReadLine() );
Console.Write("z2: ");
int z2 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine($"Расстояние между двумя точками - {Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) ):f2}");