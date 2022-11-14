//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

int a = GetNumber("Введите число a: ");
int b = GetNumber("Введите число b: ");
int N = GetNumber("Введите количество раз, сколько раз мы выведем число: ");
int GetNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int Metod(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Metod(x, y, num - 1) + Metod(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Metod(a, b, i) + " ");
}
