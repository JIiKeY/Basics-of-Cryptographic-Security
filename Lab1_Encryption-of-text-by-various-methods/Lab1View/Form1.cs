using System;
using System.Web;
using System.Windows.Forms;

namespace Lab1View
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectionChangeCommitted += ComboBox1_SelectionChangeCommitted;
		}
		private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem.ToString() == "Шифр Плейфра" || comboBox1.SelectedItem.ToString() == "Шифр Виженера")
			{
				decriptSecondKey.Hide();
				label11.Hide();
			}
			else
			{
				decriptSecondKey.Hide();
				label11.Hide();
			}
		}
		private void EncriptBtn_Click(object sender, EventArgs e)
		{
			int indexComBox = comboBox1.SelectedIndex;
			int lenKey = FirstKeyBox.Text.Length;

			string FirstKey = FirstKeyBox.Text;
			string SecondKey = SecondKeyBox.Text;

			string sentence = textSent.Text;

			if (lenKey == 0 || sentence.Length == 0)
				MessageBox.Show("Поля мають бути заповненими", "Помилка!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			
			else
			{
				if (indexComBox == 0)
				{
					string str = PleyfraCipher.EncriptPleyfra(sentence.Replace(" ", "").ToUpper(), FirstKey.Replace(" ", "").ToUpper());
					encriptTextBox.Text = str;
				}
				else if(indexComBox == 1)
				{
					string str = VigenèreCipher.Encript(sentence.Replace(" ", "").ToUpper(), FirstKey.Replace(" ", "").ToUpper());
					encriptTextBox.Text = str;
				}
				else if (indexComBox == 2)
				{
					if (lenKey != 5 && indexComBox == 0)
						MessageBox.Show("Ключ має бути рівним 5 символам!", "Помилка!",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (sentence.Length > 25)
						MessageBox.Show($"Повідомлення не повинно перевищувати 25 симолів\r\nНаразі {sentence.Length} символів", "Помилка!",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
					{
						if (!(int.TryParse(FirstKey, out int FirstKeyToAffine)))
						{
							FirstKeyToAffine = FirstKey.Length;
						}
						if (!(int.TryParse(SecondKey, out int SecondKeyToAffine)))
						{
							SecondKeyToAffine = SecondKey.Length;
						}
						string str = AffineCipher.Encrypt(sentence, FirstKeyToAffine, SecondKeyToAffine);
						encriptTextBox.Text = str;
					}
				}
			}
		}
		private void DecriptBtn_Click(object sender, EventArgs e)
		{
			int indexComBox = comboBox2.SelectedIndex;
			int lenKey = decriptFirstKey.Text.Length;

			string FirstKey = decriptFirstKey.Text;
			string SecondKey = decriptSecondKey.Text;

			string encriptSent = encriptText.Text;

			if (lenKey == 0 || encriptSent.Length == 0)
				MessageBox.Show("Поля мають бути заповненими", "Помилка!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			
			else
			{
				if (indexComBox == 0)
				{
					string str = PleyfraCipher.DecriptPleyfraMessage(encriptSent.Replace(" ", "").ToUpper(), FirstKey.Replace(" ", "").ToUpper());
					decriptText.Text = str;
				}
				else if (indexComBox == 1)
				{
					string str = VigenèreCipher.Decript(encriptSent.Replace(" ", "").ToUpper(), FirstKey.Replace(" ", "").ToUpper());
					decriptText.Text = str;
				}
				else if (indexComBox == 2)
				{
					if (lenKey != 5 && indexComBox == 0)
						MessageBox.Show("Ключ має бути рівним 5 символам!", "Помилка!",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (encriptSent.Length > 25)
						MessageBox.Show($"Повідомлення не повинно перевищувати 25 симолів\r\nНаразі {encriptSent.Length} символів", "Помилка!",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
					{
						if (!(int.TryParse(FirstKey, out int FirstKeyToAffine)))
						{
							FirstKeyToAffine = FirstKey.Length;
						}
						if (!(int.TryParse(SecondKey, out int SecondKeyToAffine)))
						{
							SecondKeyToAffine = SecondKey.Length;
						}
						string str = AffineCipher.Decrypt(encriptSent, FirstKeyToAffine, SecondKeyToAffine);
						decriptText.Text = str;
					}
					
				}
			}
		}
		private void findKeyBtn_Click(object sender, EventArgs e)
		{
			string enMess;
			string decriptMess = decryptedMessBox.Text.ToLower();
			string encriptMess = encriptedMessBox.Text.ToLower();
			bool flag = false;
			listBoxKeys.Items.Clear();

			for (int i = 1; i < 34; i++)
			{
				for (int j = 0; j < 34; j++)
				{
					enMess = AffineCipher.Encrypt(encriptMess, i, j);
					if (enMess == decriptMess.ToLower())
					{
						listBoxKeys.Items.Add("First key = " + i + " Second key = " + j);
						break;
						
					}
					
				}
			}
			if (listBoxKeys.Items.Count == 0)
			{
				listBoxKeys.Items.Add("No keys were found for this encryption");
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1)
			{
				decriptSecondKey.Hide();
				label11.Hide();
				label12.Text = "Key";
			}
			else
			{
				decriptSecondKey.Show();
				label11.Show();
				label12.Text = "First Key";
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
			{
				SecondKeyBox.Hide();
				label10.Hide();
				label3.Text = "Key";
			}
			else
			{
				SecondKeyBox.Show();
				label10.Show();
				label3.Text = "First Key";
			}
		}
	}
}
		
