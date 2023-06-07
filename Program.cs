using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main()
        {

            long[] array = new long[10];
            Random rnd = new Random();
            long n;
            try
            {
                Console.WriteLine("введите число ");
                n = Convert.ToInt64(Console.ReadLine());
                if (n > 9999999999 || n <= 0)
                {
                    throw new Exception("не корректно введены данные ");    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            int a = 0;
            int count = 0;
            while (n != 0)// учитывает когда первый ноль
            {
                array[a] = n % 10;
                n = n / 10;
                if (array[a] == 0)
                    count++;
                a += 1;

            }
            int k = a - 1;
            long c = 0;


            while (a != 0)
            {
                for (int i = 0; i < (a - 1); i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        long buf = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buf;
                    }

                }

                a--;

                if (c < 10 && c > 0)
                {
                    for (int j = 1; j <= count; j++)
                    {
                        c *= 10;
                    }
                }
                c = c * 10 + array[k];
                k--;
            }

            Console.WriteLine("минимальное чилсо составленное из цифр числ " + c);


            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }

    }
}

