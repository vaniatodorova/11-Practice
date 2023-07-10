using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingNumberWindowsForms
{
	public partial class Form1 : Form
	{
		Random randomNumber = new Random(); //Създава масив
		int number = 0; //Създава променлива от инт тип
		int guesses = 0; //Създава променлива от инт тип
		public Form1()
		{
			InitializeComponent();
			loadQuestions(); //Зарежда метод
		}

		private void CheckNumber(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(txtEnterNumber.Text); //преобразува низовата променлива в int променлива
			guesses += 1; //стойноста на променливата се увеличява с 1
			lblGuessed.Text = "You guessed " + guesses + " times"; //променя текста на етикета

			if (i == number) //ако познатото число е правилно...
			{
				MessageBox.Show("Nice, you guessed it. Try another"); //...напиши това съобщение
				loadQuestions(); //Зарежда метод
				txtEnterNumber.Text = ""; //Чисти полето за писане
				guesses = 0; //Рестетва променливата / задава стойност 0
			}
			else if (i<number) //ако познатото число е по-малко от печелившото число...
			{
				MessageBox.Show("Go Higher"); //...напиши това съобщение
			}
			else //ако познатото число е по-голямо от печелившото число...
			{
				MessageBox.Show("Go Lower"); //...напиши това съобщение
			}
		}

		private void loadQuestions() //Записва метод
		{
			number = randomNumber.Next(0, 10); //задава стойност на променливата от 0 до 10 включително

			lblQuestion.Text = "I am thinking of a number between 0-10"; //променя текста на етикета
		}
	}
}
