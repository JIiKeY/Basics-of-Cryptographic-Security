using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1View
{
	
	internal class VigenèreCipher
	{
		static string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
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
			int messageLen = message.Length;
			while (key.Length != messageLen)
			{
				if(key.Length < messageLen)
				{
					for (int i = 0; i < key.Length; i++)
					{
						key += key[i];
						if (messageLen == key.Length)
							return key;
					}
				}
				else if (key.Length > messageLen) 
				{
					key = key.Substring(0, messageLen);
					return key;
				}
			}
			return key;
			
		}
	}
}
