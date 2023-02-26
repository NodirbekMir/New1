﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
void New(int N)
{
    if (N > 0)
    {
        Console.Write("{0} ", N);
        New(N - 1);
    }
}
New(5);
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int n, m, s=0;
Console.Write("Введи значение от: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение до: ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine(s);
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int[,] Create2DRandomArray()
                    static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }else if (n == 0)
            {
                return Ack(m - 1, 1);
            }else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
 
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int eee = Ack(a, b);
           textBox3.Text = eee.ToString();
        }
