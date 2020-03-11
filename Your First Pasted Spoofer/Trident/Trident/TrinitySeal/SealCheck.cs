using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TrinitySeal
{
	// Token: 0x02000002 RID: 2
	internal class SealCheck
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void HashChecks()
		{
			bool flag = SealCheck.CalculateMD5("Newtonsoft.Json.dll") != "4df6c8781e70c3a4912b5be796e6d337" || SealCheck.CalculateMD5(typeof(Seal).Assembly.Location) != "0788cb32d5eb03916c701e0d18e25a74";
			if (flag)
			{
				MessageBox.Show("Hash check failed! Exiting...", "TrinitySeal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				SealCheck.isValidDLL = true;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020C8 File Offset: 0x000002C8
		private static string CalculateMD5(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		public static bool isValidDLL = false;
	}
}
