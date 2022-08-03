Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int stepen = 3;
int i = 1;

while (i <= n )
{
    Console.WriteLine(Math.Pow(i,stepen));
    i++;

}