// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение

    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalRow(int number, int n)
{
    if (number <= n-1)
    {
        return;
    }
    ShowNaturalRow(number-1, n);
    if (number%2 ==0)
    System.Console.WriteLine(number);
    
}

int n = Prompt("Введите число 1 : ");
int number = Prompt("Введите число 2 : ");
ShowNaturalRow(number, n);


