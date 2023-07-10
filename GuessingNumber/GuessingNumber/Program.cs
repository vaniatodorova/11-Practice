using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random(); //Създава масив
			int winNum = r.Next(0, 100); //печелившото число варира от 0-100
			bool win = false; //променлива bool за помощ с цикъла
			do //началото на цикъла
			{
				Console.WriteLine("Guess a number between 0 and 100:");
				//Записва съобщението в "" на екрана, което показва на потребителя какво да прави
				string s = Console.ReadLine();
				//въвежда каквото потребителят е написал в низова променлива
				int i = int.Parse(s);
				//преобразува низовата променлива в int променлива
				if (i > winNum) //ако познатото число е по-голямо от печелившото число...
				{
					Console.WriteLine("Too High! Guess lower..."); //...напиши това съобщение
				}
				else if (i < winNum) //ако познатото число е по-малко от печелившото число...
				{
					Console.WriteLine("Too Low! Guess higher..."); //...напиши това съобщение
				}
				else if (i == winNum) //ако познатото число е правилно...
				{
					Console.WriteLine("You Win!"); //...напиши това съобщение
					win = true; //спира цикъла
				}
			} while (win == false); //условия, по които цикъла работи
		}
	}
}
