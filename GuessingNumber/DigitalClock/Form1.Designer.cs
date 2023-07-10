namespace DigitalClock
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
			this.components = new System.ComponentModel.Container();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblSecond = new System.Windows.Forms.Label();
			this.lblDay = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(60, 96);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(286, 110);
			this.lblTime.TabIndex = 0;
			this.lblTime.Text = "22:22";
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSecond.ForeColor = System.Drawing.Color.White;
			this.lblSecond.Location = new System.Drawing.Point(327, 149);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(62, 44);
			this.lblSecond.TabIndex = 1;
			this.lblSecond.Text = "22";
			// 
			// lblDay
			// 
			this.lblDay.AutoSize = true;
			this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDay.ForeColor = System.Drawing.Color.White;
			this.lblDay.Location = new System.Drawing.Point(450, 242);
			this.lblDay.Name = "lblDay";
			this.lblDay.Size = new System.Drawing.Size(288, 57);
			this.lblDay.TabIndex = 2;
			this.lblDay.Text = "SATURDAY";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDate.ForeColor = System.Drawing.Color.White;
			this.lblDate.Location = new System.Drawing.Point(32, 332);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(340, 57);
			this.lblDate.TabIndex = 3;
			this.lblDate.Text = "JUNE 25 2016";
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblDay);
			this.Controls.Add(this.lblSecond);
			this.Controls.Add(this.lblTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.Label lblDay;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Timer timer;
	}
}

