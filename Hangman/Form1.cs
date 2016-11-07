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
		
		List<Bitmap> imageList = new List<Bitmap> { Properties.Resources.stage00, Properties.Resources.stage01,
		Properties.Resources.stage02,Properties.Resources.stage03, Properties.Resources.stage04, Properties.Resources.stage05,
		Properties.Resources.stage06,Properties.Resources.stage07, Properties.Resources.stage08, Properties.Resources.stage09,
		Properties.Resources.stage10,Properties.Resources.stage11 };

		int numOfFails = 0;

		char[] theAnswer;
		List<Button> answerDisplayList = new List<Button>();
		List<Button> keyboardList = new List<Button>();

		private void Form1_Load(object sender, EventArgs e)
		{
			// Generate the "keyboard"
			Console.WriteLine("Keyboard Generation Start");
			
			List<Char> alphabet = new List<Char>();
			string letters = "qwertyuiopåasdfghjkløæzxcvbnm".ToUpperInvariant();
			foreach (char c in letters) alphabet.Add(c);

			int listCount = 0;

			for (int j = 0; j < 3; j++)
			{
				for (int i = 0; i < 11; i++)
				{
					keyboardList.Add(new Button());
					keyboardList.Last().Text = alphabet[listCount].ToString().ToUpper();
					keyboardList.Last().Location = new Point(i * 23 + 12, j * 28 + 220);
					keyboardList.Last().Height = 25;
					keyboardList.Last().Width = 20;

					keyboardList.Last().Click += new EventHandler(alphabet_click);


					this.Controls.Add(keyboardList[listCount]);
					if (listCount + 1 == alphabet.Count())
						break;
					listCount++;
				}
				if (listCount + 1 == alphabet.Count())
					break;
			}
			Console.WriteLine("Keyboard Generation Done!");
			// Keyboard done

			wordPicker();
		}

		private void wordPicker()
		{

			Console.WriteLine("Starting to pick word");
			string[] words = System.IO.File.ReadAllLines("..\\..\\Resources\\NORwords.txt");
			Random rng = new Random();
			theAnswer = words[rng.Next(0, words.Length)].ToUpper().ToCharArray();
			Console.Write("The answer is ");
			Console.WriteLine(theAnswer);


			// Generates the bunch of buttons that are the answer
			// I chose buttons because they are easier to work with I think. 

			for (int i = Controls.Count; i > 33; i--)
				Controls.RemoveAt(i-1);

			Console.WriteLine("Generating answer buttons");
			answerDisplayList = new List<Button>();
			for (int i = 0; i < theAnswer.Length; i++)
			{
				answerDisplayList.Add(new Button());
				answerDisplayList.Last().Text = " ";
				answerDisplayList.Last().Location = new Point(i * 23 + 13, 48);
				answerDisplayList.Last().Height = 25;
				answerDisplayList.Last().Width = 20;
				answerDisplayList.Last().Enabled = false;

				this.Controls.Add(answerDisplayList[i]);
				Console.Write(Controls.Count + " ");
			}
			Console.WriteLine(this.Controls.Count);
			Console.WriteLine("Answer buttons generated");
		}

		private void alphabet_click(Object sender, EventArgs e)
		{
			
			bool zeroRight = true; // used to check if the letter pressed is in teh word at all
			Button clickedButton = (Button)sender;
			char guess = clickedButton.Text[0]; // get the actual char pressed
			
			Console.Write(guess);

			for (int i = 0; i < theAnswer.Length; i++)
			{
				// I gotta convert from upper to lower case. 
				if (guess.Equals(theAnswer[i]))
				{
					answerDisplayList[i].Text = theAnswer[i].ToString();
					zeroRight = false;
				}
			}
			clickedButton.Enabled = false;
			if (zeroRight)
			{
				wrongGuessLbl.Text += clickedButton.Text;
				HangmanPB.Image = imageList[numOfFails];
				numOfFails++;
				
			}
		}

		private void RestartBtn_Click(object sender, EventArgs e)
		{
			wordPicker();
			foreach (Button button in keyboardList) button.Enabled = true;
		}
	}
}
