namespace Hangman
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HangmanPB = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.HangmanPB)).BeginInit();
			this.SuspendLayout();
			// 
			// HangmanPB
			// 
			this.HangmanPB.BackColor = System.Drawing.Color.White;
			this.HangmanPB.BackgroundImage = global::Hangman.Properties.Resources._base;
			this.HangmanPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.HangmanPB.InitialImage = null;
			this.HangmanPB.Location = new System.Drawing.Point(299, 12);
			this.HangmanPB.Name = "HangmanPB";
			this.HangmanPB.Size = new System.Drawing.Size(240, 320);
			this.HangmanPB.TabIndex = 0;
			this.HangmanPB.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(551, 344);
			this.Controls.Add(this.HangmanPB);
			this.Name = "Form1";
			this.Text = "Hangman";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.HangmanPB)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox HangmanPB;
	}
}

