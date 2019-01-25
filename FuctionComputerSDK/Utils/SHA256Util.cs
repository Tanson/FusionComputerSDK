using System;
using System.Security.Cryptography;
using System.Text;

namespace FuctionComputerSDK.Utils
{
	// Token: 0x02000004 RID: 4
	public class SHA256Util
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002134 File Offset: 0x00000334
		public static string SHA256Encrypt(string strSrc)
		{
			byte[] bytes = Encoding.Default.GetBytes(strSrc);
			SHA256Managed sha256Managed = new SHA256Managed();
			byte[] array = sha256Managed.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}
	}
}
