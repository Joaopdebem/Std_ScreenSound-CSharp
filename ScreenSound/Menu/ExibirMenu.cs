using System;

using ScreenSound.Menu.OpcoesMenu;


namespace ScreenSound.Menu
{
	public class ExibirMenu
	{
		public static void ExibirOpcoesDoMenu()
		{
			ExibirLogo.ExibirLogoMain();
			Console.WriteLine(@"                  
   ▄█
    █  - Registrar uma Banda
   ▄█▄");
			Console.WriteLine(@"
   █▀█ 
    ▄▀ - Mostrar todas as Bandas
   █▄▄ ");
			Console.WriteLine(@"  
   ▀▀█ 
    ▀▄ - Avaliar uma Banda
   █▄█");
			Console.WriteLine(@"
   ▄▀█  
   █▄█▄ - Exibir a média das Bandas
     █");
			Console.WriteLine(@"
   █▀▀█ 
   █  █ - Sair
   █▄▄█");

			Console.Write("\nInforme a opção desejada:  ");

			int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

			switch (opcaoEscolhida)
			{
				case 1:
					Registrar.RegistrarBandas();
					break;
				case 2:
					ListarBandas.ExibirNomeDasBandas();
					break;
				case 3:
					Avaliar.AvaliarBandas();
					break;
				case 4:
					ListarMedias.ExibirMediaDasBandas();
					break;
				case 0:
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Opção Inválida. Tente novamente.");
					ExibirOpcoesDoMenu();
					break;
			}

		}
	}
}
