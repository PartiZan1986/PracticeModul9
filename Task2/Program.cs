using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberReader reader = new NumberReader();
            reader.NumberReaderEvent += ShowResult;

            Console.WriteLine("Введите 5 фамилий");

            string[] ArraySurnames = new string[5];

            for (int i = 0; i < ArraySurnames.Length; i++)
            {
                ArraySurnames[i] = Console.ReadLine();
            }

            try
            {
                reader.Read();
            }

            catch (FormatException)
            {
                Console.WriteLine("Введено не корректное значение");
            }

            //Array.Sort(ArraySurnames);
            //Array.Reverse(ArraySurnames);
            //Console.WriteLine(String.Join(", ", ArraySurnames));


            int ShowResult(int number)
            {
                switch (number)
                {
                    case 1: Console.WriteLine("Ввели 1"); break;
                    case 2: Console.WriteLine("Ввели 2"); break;
                    default: Console.WriteLine(number); break;

                }
            }

            Console.ReadKey();
        }

        public class NumberReader
        {
            public delegate int NumberReaderDelegate(int value);
            public event NumberReaderDelegate NumberReaderEvent;

            public void Read()
            {
                Console.WriteLine("Введите 1, если хоти отсортировать от А -  Я.\n" + "Введите 2, если хоти отсортировать от Я - А.");

                int number = Convert.ToInt32(Console.ReadLine());

                if (number != 1 && number != 2) throw new FormatException();

                NumberEntered(number);
            }

            protected virtual void NumberEntered(int number)
            {
                NumberReaderEvent.Invoke(number);
            }
        }
    }

}
