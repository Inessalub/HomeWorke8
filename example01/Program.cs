// Показать натуральные числа от M до N, N и M заданы
// Найти сумму элементов от M до N, N и M заданы
// Написать программу вычисления функции Аккермана
// Написать программу возведения числа А в целую стень B
// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
PrintNumber(4, 17);