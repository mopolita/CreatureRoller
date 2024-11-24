using System.Xml.Linq;

namespace CreatureRoller
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
		static List<Creature> LoadCreaturesFromXml(string filePath)
		{
			// Charger le fichier XML
			XDocument doc = XDocument.Load(filePath);

			// Utiliser LINQ pour extraire les créatures
			var creatures = doc.Descendants("Creature")
				.Select(c => new Creature(c.Element("Name")?.Value ?? "default_name",c.Element("Description")?.Value ?? "default_description",
					c.Descendants("Stat").Select(s => new Stat
					{
						Name = s.Element("Name")?.Value ?? "default_name",
						NumDice = int.Parse(s.Element("Dice")?.Value ?? "0"),
						Faces = int.Parse(s.Element("Faces")?.Value ?? "0"),
						Modifier = int.Parse(s.Element("Modifier")?.Value ?? "0")
					}).ToList()))
				.ToList();

			return creatures;
		}
	}
}