using System;
using System.Threading;

namespace ScreenSound.Menu.OpcoesMenu
{
	public class Registrar
	{
		public static void RegistrarBandas()
		{
			ExibirLogo.ExibirLogoMain();

			while (true)
			{
				Console.Write("\n\nInforme o nome da banda que deseja registrar: ");
				string nomeBanda = Console.ReadLine()!;

				if (BandaJaCadastrada(nomeBanda))
				{
					Console.Write("\n\nBanda já cadastrada. \n\nTente novamente...\n");
					Thread.Sleep(1400);
				}
				else
				{
					string confirmaRegistro = "";
					do
					{
						Console.WriteLine($"\n\nConfirma o registro de {nomeBanda}? [S/N]\n\n");
						confirmaRegistro = Console.ReadLine()!.ToUpper();

						switch (confirmaRegistro)
						{
							case "S":
								Console.WriteLine("\nBanda Registrada");
								Banda.infoBandas.Add(nomeBanda, new List<int>());
								Console.Write("\n\nRetornando ao menu principal...");
								Thread.Sleep(2000);
								ExibirMenu.ExibirOpcoesDoMenu();
								return;
							case "N":
								break;
							default:
								Console.WriteLine("\nOpção Inválida. Tente novamente.");
								continue;
						}
					} while (confirmaRegistro != "S" && confirmaRegistro != "N");
				}
			}
		}

		private static bool BandaJaCadastrada(string nomeBanda)
		{
			return Banda.infoBandas.Keys.Any(k => k.Equals(nomeBanda, StringComparison.OrdinalIgnoreCase));
		}
	}
}
