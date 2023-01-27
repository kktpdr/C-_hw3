int Promt(string msg)
{
    System.Console.Write($"{msg}: ");
    return int.Parse(Console.ReadLine());
}

int x = Promt("Put a number");
for (int i = 1; i < x+1; i++)
{
    double a = Math.Pow(i, 3);
    System.Console.WriteLine($"Third degree of {i} is {a}");
}