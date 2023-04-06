//Напишите программу, которая будет выдавать 
//день недели по заданному номеру.
Console.Clear();
Console.Write("Ввеите цифру соответствующую дню недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());

while(numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неправильный номер");
    Console.WriteLine("Введите цифру соответствующую дню недли");
    numberDayOfWeek = int.Parse(Console.ReadLine());
}if(numberDayOfWeek == 1){
    Console.WriteLine("Понедельник.");
}if(numberDayOfWeek == 2){
    Console.WriteLine("Вторник.");
}if(numberDayOfWeek == 3){
    Console.WriteLine("Среда.");
}if(numberDayOfWeek == 4){
    Console.WriteLine("Четверг.");
}if(numberDayOfWeek == 5){
    Console.WriteLine("Пятница.");
}if(numberDayOfWeek == 6){
    Console.WriteLine("Суббота.");
}if(numberDayOfWeek == 7){
    Console.WriteLine("Воскресенье.");
}