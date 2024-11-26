using System;
using System.Runtime;

namespace CreatureRoller
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Creature
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public List<Stat> StatList { get;set; }

		public Creature()
		{
			Name = "N/A";
			Description = string.Empty;
			StatList = new List<Stat>();
		}

		public Creature(string name,  string description, List<Stat> statList )
		{
			Name = name;
			Description = description;
			StatList = statList;
		}

		public void set_stat(Stat stat, string name, int NbDice, int Faces, int Modifier)
		{
			stat.Name = name;
			stat.NumDice = NbDice;
			stat.Faces = Faces;
			stat.Modifier = Modifier;
		}
	}
}
