double Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()); 
    return a;
}
double CountX(double b1, double k1,double b2, double k2)
{
    return (-b2 + b1)/(-k1 + k2);

}
double CountY(double k2, double x, double b2)
{
    return k2 * x + b2;
}
Console.Clear();
double b1 = Prompt("введите значение b1:");
double k1 = Prompt("введите число k1:");
double b2 = Prompt("введите значение b2:");
double k2 = Prompt("введите число k2:");

double x = CountX(b1,k1,b2,k2);
double y = CountY(k2,x,b2);

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y:{y} ");