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
            Console.WriteLine("Введите количество примеров:");
            int count = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int countcorrect = 0;
            int countwrong = 0;
            int countincorrect = 0;
            for (int i = 1; i <= count ; i++)
            {
                    int n1 = rnd.Next(2, 10);
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
                    Console.WriteLine("Тупица");
                    countwrong++;
                }
            }
            Console.WriteLine($"Правильных ответов: {countcorrect}, а неправльных:{countwrong}. Некорректный ввод : {countincorrect}раз");
        }
    }
}
