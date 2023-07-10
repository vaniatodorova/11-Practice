﻿namespace NoteTaking
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bttNew = new System.Windows.Forms.Button();
			this.bttSave = new System.Windows.Forms.Button();
			this.bttRead = new System.Windows.Forms.Button();
			this.bttDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(82, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Message";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(120, 121);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(157, 20);
			this.txtTitle.TabIndex = 2;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(120, 186);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(157, 159);
			this.txtMessage.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(406, 121);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(213, 224);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// bttNew
			// 
			this.bttNew.Location = new System.Drawing.Point(120, 397);
			this.bttNew.Name = "bttNew";
			this.bttNew.Size = new System.Drawing.Size(75, 23);
			this.bttNew.TabIndex = 5;
			this.bttNew.Text = "New";
			this.bttNew.UseVisualStyleBackColor = true;
			this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
			// 
			// bttSave
			// 
			this.bttSave.Location = new System.Drawing.Point(265, 397);
			this.bttSave.Name = "bttSave";
			this.bttSave.Size = new System.Drawing.Size(75, 23);
			this.bttSave.TabIndex = 6;
			this.bttSave.Text = "Save";
			this.bttSave.UseVisualStyleBackColor = true;
			this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
			// 
			// bttRead
			// 
			this.bttRead.Location = new System.Drawing.Point(406, 397);
			this.bttRead.Name = "bttRead";
			this.bttRead.Size = new System.Drawing.Size(75, 23);
			this.bttRead.TabIndex = 7;
			this.bttRead.Text = "Read";
			this.bttRead.UseVisualStyleBackColor = true;
			this.bttRead.Click += new System.EventHandler(this.bttRead_Click);
			// 
			// bttDelete
			// 
			this.bttDelete.Location = new System.Drawing.Point(544, 397);
			this.bttDelete.Name = "bttDelete";
			this.bttDelete.Size = new System.Drawing.Size(75, 23);
			this.bttDelete.TabIndex = 8;
			this.bttDelete.Text = "Delete";
			this.bttDelete.UseVisualStyleBackColor = true;
			this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bttDelete);
			this.Controls.Add(this.bttRead);
			this.Controls.Add(this.bttSave);
			this.Controls.Add(this.bttNew);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button bttNew;
		private System.Windows.Forms.Button bttSave;
		private System.Windows.Forms.Button bttRead;
		private System.Windows.Forms.Button bttDelete;
	}
}

