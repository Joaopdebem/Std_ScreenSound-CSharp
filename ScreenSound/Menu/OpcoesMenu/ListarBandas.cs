using System;

namespace ScreenSound.Menu.OpcoesMenu
{
	public class ListarBandas
	{
		public static void ExibirNomeDasBandas()
		{
			ExibirLogo.ExibirLogoMain();

			Console.WriteLine("\n\nTodas as bandas registradas: \n");

			List<string> bandas = Banda.infoBandas.Keys.ToList();

			foreach (string banda in bandas)
			{
				Console.WriteLine($"{bandas.IndexOf(banda)} - {banda}");
			}

			Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\nPressione ESC para voltar ao menu.");
			Console.ReadKey();
			ExibirMenu.ExibirOpcoesDoMenu();

		}
	}
}
