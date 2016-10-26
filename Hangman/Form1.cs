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

		private void Form1_Load(object sender, EventArgs e)
		{
			List<Button> buttonList = new List<Button>();
			List<Char> alphabet = new List<Char>();
			string letters = "qwertyuiopåasdfghjkløæzxcvbnm".ToUpper();
			foreach (char c in letters) alphabet.Add(c);

			int i = 0;
			for (int j = 0; j < 3; j++)
			{
				for (; i < alphabet.Count; i++)
				{
					buttonList.Add(new Button());
					buttonList.Last().Text = alphabet[i].ToString();
					buttonList.Last().Location = new Point(((i%11 + 1) * 23) + 12, (j * 28) +220);
					buttonList.Last().Height = 25;
					buttonList.Last().Width = 20;
					buttonList.Last().Visible = true;

					this.Controls.Add(buttonList[i]);
				}
			}
		/*
			for (int i = 0; i < 11; i++)
			{
				buttonList.Add(new Button());
				buttonList.Last().Text = alphabet[i].ToString();
				buttonList.Last().Location = new Point((i * 23) + 12,  220);
				buttonList.Last().Height = 25;
				buttonList.Last().Width = 20;
				buttonList.Last().Visible = true;

				this.Controls.Add(buttonList[i]);
			}
		for (int i = 11; i < 22; i++)
		{
			buttonList.Add(new Button());
			buttonList.Last().Text = alphabet[i].ToString();
			buttonList.Last().Location = new Point(((i -11)*23) + 12, (35) + 220);
			buttonList.Last().Height = 25;
			buttonList.Last().Width = 20;
			buttonList.Last().Visible = true;

			this.Controls.Add(buttonList[i]);
		}
		for (int i = 22; i < 29; i++)
		{
			buttonList.Add(new Button());
			buttonList.Last().Text = alphabet[i].ToString();
			buttonList.Last().Location = new Point(((i -22)*23) + 12, (2 * 35) + 220);
			buttonList.Last().Height = 25;
			buttonList.Last().Width = 20;
			buttonList.Last().Visible = true;

			this.Controls.Add(buttonList[i]);
		}
		*/

	}
	}
}
