// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Введите значение t");
    int t = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение x");
    int x = int.Parse(Console.ReadLine());
    double k = 7*Math.Pow(t,2)+3*Math.Sin(Math.Pow(x,3))+9.2;
    Console.WriteLine($"Ответ число K = {k:F2}");
}
catch
{
}