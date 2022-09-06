// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalRow(int start, int end)
{

    if (start == end)
    {
        return end;
    }    
   

    else return start + SumNaturalRow(start+1, end);
      
    
}

int n = Prompt("Введите число 1 : ");
int number = Prompt("Введите число 2 : ");
int sum = SumNaturalRow(n, number);
System.Console.WriteLine(sum);


