// Написать программу возведения числа А в целую стень B

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int Degree(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (Degree(numberA, numberB - 1));
}

Console.WriteLine($"Возведение числа {numberA} в степень {numberB}: {Degree(numberA, numberB)}");
