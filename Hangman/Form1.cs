using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		char[] theAnswer;
		private void Form1_Load(object sender, EventArgs e)
		{
			// Generate the "keyboard"
			List<Button> keyboardList = new List<Button>();
			List<Char> alphabet = new List<Char>();
			string letters = "qwertyuiopåasdfghjkløæzxcvbnm".ToUpper();
			foreach (char c in letters) alphabet.Add(c);

			int listCount = 0;
			
			for (int j = 0; j < 3; j++)
			{
				for (int i = 0; i < 11; i++)
				{
					keyboardList.Add(new Button());
					keyboardList.Last().Text = alphabet[listCount].ToString();
					keyboardList.Last().Location = new Point(i * 23 + 12, j * 28 + 220);
					keyboardList.Last().Height = 25;
					keyboardList.Last().Width = 20;
					
					keyboardList.Last().Click += new EventHandler(alphabet_click);

					
					this.Controls.Add(keyboardList[listCount]);
					listCount++;
				}
			}
			// Keyboard done

			//Pick a word (for single-player)
			string[] words = System.IO.File.ReadAllLines(@"\Resources\NORwords.txt");
			Random rng = new Random();
			theAnswer = words[rng.Next(0, words.Length)].ToCharArray();

			// Generates the bunch of buttons that are the answer
			List<Button> answerDisplayList = new List<Button>();
			for (int i = 0; i < theAnswer.Length; i++)
			{
				answerDisplayList.Add(new Button());
				answerDisplayList.Last().Location = new Point(i * 23 + 13, 48);
				keyboardList.Last().Height = 25;
				keyboardList.Last().Width = 20;
				keyboardList.Last().Enabled = false;

				this.Controls.Add(keyboardList[i]);
			}
		}

		private void alphabet_click(Object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			char guess = clickedButton.Text[0]; // get the actual char pressed
			for (int i = 0; i < theAnswer.Length; i++)
			{
				
			}
		}
	}
}
