using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace EncryptionDecyrption
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FileStream fs1 = new FileStream("File.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer = new StreamWriter(fs1);
			string data = Console.ReadLine();
			writer.Write(data);
			writer.Close();

			string encrypted = CipherUtility.Encrypt<AesManaged>(data, "pw", "tucson");

			string decrypted = CipherUtility.Decrypt<AesManaged>(encrypted, "pw", "tucson");
		
			Console.WriteLine (encrypted);
			Console.WriteLine (decrypted);


		}
			
	}


	public class CipherUtility
	{
		public static string Encrypt<T>(string value, string password, string salt)
			where T : SymmetricAlgorithm, new()
		{
			DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

			SymmetricAlgorithm algorithm = new T();

			byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
			byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

			ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

			using (MemoryStream buffer = new MemoryStream())
			{
				using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
				{
					using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
					{
						writer.Write(value);
					}
				}

				return Convert.ToBase64String(buffer.ToArray());
			}
		}

		public static string Decrypt<T>(string text, string password, string salt)
			where T : SymmetricAlgorithm, new()
		{
			DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

			SymmetricAlgorithm algorithm = new T();

			byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
			byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

			ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIV);

			using (
				buffer = new MemoryStream(Convert.FromBase64String(text)))
			{
				using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
				{
					using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
					{
						return reader.ReadToEnd();
					}
				}
			}
		}
	}
}
