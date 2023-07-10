using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:mm"); //задава формата на часа,
			lblSecond.Text = DateTime.Now.ToString("ss"); //на секундите,
			lblDate.Text = DateTime.Now.ToString("MMM dd yyyy"); //на датата,
			lblDay.Text = DateTime.Now.ToString("dddd"); //на деня от седмицата
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer.Start(); //стартира таймера
		}
	}
}
