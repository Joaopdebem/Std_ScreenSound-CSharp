using System;

namespace ScreenSound.Menu.OpcoesMenu
{
	public class ListarMedias
	{
		public static void ExibirMediaDasBandas()
		{
			ExibirLogo.ExibirLogoMain();

			Console.Write("\n\nInforme a banda para exibir a média: ");
			string nomeBanda = Console.ReadLine()!;

			KeyValuePair<string, List<int>> bandaEncontrada = ProcurarBanda.Procurar(nomeBanda);

			if (ProcurarBanda.BandaEncontrada(bandaEncontrada))
			{
				List<int> notas = bandaEncontrada.Value;

				double mediaNotas = notas.Average();
				Console.WriteLine($"\n\nA media das notas da banda {nomeBanda} é {mediaNotas}");

				string resposta = "";
				while (resposta != "S" && resposta != "N")
				{
					Console.WriteLine("\n\nDeseja exibir todas notas? [S/N]\n");
					resposta = Console.ReadLine()!.ToUpper();

					if (resposta == "S")
					{
						Console.WriteLine($"\n\nTodas notas da banda {bandaEncontrada.Key}\n");

						foreach (var nota in notas)
						{
							Console.WriteLine($" - {nota}");
						}

					}
					else if (resposta == "N")
					{
						Console.Write("\n\n\nVoltando ao Menu...\n");
						Thread.Sleep(2000);
						ExibirMenu.ExibirOpcoesDoMenu();
						return;
					}
					else
					{
						Thread.Sleep(1500);
						Console.WriteLine("\nOpção Inválida, tente novamente.");
					}
				}

				Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\nPressione ESC para voltar ao menu...");
				Console.ReadKey();
				ExibirMenu.ExibirOpcoesDoMenu();
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
