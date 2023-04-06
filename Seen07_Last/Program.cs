//Трехзначное на вход, на выход последня цифра числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
while(number < 100 || number > 999)
{
    Console.WriteLine("Введено неверное число.");
    Console.Write("Введите *ТРЕХЗНАЧНОЕ* число: ");
    number = int.Parse(Console.ReadLine());
}
int y = number % 10;
Console.Write("Последняя цифра: .. ");
Console.Write($"{y}");