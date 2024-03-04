using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1View
{
	public class AffineCipher
	{
		static string UkrainianAlphabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";


		// Функція для шифрування тексту
		public static string Encrypt(string text, int a, int b)
		{
			string result = "";

			foreach (char ch in text)
			{
				if (UkrainianAlphabet.Contains(Char.ToLower(ch)))
				{
					int index = UkrainianAlphabet.IndexOf(Char.ToLower(ch));
					int encryptedIndex = (a * index + b) % UkrainianAlphabet.Length;
					char encryptedChar = UkrainianAlphabet[encryptedIndex];
					if (Char.IsUpper(ch))
						result += Char.ToUpper(encryptedChar);
					else
						result += encryptedChar;
				}
				else
				{
					result += ch;
				}
			}

			return result;
		}

		// Функція для розшифрування тексту
		public static string Decrypt(string cipherText, int a, int b)
		{
			// Обернена для множення за модулем довжини алфавіту
			int aInverse = 0;
			for (int i = 0; i < UkrainianAlphabet.Length; i++)
			{
				if ((a * i) % UkrainianAlphabet.Length == 1)
				{
					aInverse = i;
					break;
				}
			}

			string result = "";

			foreach (char ch in cipherText)
			{
				if (UkrainianAlphabet.Contains(Char.ToLower(ch)))
				{
					int index = UkrainianAlphabet.IndexOf(Char.ToLower(ch));
					int decryptedIndex = (aInverse * (index - b + UkrainianAlphabet.Length)) % UkrainianAlphabet.Length;
					char decryptedChar = UkrainianAlphabet[decryptedIndex];
					if (Char.IsUpper(ch))
						result += Char.ToUpper(decryptedChar);
					else
						result += decryptedChar;
				}
				else
				{
					result += ch;
				}
			}

			return result;
		}
	}
}
