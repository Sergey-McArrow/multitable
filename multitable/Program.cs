using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multitable
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите количество примеров:");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите число для тренировки знаний таблицы умонжения, или нажмите ВВОД для проверки знаний всей таблицы.");
            string ntraintemp = (Console.ReadLine());
            int ntrain, n1=0;
            bool parced = int.TryParse(ntraintemp, out ntrain);
            int countcorrect = 0;
            int countwrong = 0;
            int countincorrect = 0;
            for (int i = 1; i <= count ; i++)
            {
             if (!parced)
             n1 = rnd.Next(2, 10);
             else
             n1 = ntrain;
             int n2 = rnd.Next(2, 10);
             Console.Write($"{n1} * {n2} = ");
             string input = (Console.ReadLine());
             int answer;
             bool parsed = int.TryParse(input, out answer);
                if (!parsed)
                {
                    Console.WriteLine("Повторите ввод.Вводить можно только цифры");
                    countincorrect++;
                    continue;
                }
                else if
                (n1 * n2 == answer)
                {
             Console.WriteLine("Молодец");
             countcorrect++;
                }
                else
                {
             Console.WriteLine($"Неправильно. Правильный ответ: {n1*n2}");
             countwrong++;
                }
            }
            Console.WriteLine($"Правильных ответов: {countcorrect}, а неправльных: {countwrong}. Некорректный ввод: {countincorrect} раз.");
            Console.ReadKey();
        }
    }
}
