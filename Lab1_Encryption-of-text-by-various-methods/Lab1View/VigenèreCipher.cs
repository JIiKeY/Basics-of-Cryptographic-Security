
namespace Lab1View
{
	internal class VigenèreCipher
	{
		static readonly string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
		public static string Decript(string criptMessage, string key)
		{
			int M, C, K;
			string decript = null;
			key = KeyModify(key, criptMessage);

			for (int i = 0; i < criptMessage.Length; i++)
			{
				C = alphabet.IndexOf(criptMessage[i]);
				K = alphabet.IndexOf(key[i]);
				M = (C - K + 33) % 33;
				decript += alphabet[M];
			}
			return decript;
		}
		public static string Encript(string message, string key)
		{
			int C, P, K;
			string cript = null;
			key = KeyModify(key, message);
			for (int i = 0; i < message.Length; i++)
			{
				P = alphabet.IndexOf(message[i]);
				K = alphabet.IndexOf(key[i]);
				C = (P + K) % 33;
				cript += alphabet[C];
			}
			return cript;
		}
		static string KeyModify(string key, string message)
		{
			while (key.Length != message.Length)
			{
				for (int i = 0; i < key.Length; i++)
				{
					key += key[i];
					if (message.Length == key.Length)
						break;
				}
			}
			return key;
		}
	}
}
