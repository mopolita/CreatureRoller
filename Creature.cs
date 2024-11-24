using System;
using System.Runtime;

namespace CreatureRoller
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Creature
	{
		public string Name { get; }
		protected Stat For { get; }
		protected Stat Dex { get; }
		protected Stat Con { get; }
		protected Stat Pou { get; }
		protected Stat App { get; }
		protected Stat Edu { get; }

		public Creature()
		{
			Name = "";
			For = new Stat();
			Dex = new Stat();
			Con = new Stat();
			Pou = new Stat();
			App = new Stat();
			Edu = new Stat();
		}

		public Creature(string name,  Stat force, Stat dex, Stat con, Stat pou, Stat app, Stat edu)
		{
			Name = name;
			For = force;
			Dex = dex;
			Con = con;
			Pou = pou;
			App = app;
			Edu = edu;
		}

		public void set_stat(Stat stat, int NbDice, int Faces, int Modifier)
		{
			stat.NumDice = NbDice;
			stat.Faces = Faces;
			stat.Modifier = Modifier;
		}
	}
}
