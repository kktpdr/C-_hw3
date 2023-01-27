int Promt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return int.Parse(Console.ReadLine());
}


int x2 = Promt("Put X2");
int y2 = Promt("Put Y2");
int z2 = Promt("Put Z2");

int x1 = Promt("Put X1");
int y1 = Promt("Put Y1");
int z1 = Promt("Put Z1");

double Distance(double x1, double x2, double y1, double y2, double z1, double z2 )
{
    double a;
    double b;
    double c;
    a = x2 - x1;
    b = y2 - y1;
    c = z2 - z1;
    return Math.Sqrt(a * a + b * b + c*c);
}

System.Console.WriteLine(Distance(x1, x2, y1, y2, z1, z2));