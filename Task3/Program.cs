// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int m, int n)
{

    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int number1 = InputInt("Введите первое число");
int number2 = InputInt("Введите второе число");
int result = AckermannFunction(number1, number2);
System.Console.WriteLine(result);