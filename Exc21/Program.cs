int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
int stepen = 2;
double n = Math.Sqrt((Math.Pow(x2-x1, stepen)) + (Math.Pow(y2-y1, stepen)) + (Math.Pow(z2-z1, stepen)));
Console.WriteLine(n);
