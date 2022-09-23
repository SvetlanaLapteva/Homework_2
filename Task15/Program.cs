// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int day = 16;
string[] week = {"пн","вт","ср","чт","пт","сб","вск"};
    if (day > 0 && day < 8)
{
    Console.WriteLine(week[day-1]);
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}
else 
{
    Console.WriteLine("Ввод неверный");
}
