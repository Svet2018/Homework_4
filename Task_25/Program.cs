// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int GetNum()
{
    System.Console.WriteLine("Ввведите число:");
    int argument = Convert.ToInt32(Console.ReadLine());
    return argument;
}

int PowNum(int num1, int num2)
{
    int resalt = 1;
    while (num2 > 0)
    {
        resalt = resalt * num1;
        num2--;
    }
    return resalt;
}

void PritnResalt(int resalt)
{
    System.Console.WriteLine($"Результат возведения в натуральную степень - {resalt}");
}

PritnResalt(PowNum(GetNum(), GetNum()));

