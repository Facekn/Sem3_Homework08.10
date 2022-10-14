Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
number = Math.Abs(number);
while (number / 10 != 0 || number % 10 != 0)
{
    sum = sum + (number%10);
    number = number/10;   
}
Console.WriteLine("Сумма чисел в в переменной Number = " +sum);