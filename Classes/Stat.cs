﻿namespace CreatureRoller
{
	public class Stat
	{
		private static Random random = new Random();
		public string Name { get; set; }
		public int NumDice { get; set; }
		public int Faces { get; set; }
		public int Modifier { get; set; }

		/// <summary>
		/// Constructeur qui prend les valeurs sous forme de chaînes
		/// </summary>
		/// <param name="numDice">le nombre de dés à lancer</param>
		/// <param name="faces">le nombre de faces d'un dé</param>
		/// <param name="modifier">le modificateur du dé (peut être négatif)</param>
		/// <param name="name">le nom de la statistique</param>
		public Stat( int numDice, int faces, int modifier, string name = "default_name")
		{
			Name = name;
			NumDice = numDice;
			Faces = faces;
			Modifier = modifier;
		}

		public Stat()
		{
			Name = "default_name";
			NumDice = 1;
			Faces = 6;
			Modifier = 1;
		}

		/// <summary>
		/// Calcule le résultat d'un lancer de dé sous la forme NumDice * dFaces + Modifier (ex 3d6+5)
		/// </summary>
		/// <returns>le résultat calculé</returns>
		public int Roll()
		{
			int total = Modifier;
			for (int i = 0; i < NumDice; i++)
			{
				total += random.Next(1, Faces + 1);
			}
			return total * 5;
		}

		// Méthode pour afficher la stat
		public override string ToString()
		{
			return $"{Name} : {NumDice}d{Faces} + {Modifier}";
		}
	}
}
