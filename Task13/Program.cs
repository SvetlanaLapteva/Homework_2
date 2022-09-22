// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 int number;
 Console.WriteLine("Введите число: ");
 number = Convert.ToInt32(Console.ReadLine());
 number = Math.Abs(number);
 if (number > 99)
 {
    while (number > 1000)
    {
    number /=10;
    }
    Console.WriteLine("Третья цифра числа " + number % 10);
 }
    else
{
    Console.WriteLine("Третьей цифры нет");
}
