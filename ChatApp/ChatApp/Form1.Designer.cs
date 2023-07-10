namespace ChatApp
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
			this.meLabel = new System.Windows.Forms.Label();
			this.friendLabel = new System.Windows.Forms.Label();
			this.localIp = new System.Windows.Forms.Label();
			this.localPort = new System.Windows.Forms.Label();
			this.friendsIp = new System.Windows.Forms.Label();
			this.friendsPort = new System.Windows.Forms.Label();
			this.textLocalIp = new System.Windows.Forms.TextBox();
			this.textLocalPort = new System.Windows.Forms.TextBox();
			this.textRemoteIp = new System.Windows.Forms.TextBox();
			this.textRemotePort = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonSend = new System.Windows.Forms.Button();
			this.textMessage = new System.Windows.Forms.TextBox();
			this.listMessage = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// meLabel
			// 
			this.meLabel.AutoSize = true;
			this.meLabel.Location = new System.Drawing.Point(12, 9);
			this.meLabel.Name = "meLabel";
			this.meLabel.Size = new System.Drawing.Size(22, 13);
			this.meLabel.TabIndex = 0;
			this.meLabel.Text = "Me";
			// 
			// friendLabel
			// 
			this.friendLabel.AutoSize = true;
			this.friendLabel.Location = new System.Drawing.Point(362, 9);
			this.friendLabel.Name = "friendLabel";
			this.friendLabel.Size = new System.Drawing.Size(36, 13);
			this.friendLabel.TabIndex = 1;
			this.friendLabel.Text = "Friend";
			// 
			// localIp
			// 
			this.localIp.AutoSize = true;
			this.localIp.Location = new System.Drawing.Point(13, 37);
			this.localIp.Name = "localIp";
			this.localIp.Size = new System.Drawing.Size(16, 13);
			this.localIp.TabIndex = 2;
			this.localIp.Text = "Ip";
			// 
			// localPort
			// 
			this.localPort.AutoSize = true;
			this.localPort.Location = new System.Drawing.Point(13, 72);
			this.localPort.Name = "localPort";
			this.localPort.Size = new System.Drawing.Size(26, 13);
			this.localPort.TabIndex = 3;
			this.localPort.Text = "Port";
			// 
			// friendsIp
			// 
			this.friendsIp.AutoSize = true;
			this.friendsIp.Location = new System.Drawing.Point(374, 34);
			this.friendsIp.Name = "friendsIp";
			this.friendsIp.Size = new System.Drawing.Size(16, 13);
			this.friendsIp.TabIndex = 4;
			this.friendsIp.Text = "Ip";
			// 
			// friendsPort
			// 
			this.friendsPort.AutoSize = true;
			this.friendsPort.Location = new System.Drawing.Point(374, 69);
			this.friendsPort.Name = "friendsPort";
			this.friendsPort.Size = new System.Drawing.Size(26, 13);
			this.friendsPort.TabIndex = 5;
			this.friendsPort.Text = "Port";
			// 
			// textLocalIp
			// 
			this.textLocalIp.Location = new System.Drawing.Point(55, 34);
			this.textLocalIp.Name = "textLocalIp";
			this.textLocalIp.Size = new System.Drawing.Size(182, 20);
			this.textLocalIp.TabIndex = 6;
			// 
			// textLocalPort
			// 
			this.textLocalPort.Location = new System.Drawing.Point(55, 69);
			this.textLocalPort.Name = "textLocalPort";
			this.textLocalPort.Size = new System.Drawing.Size(182, 20);
			this.textLocalPort.TabIndex = 7;
			// 
			// textRemoteIp
			// 
			this.textRemoteIp.Location = new System.Drawing.Point(415, 31);
			this.textRemoteIp.Name = "textRemoteIp";
			this.textRemoteIp.Size = new System.Drawing.Size(163, 20);
			this.textRemoteIp.TabIndex = 8;
			// 
			// textRemotePort
			// 
			this.textRemotePort.Location = new System.Drawing.Point(415, 69);
			this.textRemotePort.Name = "textRemotePort";
			this.textRemotePort.Size = new System.Drawing.Size(163, 20);
			this.textRemotePort.TabIndex = 9;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(673, 42);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 11;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(673, 349);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSend.TabIndex = 12;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// textMessage
			// 
			this.textMessage.Location = new System.Drawing.Point(27, 385);
			this.textMessage.Name = "textMessage";
			this.textMessage.Size = new System.Drawing.Size(568, 20);
			this.textMessage.TabIndex = 13;
			// 
			// listMessage
			// 
			this.listMessage.FormattingEnabled = true;
			this.listMessage.Location = new System.Drawing.Point(12, 122);
			this.listMessage.Name = "listMessage";
			this.listMessage.Size = new System.Drawing.Size(583, 238);
			this.listMessage.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listMessage);
			this.Controls.Add(this.textMessage);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textRemotePort);
			this.Controls.Add(this.textRemoteIp);
			this.Controls.Add(this.textLocalPort);
			this.Controls.Add(this.textLocalIp);
			this.Controls.Add(this.friendsPort);
			this.Controls.Add(this.friendsIp);
			this.Controls.Add(this.localPort);
			this.Controls.Add(this.localIp);
			this.Controls.Add(this.friendLabel);
			this.Controls.Add(this.meLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label meLabel;
		private System.Windows.Forms.Label friendLabel;
		private System.Windows.Forms.Label localIp;
		private System.Windows.Forms.Label localPort;
		private System.Windows.Forms.Label friendsIp;
		private System.Windows.Forms.Label friendsPort;
		private System.Windows.Forms.TextBox textLocalIp;
		private System.Windows.Forms.TextBox textLocalPort;
		private System.Windows.Forms.TextBox textRemoteIp;
		private System.Windows.Forms.TextBox textRemotePort;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.TextBox textMessage;
		private System.Windows.Forms.ListBox listMessage;
	}
}

