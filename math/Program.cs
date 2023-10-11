using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пример";
            //Сочетание без повторений
            //Console.Write("m = ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //float n_fac = 1;
            //float m_fac = 1;
            //float n_m_fac = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    n_fac = n_fac * i;
            //}
            //for (int i = 1; i <= m; i++)
            //{
            //    m_fac = m_fac * i;
            //}
            //for (int i = 1; i <= n - m; i++)
            //{
            //    n_m_fac = n_m_fac * i;
            //}
            //float c = n_fac / (m_fac * n_m_fac);
            //Console.WriteLine($"C = {c}");



            //Сочетание с повторениями
            //Console.Write("m = ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //float n_m_1 = 1;
            //float m_fac = 1;
            //float n_1 = 1;
            //for (int i = 1; i <= n + m - 1; i++)
            //{
            //    n_m_1 = n_m_1 * i;
            //}
            //for (int i = 1; i <= m; i++)
            //{
            //    m_fac = m_fac * i;
            //}
            //for (int i = 1; i <= n - 1; i++)
            //{
            //    n_1 = n_1 * i;
            //}
            //float c = n_m_1 / (m_fac * n_1);
            //Console.WriteLine($"C = {c}");
            //Console.ReadKey();



            //Размещения без повторений
            //Console.Write("m = ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //float n_fac = 1;
            //float n_m = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    n_fac = n_fac * i;
            //}
            //for (int i = 1; i <= n - m; i++)
            //{
            //    n_m = n_m * i;
            //}
            //float a = n_fac / n_m;
            //Console.WriteLine($"A = {a}");
            //Console.ReadKey();



            //Размещение с повторениями
            //Console.Write("m = ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double a = Math.Pow(n, m);
            //Console.WriteLine($"A = {a}");
            //Console.ReadKey();



            //Перестановка без повторений
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //float p = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    p = p * i;
            //}
            //Console.WriteLine($"P = {p}");
            //Console.ReadKey();



            //Перестановка с повторениями
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("k = ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //float n_fac = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    n_fac = n_fac * i;
            //}
            //float nk_fac = 1;
            //for (int i = 1; i <= k; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        nk_fac = nk_fac * j;
            //    }
            //}
            //float p = n_fac / nk_fac;
            //Console.WriteLine($"P = {p}");
            //Console.ReadKey();



            //Бином Ньютона
            //Console.Write("a = ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b = ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double binom_nutona = Math.Pow(a + b, n);
            //Console.WriteLine($"(a+b)^n = {binom_nutona}");
            //Console.ReadKey();



            //Треугольник Паскаля
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int c = 0; c <= (n - i); c++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c <= i; c++)
                {
                    Console.Write(" ");
                    Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
        public static float Factorial(int n)
        {
            float x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
    }
}