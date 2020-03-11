using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_First_Pasted_Spoofer
{
    class Misc
    {
        private static int number;
        // made primarly just for junk shit
        public static void DrawASCII()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("            ██████  ██ ▄█▀ ██▓▓█████▄      ██████  ██▓███   ▒█████   ▒█████    █████▒▓█████  ██▀███  ");
            Console.WriteLine("          ▒██    ▒  ██▄█▒ ▓██▒▒██▀ ██▌   ▒██    ▒ ▓██░  ██▒▒██▒  ██▒▒██▒  ██▒▓██   ▒ ▓█   ▀ ▓██ ▒ ██▒");
            Console.WriteLine("          ░ ▓██▄   ▓███▄░ ▒██▒░██   █▌   ░ ▓██▄   ▓██░ ██▓▒▒██░  ██▒▒██░  ██▒▒████ ░ ▒███   ▓██ ░▄█ ▒");
            Console.WriteLine("            ▒   ██▒▓██ █▄ ░██░░▓█▄   ▌     ▒   ██▒▒██▄█▓▒ ▒▒██   ██░▒██   ██░░▓█▒  ░ ▒▓█  ▄ ▒██▀▀█▄  ");
            Console.WriteLine("          ▒██████▒▒▒██▒ █▄░██░░▒████▓    ▒██████▒▒▒██▒ ░  ░░ ████▓▒░░ ████▓▒░░▒█░    ░▒████▒░██▓ ▒██▒");
            Console.WriteLine("          ▒ ▒▓▒ ▒ ░▒ ▒▒ ▓▒░▓   ▒▒▓  ▒    ▒ ▒▓▒ ▒ ░▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒ ░    ░░ ▒░ ░░ ▒▓ ░▒▓░");
            Console.WriteLine("          ░ ░▒  ░ ░░ ░▒ ▒░ ▒ ░ ░ ▒  ▒    ░ ░▒  ░ ░░▒ ░       ░ ▒ ▒░   ░ ▒ ▒░  ░       ░ ░  ░  ░▒ ░ ▒░");
            Console.WriteLine("          ░  ░  ░  ░ ░░ ░  ▒ ░ ░ ░  ░    ░  ░  ░  ░░       ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░       ░     ░░   ░ ");
            Console.WriteLine("          ░  ░  ░  ░ ░░ ░  ▒ ░ ░ ░  ░    ░  ░  ░  ░░       ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░       ░     ░░   ░ ");
            Console.WriteLine("                ░  ░  ░    ░     ░             ░               ░ ░      ░ ░             ░  ░   ░     ");
            Console.WriteLine("                               ░                                                                     ");
            


        }
        public static void HashText(String text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("] ");
            Console.Write(text);




        }
        public static void OptionText(String text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.White;
            number++;
            Console.Write(number);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("] ");
            Console.Write(text);
        }
        private static void ResetOption()
        {
            number = 0;
        }
    }
}
