using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReferences
{
    public class ASCII
    {
        public void ASCIIShow()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetWindowSize(65, 43);
            Console.BufferWidth = 65;
            Console.BufferHeight = 45;

            // Set the window size and title
            Console.Title = "MS-DOS ASCII Characters";

            for (byte b = 0; b < byte.MaxValue; b++)
            {
                char c = Encoding.GetEncoding(437).GetChars(new byte[] { b })[0];
                switch (b)
                {
                    case 8: // Backspace
                    case 9: // Tab
                    case 10: // Line feed
                    case 13: // Carriage return
                        c = '.';
                        break;
                }

                Console.Write("{0:000} {1}   ", b, c);

                // 7 is a beep -- Console.Beep() also works
                if (b == 7) Console.Write(" ");

                if ((b + 1) % 8 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Home");
            Console.WriteLine("2. Strings");
            Console.WriteLine("3. Exit");
            string ValidInput;
            do
            {

                ValidInput = Console.ReadLine();
                switch (ValidInput)
                {
                    case "1"://Strings
                        Program main = new Program();
                        main.Restart();
                        break;
                    case "2"://ASCII
                        StringFormatting strings = new StringFormatting();
                        strings.ShowStrings();
                        break;
                    case "3"://Exit
                        Program exit = new Program();
                        exit.Exit();
                        break;

                }
            }
            while (ValidInput != "0");
            Console.Read();
        }
    }
}
