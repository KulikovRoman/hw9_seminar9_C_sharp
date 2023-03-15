// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNumbers(int num1, int num2)
{
    if (num1 > num2) return;

    if (num1 % 2 != 0)
    {
        System.Console.WriteLine($"{num1 + 1}");
        ShowNumbers(num1 + 2, num2 - 1);
    }
    else
    {
        System.Console.WriteLine($"{num1}");
        ShowNumbers(num1 + 2, num2);
    }

}

int number1 = InputInt("Введите минимальное число");
int number2 = InputInt("Введите максимальное число");
ShowNumbers(number1, number2);
