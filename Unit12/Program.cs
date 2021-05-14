using System;
using System.Collections.Generic;
using System.Threading;

namespace Unit12
{
    class Program
    {
		static List<User> ListUser = new List<User>();

        static void Main(string[] args)
        {
			string Slogin;
			

			int FFind = 0;

			InitialList();

			do
			{
				do
				{
					Console.WriteLine("Введите логин:");
					Slogin = Console.ReadLine();
				}
				while (Slogin == null);

				foreach (User LUser in ListUser)
				{
					if (LUser.Login == Slogin)
					{
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Здравствуйте, {0}", LUser.Name);

						if (LUser.IsPremium == false)
						{
							Console.ForegroundColor = ConsoleColor.Blue;
							ShowAds();
							Console.ResetColor();
						}

						FFind = 1;
						Console.ResetColor();
						break;

					}
				}
				if (FFind == 0) { Console.WriteLine("Не найден пользователь с таким логином."); }
			}
			while (FFind == 0) ;

			Console.ReadLine();
		}

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}

		static void InitialList()
		{
			ListUser.Add(new User() { Name = "Василий", Login = "Vasy", IsPremium = true });
			ListUser.Add(new User() { Name = "Сергей", Login = "Ser21", IsPremium = false });
			ListUser.Add(new User() { Name = "Мария", Login = "Masha", IsPremium = true });
			ListUser.Add(new User() { Name = "Елена", Login = "Lena41", IsPremium = false });

		}

	}
}
