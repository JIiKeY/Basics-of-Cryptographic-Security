using System;
using System.Text;


namespace Lab1View
{
	internal class PleyfraCipher
	{
		static string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
		static readonly char[,] tablePleyfra = new char[6, 6];
		public static string DecriptPleyfraMessage(string encriptMessage, string key)
		{
			key = RemoveDuplicates(key);
			alphabet = ModificateAplhabet(alphabet, key);

			FillTable(tablePleyfra, alphabet);

			string decriptMessage = null;
			int rowIndex = -1, colIndex = -1,
				rowIndex1, rowIndex2, colIndex1, colIndex2;
			char firstEl, secondEl;
			int num = encriptMessage.Length / 2;
			for (int i = 0; i < num; i++)
			{
				firstEl = encriptMessage[0];
				secondEl = encriptMessage[1];
				FindElIndex(tablePleyfra, firstEl, ref rowIndex, ref colIndex);
				rowIndex1 = rowIndex;
				colIndex1 = colIndex;

				FindElIndex(tablePleyfra, secondEl, ref rowIndex, ref colIndex);
				rowIndex2 = rowIndex;
				colIndex2 = colIndex;

				encriptMessage = encriptMessage.Substring(2);

				if ((rowIndex1 == rowIndex2) && (colIndex1 != colIndex2)) // 
				{
					if (colIndex1 == 0)
						colIndex1 = 6;
					else if (colIndex2 == 0)
						colIndex2 = 6;
					decriptMessage += (tablePleyfra[rowIndex1, colIndex1 - 1].ToString() + tablePleyfra[rowIndex2, colIndex2 - 1]);
				}
				else if ((colIndex1 == colIndex2) && (rowIndex1 != rowIndex2)) // 
				{
					if (rowIndex1 == 0)
						rowIndex1 = 6;
					else if (rowIndex2 == 0)
						rowIndex2 = 6;
					decriptMessage += (tablePleyfra[rowIndex1 - 1, colIndex1].ToString() + tablePleyfra[rowIndex2 - 1, colIndex2]);
				}
				else if ((rowIndex1 != rowIndex2) && (colIndex2 != colIndex1)) // 
				{
					decriptMessage += (tablePleyfra[rowIndex1, colIndex2].ToString() + tablePleyfra[rowIndex2, colIndex1]);
				}

			}
			return decriptMessage;
		}
		private static void ShowTable(char[,] table)
		{
			for (int i = 0; i < table.GetLength(0); i++)
			{
				for (int j = 0; j < table.GetLength(1); j++)
				{
					Console.Write(table[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
		public static string EncriptPleyfra(string message, string key)
		{
			key = RemoveDuplicates(key);
			alphabet = ModificateAplhabet(alphabet, key);

			FillTable(tablePleyfra, alphabet);

			message = CheckForDuplicates(message);

			if (message.Length % 2 != 0)
				message += "Ь";

			int rowIndex = -1, colIndex = -1,
				rowIndex1, rowIndex2, colIndex1, colIndex2;
			char firstEl, secondEl;
			string encriptMessage = null;
			int num = message.Length / 2;
			for (int i = 0; i < num; i++)
			{
				firstEl = message[0];
				secondEl = message[1];

				FindElIndex(tablePleyfra, firstEl, ref rowIndex, ref colIndex);
				rowIndex1 = rowIndex;
				colIndex1 = colIndex;

				FindElIndex(tablePleyfra, secondEl, ref rowIndex, ref colIndex);
				rowIndex2 = rowIndex;
				colIndex2 = colIndex;

				message = message.Substring(2);

				if ((rowIndex1 == rowIndex2) && (colIndex1 != colIndex2)) // переход по стовбцям
				{
					if (colIndex1 == 5)
						colIndex1 = -1;
					else if (colIndex2 == 5)
						colIndex2 = -1;
					encriptMessage += (tablePleyfra[rowIndex1, colIndex1 + 1].ToString() + tablePleyfra[rowIndex2, colIndex2 + 1]);
				}
				else if ((colIndex1 == colIndex2) && (rowIndex1 != rowIndex2)) // переход по строкам
				{
					if (rowIndex1 == 5)
						rowIndex1 = -1;
					else if (rowIndex2 == 5)
						rowIndex2 = -1;
					encriptMessage += (tablePleyfra[rowIndex1 + 1, colIndex1].ToString() + tablePleyfra[rowIndex2 + 1, colIndex2]);
				}
				else if ((rowIndex1 != rowIndex2) && (colIndex2 != colIndex1)) // переход по стовбцям
				{
					encriptMessage += (tablePleyfra[rowIndex1, colIndex2].ToString() + tablePleyfra[rowIndex2, colIndex1]);
				}
			}
			return encriptMessage;
		}
		static void FillTable(char[,] tablePleyfra, string alphabet)
		{
			int count = 0;
			char[] symbol = { '@', '#', '$' };
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					if (count <= 32)
					{
						tablePleyfra[i, j] = alphabet[count];
					}
					else
					{
						tablePleyfra[i, j] = symbol[count - 33];
					}
					count++;
				}
			}
		}
		static void FindElIndex(char[,] Array, char el, ref int rowIndex, ref int colIndex)
		{
			bool found = false;
			for (int i = 0; i < Array.GetLength(0); i++)
			{
				for (int j = 0; j < Array.GetLength(1); j++)
				{
					// 
					if (Array[i, j] == el)
					{
						rowIndex = i;
						colIndex = j;
						found = true;
						break;
					}
				}
				if (found)
				{
					break;
				}
			}
		}
		static string CheckForDuplicates(string str)
		{
			for (int i = 0; i < str.Length - 1; i++)
			{
				char currentChar = str[i];
				if (currentChar == str[i + 1])
				{
					str = str.Insert(i + 1, "Ь"); // 
				}
			}
			return str; // 
		}
		static string ModificateAplhabet(string alphabet, string key)
		{
			int i;
			StringBuilder sb = new StringBuilder(alphabet);
			foreach (char c in key)
			{
				i = sb.ToString().IndexOf(c);
				if (i != -1)
				{
					sb.Remove(i, 1);
				}

			}
			return key + sb.ToString();
		}
		static string RemoveDuplicates(string str)
		{
			StringBuilder builder = new StringBuilder();

			foreach (char c in str)
			{
				// 
				if (builder.ToString().IndexOf(c) == -1)
				{
					builder.Append(c);

				}
			}

			return builder.ToString();
		}

	}
}
