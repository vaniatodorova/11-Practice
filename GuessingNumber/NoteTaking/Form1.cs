using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
	public partial class Form1 : Form
	{
		DataTable table; //Създава таблица
		public Form1()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{}

		private void Form1_Load(object sender, EventArgs e)
		{
			table = new DataTable();//новата таблица
			table.Columns.Add("Title", typeof(String));//добавя колона "име", (тип)
			table.Columns.Add("Messages", typeof(String));//добавя колона "име", (тип)
			dataGridView1.DataSource = table;//свързва таблицата с datagridview

			dataGridView1.Columns["Messages"].Visible = false;//скрива колона
			dataGridView1.Columns["Title"].Width = 213;//прави колоните със същия размер като datagridview
		}

		private void bttNew_Click(object sender, EventArgs e)
		{
			txtTitle.Clear();//ресетва текста на полето
			txtMessage.Clear();//ресетва текста на полето
		}

		private void bttSave_Click(object sender, EventArgs e)
		{
			table.Rows.Add(txtTitle.Text, txtMessage.Text);//запазва добавения текст в таблицата
			txtTitle.Clear();//ресетва текста на полето
			txtMessage.Clear();//ресетва текста на полето
		}

		private void bttRead_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;//избира индекса на избрания ред
			if (index > -1)//ако индекса е повече от -1...
			{
				txtTitle.Text = table.Rows[index].ItemArray[0].ToString();//...показва запазения текст
				txtMessage.Text = table.Rows[index].ItemArray[1].ToString();//...показва запазения текст
			}
		}

		private void bttDelete_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;//избира индекса на избрания ред
			table.Rows[index].Delete();//изтрива датата
		}
	}
}
