using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_First_Pasted_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SKIDDED SPOOFER | V1.0 | I LOVE SKIDDING <3";
            Misc.DrawASCII();
            Misc.HashText("Welcome to your first skidded spoofer!");
            Misc.HashText("Press any key to load options...");
            Console.ReadKey();
            Console.Clear();
            Misc.DrawASCII();
            Misc.OptionText("Spoof");
            Misc.OptionText("Clean");
            Misc.HashText("Option : ");
            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Misc.DrawASCII();
                Misc.HashText("Spoofing Diskdrive!");
                Spoof.SpoofHDD();
                Misc.HashText("Spoofed Diskdrive!");
                Console.ReadKey();


            }
            else if (option == "2")
            {
                Console.Clear();
                Misc.DrawASCII();
                Misc.HashText("Cleaning Traces!");
                Spoof.CleanTraces("C:\\Windows\\IME\\cleaner.exe");
                Misc.HashText("Cleaned Traces!");
                Console.ReadKey();
            }
            else
            {
                Misc.HashText("Ok retard maybe type right next time");
            }
        }
    }
}
