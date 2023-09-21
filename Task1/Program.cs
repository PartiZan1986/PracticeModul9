using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                throw new MyException2();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                throw new MyException3();
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                throw new MyException4();
            }

            catch (DriveNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public class MyException : Exception
        {

        }

        public class MyException2 : DivideByZeroException
        {

        }

        public class MyException3 : FileNotFoundException
        {

        }

        public class MyException4 : DriveNotFoundException
        {

        }

        public class MyException5 : TimeoutException
        {

        }
    }
    
}
