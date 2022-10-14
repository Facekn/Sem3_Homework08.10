Console.Write("Введите конечное число диапозона N: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int result = 1;

for (int index = 1; index <= num; index++)
{
    result = result*index;   
}
Console.Write("Произведение чисел диапозона N = "+result);