//  y = k1 * x + b1, y = k2 * x + b2;
//k1(b2-b1)/(k1-k2)+b1

Console.Clear();

Console.Write("ПОжалуйста, введите первое значение b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("ПОжалуйста, введите второе значение k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("ПОжалуйста, введите третье значение b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("ПОжалуйста, введите четвертое значение k2: ");
double k2 = int.Parse(Console.ReadLine());

void getPointOfIntersection(double b1, double k1, double b2, double k2) {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1; 
    Console.WriteLine($"точка пересечения: ({x}; {y})");
}

getPointOfIntersection(b1, k1, b2, k2);

//2 -4