using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Znakomstvo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine(0b11);
            //WriteLine(0b1011);
            //WriteLine(0b100001);
            //WriteLine(0x0FF);
            //WriteLine(3.2e3);
            //WriteLine(3.2e-1);
            //WriteLine('\x78');
            //WriteLine('\u0420');
            //object a = 22;
            //object b = 3.14;
            //object c = "hello code";
            //float x = 3.14F;
            //var hello = "hell to world";
            //var i = 20;
            //string name = "Tom";
            //int age = 34;
            //double height = 1.7;
            //WriteLine("Имя:{0} Возраст:{2} Рост:{1}",name,height,age);
            //WriteLine("Введите свое имя: ");
            //string y = ReadLine();
            //WriteLine(y);
            //int? nullint = null;
            //nullint = nullint ?? 50;
            //int number = nullint ?? 100;
            //WriteLine(number);

            //BackgroundColor = ConsoleColor.Blue;
            //ForegroundColor = ConsoleColor.Black;
            //int length = 128;
            //SetWindowSize(length, 8);
            //SetBufferSize(length, 8);
            //WriteLine("Input Encoding: " + InputEncoding.ToString());
            //WriteLine("Output Encoding: " + OutputEncoding.ToString());
            //ResetColor();
            //WriteLine("Is CAPS LOCK turnedon: " + CapsLock.ToString());

            //Задание 1

            //WriteLine("Введите A: ");
            //int A = Convert.ToInt32(ReadLine());
            //WriteLine("Введите B: ");
            //int B = Convert.ToInt32(ReadLine());
            //WriteLine("Введите C: ");
            //int C = Convert.ToInt32(ReadLine());
            //if ((A * B) < (C * C))
            //{
            //    WriteLine("В прямоугольнике нельзя разместить ни одного квадрата со стороной С");
            //}
            //else
            //{
            //    WriteLine("В прямоуголльнике {0} квадратов, а оставшееся место равно {1}", (A * B) / (C * C), (A * B) % (C * C));
            //}

            //Задание 2
            double schet = 10000;
            WriteLine("Введите P: ");
            double P = Convert.ToDouble(ReadLine());
            int K=0;
            while(schet<11000)
            {
                schet +=(schet / 100) * P;
                K++;
            }
            WriteLine("Количество месяцов:{0},Сумма:{1} ",K,schet);

            //WriteLine("Введите A: ");
            //int A = Convert.ToInt32(ReadLine());
            //WriteLine("Введите B: ");
            //int B = Convert.ToInt32(ReadLine());
            //if (A>B)
            //{
            //    WriteLine("Вы ввели неверное значение");
            //}
            //else
            //{
            //    for (;A<=B;A++)
            //    {
            //        for (int i = 0; i < A; i++)
            //        {
            //            Write("{0} ",A);
            //        }
            //        Write("\n");
            //    }
            //}

            //Задание 3

            //WriteLine("Введите A: ");
            //int A = Convert.ToInt32(ReadLine());
            //WriteLine("Введите B: ");
            //int B = Convert.ToInt32(ReadLine());
            //if (A>B)
            //{
            //    WriteLine("Вы ввели неверное значение");
            //}
            //else
            //{
            //    for (;A<=B;A++)
            //    {
            //        for (int i = 0; i < A; i++)
            //        {
            //            Write("{0} ",A);
            //        }
            //        Write("\n");
            //    }
            //}
        }
    }
}
