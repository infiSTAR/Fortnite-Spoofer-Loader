using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Auth;

namespace API_Example
{
	// Token: 0x0200000C RID: 12
	internal class Entries
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000A5C8 File Offset: 0x000087C8
		private static void Main(string[] args)
		{
			Console.Title = "Trident Spoofer | Updated | Undetected | Edit by Duarity#0001 |";
			Handler.Initialize();
			bool flag = ProgramInfo.Freemode == "Disable";
			if (flag)
			{
				Console.WriteLine("This application is in freemode redirecting!");
			}
			Console.Clear();
			Draw.print1();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(" [");
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("+");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("] ");
			Console.WriteLine("Enter the Key");
			string text = Console.ReadLine();
			WebClient webClient = new WebClient();
			Console.Clear();
			Draw.print1();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(" [");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Spoof DiskDrive");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("] ");
			Console.WriteLine("Spoof");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(" [");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Clean Traces");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("] ");
			Console.WriteLine("Clean");
			string a = Console.ReadLine();
			bool flag2 = a == "Spoof";
			if (flag2)
			{
				Console.Clear();
				Thread.Sleep(1000);
				Draw.print1();
				MessageBox.Show("Starting to Spoof!\n Please wait...", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Thread.Sleep(2000);
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(" [");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("!");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write("] ");
				Console.WriteLine("Spoofing Please Wait...");
				Spoofer.spoof1();
				Thread.Sleep(4000);
				MessageBox.Show("Spoofed Successfully!", "Trident Spoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Console.Clear();
				Draw.print1();
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(" [");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("A");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write("] ");
				Console.WriteLine("Spoof");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write(" [");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("B");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.Write("] ");
				Console.WriteLine("Clean Traces");
			}
			else
			{
				bool flag3 = a == "Clean";
				if (flag3)
				{
					MessageBox.Show("Success Clean Traces ");
					Spoofer.cleantraces();
					Draw.cache();
				}
				else
				{
					Console.WriteLine("Spoof or Clean :V!!");
				}
			}
			Console.ReadLine();
		}

		// Token: 0x04000022 RID: 34
		private const string Disable = "Disable";
	}
}
