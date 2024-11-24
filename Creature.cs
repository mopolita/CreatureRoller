using System;

namespace CreatureRoller
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class Creature
	{
		public string Name { get; }
		public Stat For { get; }
		public Stat Dex { get; }
		public Stat Con { get; }
		public Stat Pou { get; }
		public Stat App { get; }
		public Stat Edu { get; }

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
	}
}
