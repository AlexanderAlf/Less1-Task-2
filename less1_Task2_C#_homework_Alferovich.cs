Console.WriteLine("Пожалуйста, введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
Console.WriteLine("Первое число больше второго и является максимальным из этих двух.");
}
if (num1 < num2)
{
Console.WriteLine("Второе число больше первого и является максимальным из этих двух.");
}
if (num1 == num2)
{
Console.WriteLine("Числа равны.");
}