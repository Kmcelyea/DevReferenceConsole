using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(65, 33);
            Console.BufferWidth = 65;
            Console.BufferHeight = 33;
            Console.Title = "Welcome";
            Console.WriteLine("1. Strings");
            Console.WriteLine("2. ASCII Characters");
            Console.WriteLine("3. Exit");
            string ValidInput;
            do{

                ValidInput = Console.ReadLine();
                switch (ValidInput)
                {
                    case "1"://Strings
                        StringFormatting main = new StringFormatting();
                        main.ShowStrings();
                        break;
                    case "2"://ASCII
                        ASCII ascii = new ASCII();
                        ascii.ASCIIShow();
                        break;
                    case "3"://Exit
                        Environment.Exit(0);
                        break;
                }
            }
            while (ValidInput != "0");

            Console.Read();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public void Restart()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(65, 33);
            Console.BufferWidth = 65;
            Console.BufferHeight = 33;
            Console.Title = "Welcome";
            Console.WriteLine("1. Strings");
            Console.WriteLine("2. ASCII Characters");
            Console.WriteLine("3. Exit");
            string ValidInput;
            do
            {

                ValidInput = Console.ReadLine();
                switch (ValidInput)
                {
                    case "1"://Strings
                        StringFormatting main = new StringFormatting();
                        main.ShowStrings();
                        break;
                    case "2"://ASCII
                        ASCII ascii = new ASCII();
                        ascii.ASCIIShow();
                        break;
                    case "3"://Exit
                        Exit();
                        break;
                }
            }
            while (ValidInput != "0");

            Console.Read();

        }
    }
}
