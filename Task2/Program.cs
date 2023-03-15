// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8-> 30

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int num1, int num2)
{
    int sum = 0;
    if (num1 > num2) return 0;
    sum = sum + num1;
    return sum + SumNumbers(num1 + 1, num2);
}

int number1 = InputInt("Введите минимальное число");
int number2 = InputInt("Введите максимальное число");
int sum = SumNumbers(number1, number2);
System.Console.WriteLine(sum);