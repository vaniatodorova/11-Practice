namespace GuessingNumberWindowsForms
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
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtEnterNumber = new System.Windows.Forms.TextBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.lblGuessed = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(0, 0);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 0;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(336, 305);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(115, 55);
			this.btnCheck.TabIndex = 1;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.CheckNumber);
			// 
			// txtEnterNumber
			// 
			this.txtEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtEnterNumber.Location = new System.Drawing.Point(155, 213);
			this.txtEnterNumber.Name = "txtEnterNumber";
			this.txtEnterNumber.Size = new System.Drawing.Size(517, 29);
			this.txtEnterNumber.TabIndex = 2;
			this.txtEnterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblQuestion.Location = new System.Drawing.Point(81, 115);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(469, 31);
			this.lblQuestion.TabIndex = 3;
			this.lblQuestion.Text = "I am thinking of a number between:";
			// 
			// lblGuessed
			// 
			this.lblGuessed.AutoSize = true;
			this.lblGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGuessed.Location = new System.Drawing.Point(83, 406);
			this.lblGuessed.Name = "lblGuessed";
			this.lblGuessed.Size = new System.Drawing.Size(158, 20);
			this.lblGuessed.TabIndex = 4;
			this.lblGuessed.Text = "You guessed 0 times";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblGuessed);
			this.Controls.Add(this.lblQuestion);
			this.Controls.Add(this.txtEnterNumber);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.trackBar1);
			this.Name = "Form1";
			this.Text = "Number Guessing Game";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox txtEnterNumber;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Label lblGuessed;
	}
}

