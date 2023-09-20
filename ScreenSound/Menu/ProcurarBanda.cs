using System;
using System.Collections.Generic;

namespace ScreenSound.Menu
{
	public class ProcurarBanda
	{
		public static KeyValuePair<string, List<int>> Procurar(string nomeBanda)
		{
			foreach (var kvp in Banda.infoBandas)
			{
				if (kvp.Key.Equals(nomeBanda, StringComparison.OrdinalIgnoreCase))
				{
					return kvp;
				}
			}

			return default(KeyValuePair<string, List<int>>);
		}

		public static bool BandaEncontrada(KeyValuePair<string, List<int>> banda)
		{
			return !banda.Equals(default(KeyValuePair<string, List<int>>));
		}

	}
}
