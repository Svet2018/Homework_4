﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int GetNum()
{
    System.Console.WriteLine("Ввведите число:");
    int argument = Convert.ToInt32(Console.ReadLine());
    return argument;
}

int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

void PrintToConsole(int arg)
{
    System.Console.WriteLine($"Сумма цифр, введенного Вами числа равна - {arg}");
}


PrintToConsole(SumNum(GetNum()));

