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
			this.resultLbl = new System.Windows.Forms.Label();
			this.wrongGuessLbl = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
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
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLbl.Location = new System.Drawing.Point(12, 108);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(89, 17);
			this.resultLbl.TabIndex = 1;
			this.resultLbl.Text = "Feilgjettinger";
			// 
			// wrongGuessLbl
			// 
			this.wrongGuessLbl.AutoSize = true;
			this.wrongGuessLbl.Cursor = System.Windows.Forms.Cursors.Default;
			this.wrongGuessLbl.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wrongGuessLbl.Location = new System.Drawing.Point(12, 137);
			this.wrongGuessLbl.Name = "wrongGuessLbl";
			this.wrongGuessLbl.Size = new System.Drawing.Size(0, 17);
			this.wrongGuessLbl.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(551, 344);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.wrongGuessLbl);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.HangmanPB);
			this.Name = "Form1";
			this.Text = "Hangman";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.HangmanPB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox HangmanPB;
		private System.Windows.Forms.Label resultLbl;
		private System.Windows.Forms.Label wrongGuessLbl;
		private System.Windows.Forms.Button button1;
	}
}

