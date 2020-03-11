using System;
using System.Runtime.Serialization;

namespace API_Example
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	internal class Exceptionxeex : Exception
	{
		// Token: 0x0600004A RID: 74 RVA: 0x0000A046 File Offset: 0x00008246
		public Exceptionxeex()
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000A050 File Offset: 0x00008250
		public Exceptionxeex(string message) : base(message)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000A05B File Offset: 0x0000825B
		public Exceptionxeex(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000A067 File Offset: 0x00008267
		protected Exceptionxeex(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
