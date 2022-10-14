 Console.Write("Введите конечное число диапазона N: ");
int num = int.Parse(Console.ReadLine() ?? "0");
double cub = 0;
for (int i = 1; i <= num; i++)
{
cub = Math.Pow(i, 3);
    if ((cub%10)%2==0) 
    {
        Console.Write(cub+ " ");
    } 
}
    
