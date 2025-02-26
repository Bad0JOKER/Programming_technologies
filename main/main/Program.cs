using System;
using System.Text;

namespace Lab_1_2kurs
{
    class Program
    {
        static int chetn(int left, int right) // static - можно обращаться без имени класса
        {
            int sum = 0;
            for (int number = left; number <= right; number++)
            {

                int tmp = Math.Abs(number);
                // sum += (i, 10) + mod(i, 10);
                while (tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;
                    tmp /= 10;
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sum;
            sum = chetn(0, 100);
            Console.WriteLine(sum);
            DateTime da = new DateTime(2013, 11, 17);
            Person pers = new Person(150, 80, da, "Имя Фамилия");

            Person per2 = new Person(170, 60, da, "Андрей Кремлёв1");
        }
    }
}
