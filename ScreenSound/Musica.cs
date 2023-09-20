using System;

namespace ScreenSound
{
	public class Musica
	{
		public string? nome;
		public string? artista;
		public float duracao;
		public Boolean disponivel;

		public void ExibirFichaTecnica()
		{
			Console.WriteLine($"Nome: {nome}");
			Console.WriteLine($"Artista: {artista}");
			Console.WriteLine($"Duração: {duracao}");
			if (disponivel)
			{
				Console.WriteLine("Disponível no plano.\n\n");
			}
			else
			{
				Console.WriteLine("Adquira o plano Plus+\n\n");
			}
		}

		public Musica(string nome, string artista, float duracao, Boolean disponivel)
		{
			this.nome = nome;
			this.artista = artista;
			this.duracao = duracao;
			this.disponivel = disponivel;
		}



	}
}
