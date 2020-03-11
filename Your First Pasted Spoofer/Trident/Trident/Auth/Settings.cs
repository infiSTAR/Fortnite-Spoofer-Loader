using System;
using System.Security.Principal;

namespace Auth
{
	// Token: 0x02000005 RID: 5
	internal class Settings
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003A28 File Offset: 0x00001C28
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003A4C File Offset: 0x00001C4C
		public static string Time()
		{
			return DateTime.Now.ToString("hh:mm tt MM/dd/yyyy");
		}

		// Token: 0x0400000D RID: 13
		public static string AID = "57663";

		// Token: 0x0400000E RID: 14
		public static string Secret = "eij7RbU1x0GpyeLO2lKeKEbTdvUI1RS4iix";

		// Token: 0x0400000F RID: 15
		public static string Version = "1.0";
	}
}
