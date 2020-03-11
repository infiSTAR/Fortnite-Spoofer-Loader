using System;

namespace Auth
{
	// Token: 0x02000006 RID: 6
	internal class UserInfo
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003A9B File Offset: 0x00001C9B
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00003AA2 File Offset: 0x00001CA2
		public static bool Logged_In { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003AAA File Offset: 0x00001CAA
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003AB1 File Offset: 0x00001CB1
		public static string ID { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003AB9 File Offset: 0x00001CB9
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public static string IP { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003AC8 File Offset: 0x00001CC8
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00003ACF File Offset: 0x00001CCF
		public static string Username { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003AD7 File Offset: 0x00001CD7
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00003ADE File Offset: 0x00001CDE
		public static string Password { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003AE6 File Offset: 0x00001CE6
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00003AED File Offset: 0x00001CED
		public static string HWID { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003AF5 File Offset: 0x00001CF5
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003AFC File Offset: 0x00001CFC
		public static string Email { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003B04 File Offset: 0x00001D04
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003B0B File Offset: 0x00001D0B
		public static string Variable { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003B13 File Offset: 0x00001D13
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00003B1A File Offset: 0x00001D1A
		public static string Rank { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003B22 File Offset: 0x00001D22
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003B29 File Offset: 0x00001D29
		public static string Expiry { get; set; }
	}
}
