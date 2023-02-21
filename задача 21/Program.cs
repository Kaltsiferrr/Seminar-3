double x1,x2,y1,y2,z1,z2,S;
Console.WriteLine("Введите значение x первой точки: ");
x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y первой точки: ");
y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение z первой точки: ");
z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение x второй точки: ");
x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y второй точки: ");
y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение z второй точки: ");
z2 = double.Parse(Console.ReadLine());
S = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine("Расстояние между точками равно: "+S);

