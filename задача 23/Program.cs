Console.Write("Введите число: ");
double n = double.Parse(Console.ReadLine());
if (n<0)
{
    for (double i=n;i<0;i+=1)
    {
        Console.Write(Math.Pow(i,3)+"\t");
    }
}
else
{
    for (int i=1;i<=n;i++)
    {
        Console.Write(Math.Pow(i,3)+"\t");
    }
}
