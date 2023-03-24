using System;
public class Number
{
    private int n = 0;
    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return n + 1;
    }
}

class Program
{
    static void Main()
    {
        Number numberManager = new Number();

        while (true)
        {
            Console.Write($"Введите Ваше число {numberManager.GetExpectedNumber()}: ");
            int inputNumber;
            if (int.TryParse(Console.ReadLine(), out inputNumber))
            {
                if (numberManager.SetNumber(inputNumber))
                {
                    Console.WriteLine("Верно! Продолжаем!");
                }
                else
                {
                    Console.WriteLine("Неверно! Начнем заново.");
                }
            }
            else
            {
                Console.WriteLine("Попробуйте еще раз?!");
            }
        }
    }
}