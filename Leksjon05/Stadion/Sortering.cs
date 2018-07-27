using System;

namespace Tribune
{
	/// <summary>
	/// Sortering er en klasse for sortering av generelle objekter.
	/// Ved kall til sorter() må en sammenligningsmetode sendes med en delegat.
	/// </summary>
	public class Sortering
	{
		public delegate bool Sammenligner(Object o1, Object t2);

		public static void sorter(Object[] tabell, Sammenligner Sml) 
		{
			for (int i=0; i < tabell.Length; i++) 
			{
				for (int j=0; j < tabell.Length - 1; j++) 
				{
					if (Sml(tabell[j], tabell[j+1])) bytt(tabell, j, j+1);
				}
			}
		}
		private static void bytt(Object[] tabell, int i, int j) 
		{
			Object temp = tabell[i];
			tabell[i] = tabell[j];
			tabell[j] = temp;
		}
	}
}
