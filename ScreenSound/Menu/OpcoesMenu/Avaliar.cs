using System;

namespace ScreenSound.Menu.OpcoesMenu
{
	public class Avaliar
	{
		public static void AvaliarBandas()
		{
			ExibirLogo.ExibirLogoMain();

			Console.Write("\n\nInforme o nome da banda que deseja avaliar: ");
			string nomeBanda = Console.ReadLine()!;

			KeyValuePair<string, List<int>> bandaEncontrada = ProcurarBanda.Procurar(nomeBanda);

			if (ProcurarBanda.BandaEncontrada(bandaEncontrada))
			{
				string nomeBandaEncontrada = bandaEncontrada.Key;

				Console.Write($"\n\nAvalie a banda {nomeBanda} de 0 a 5: ");
				int notaBanda = int.Parse(Console.ReadLine()!);

				Console.WriteLine($"\n\nConfirma a avaliação de {nomeBanda} com nota {notaBanda}? [S/N]\n\n");
				string confirmaAvaliacao = Console.ReadLine()!.ToUpper();

				switch (confirmaAvaliacao)
				{
					case "S":
						Console.WriteLine("\nAvaliação Registrada");
						Banda.infoBandas[nomeBandaEncontrada].Add(notaBanda);
						Console.Write("\n\nRetornando ao menu principal...");
						Thread.Sleep(2000);
						ExibirMenu.ExibirOpcoesDoMenu();
						break;
					case "N":
						AvaliarBandas();
						break;
					default:
						Console.WriteLine("Opção inválida. Tente novamente!");
						AvaliarBandas();
						break;
				}
			}
			else
			{
				Console.Write("\n\nBanda não encontrada. \n\nVoltando ao Menu...\n");
				Thread.Sleep(2000);
				ExibirMenu.ExibirOpcoesDoMenu();
			}
		}
	}
}
