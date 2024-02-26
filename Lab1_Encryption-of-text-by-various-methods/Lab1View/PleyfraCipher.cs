using System;

namespace Lab1View
{
	internal class PleyfraCipher
	{
		public static string EncriptedText(string sentence, string key)
		{
			string encriptText = default; // Ініціалізуємо строку в яку занесемо зашифроване повідомлення
			string[,] sentenseArr = new string[5, 5]; // ініацізація двохмірного массива 
			string[,] encryptedArr = new string[5, 5]; // ініацізація двохмірного массива 

			int[] num = new int[5]; // ініціалізація 
			char[] keyArr = key.ToCharArray();//
			char[] sortedKeyArr = key.ToCharArray();//

			Array.Sort(sortedKeyArr);//

			for (int i = 0; i < 5; i++)//
			{
				for (int j = 0; j < 5; j++)//
				{
					if (sentence != "")//
					{
						sentenseArr[j, i] = sentence[0].ToString();//
						sentence = sentence.Remove(0, 1);//
					}
					else//
						sentenseArr[j, i] = "_";//
				}
			}
			for (int i = 0; i < 5; i++)//
			{
				num[i] = Array.IndexOf(keyArr, sortedKeyArr[i]);//
				for (int j = 0; j < 5; j++)//
					encryptedArr[j, i] = sentenseArr[j, num[i]];//
			}
			for (int i = 0; i < 5; i++)//
			{
				for (int j = 0; j < 5; j++)//
					encriptText += encryptedArr[i, j];//

				encriptText += " ";//
			}
			return encriptText;
		}

		public static string DecriptedText(string encriptSent, string key)
		{

			string decriptSent = string.Empty;
			string[,] decriptedArr = new string[5, 5];
			string[,] encryptedArr = new string[5, 5];

			int[] num = new int[5];
			char[] keyArr = key.ToCharArray();
			char[] sortedKeyArr = key.ToCharArray();
			Array.Sort(sortedKeyArr);

			for (int i = 0; i < 5; i++)
			{
				num[i] = Array.IndexOf(keyArr, sortedKeyArr[i]);
				for (int j = 0; j < 5; j++)
				{
					if (encriptSent != "")
					{
						encryptedArr[i, j] = encriptSent[0].ToString();
						encriptSent = encriptSent.Remove(0, 1);
					}
					else
						encryptedArr[i, j] = " ";
				}
			}
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++)
					decriptedArr[j, num[i]] = encryptedArr[j, i];
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++)
				{
					if (decriptedArr[j, i] == "_")
					{
						break;
					}
					decriptSent += decriptedArr[j, i];
				}
			return decriptSent;
		}
	}
}
