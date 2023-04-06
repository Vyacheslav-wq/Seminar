//Найдите числа от - N до N.
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
for (int n = -a; n < a + 1; n++)
{
    Console.Write($"{n} ");
}