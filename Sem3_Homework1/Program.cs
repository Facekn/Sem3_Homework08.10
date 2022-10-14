Console.Write("Введите конечное число диапазона: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
while (i<=a)
{
    
        Console.WriteLine("Куб числа - " +i+ " = " +i*i*i);
    i++;
}
