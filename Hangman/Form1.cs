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
			char[] alphabet = "abcdefghijklmnopqrstuvwxyzÆØÅ".ToUpper().ToCharArray();
			for (int i = 0; i < alphabet.Length; i++)
			{
				buttonList.Add(new Button());
				buttonList[i].Text = alphabet[i].ToString();
				buttonList[i].Location = new Point(12 + (i * 12), 240);
				buttonList[i].Height = 23;
				buttonList[i].Width = 20;
				buttonList[i].Visible = true;
			}
		}
	}
}
