using System;
using System.Linq;

namespace API_Example
{
	// Token: 0x0200000D RID: 13
	internal class SMBIOS
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0000A888 File Offset: 0x00008A88
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[SMBIOS.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x04000023 RID: 35
		private static Random random = new Random();
	}
}
