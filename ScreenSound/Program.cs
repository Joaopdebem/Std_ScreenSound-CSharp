using ScreenSound;
using ScreenSound.Menu;
using System;

public class Program
{
	public static void Main()
	{
		//ExibirMenu.ExibirOpcoesDoMenu();

		Musica musica01 = new Musica(
			"The Girl",
			"City and Colours",
			360F,
			true
			);

		Musica musica02 = new Musica(
			"Last Resort",
			"Papa Roach",
			240F,
			false
			);

		musica01.ExibirFichaTecnica();
		musica02.ExibirFichaTecnica();

		Console.Write("Pressione ESC para sair...");
		Console.ReadKey();
	}

}