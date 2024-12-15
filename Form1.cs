using System.Xml.Linq;

namespace CreatureRoller
{
	public partial class MainForm : Form
	{
		private readonly List<string> dice = new List<string> { "d4", "d6", "d8", "d10", "d12", "d20", "d100" };
		public List<Creature> Creatures;
		public List<Groupe> Groupes;

		public MainForm()
		{
			List<string> noms = new List<string> { "For" , "Dex" , "Con" , "Pou" , "App" , "Edu" };
			Groupe groupe;
			Stat stat = new Stat();
			int x, y;
			Creatures = new List<Creature>();
			Groupes = new List<Groupe>();
			for (int i = 0; i < 6; i++)
			{
				x = i%2==0 ? 136 : 462;
				y = 87 + 118 * (i/2);
				stat.Name = noms[i];
				groupe = new Groupe(stat, new Point(x, y));
				groupe.AddTo(this);
				Groupes.Add(groupe);
			}
			InitializeComponent();
		}

		private static List<Creature> LoadCreaturesFromXml(string filePath)
		{
			// Charger le fichier XML
			XDocument doc = XDocument.Load(filePath);

			// Utiliser LINQ pour extraire les créatures
			var creatures = doc.Descendants("Creature")
				.Select(c => new Creature(c.Element("Name")?.Value ?? "default_name", c.Element("Description")?.Value ?? "default_description",
					c.Descendants("Stat").Select(s => new Stat
					{
						Name = s.Element("Name")?.Value ?? "N/A",
						NumDice = int.Parse(s.Element("Dice")?.Value ?? "0"),
						Faces = int.Parse(s.Element("Faces")?.Value ?? "0"),
						Modifier = int.Parse(s.Element("Modifier")?.Value ?? "0")
					}).ToList()))
				.ToList();

			return creatures;
		}

		private void BoutonCharger_Click(object sender, EventArgs e)
		{
			// Créer une instance de OpenFileDialog
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Sélectionner un fichier XML",
				Filter = "Fichiers XML (*.xml)|*.xml", // Limiter aux fichiers .xml
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) // Répertoire initial
			};

			// Afficher la boîte de dialogue
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedFile = openFileDialog.FileName;

				try
				{
					// Appeler la méthode pour charger le fichier
					Creatures = LoadCreaturesFromXml(selectedFile);
					MessageBox.Show($"Fichier chargé avec succès : {selectedFile}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Erreur lors du chargement du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			foreach (var creature in Creatures)
			{
				if (creature.StatList.Count < 6)
				{
					for (int i = creature.StatList.Count; i < 6; i++)
					{
						creature.StatList.Add(new Stat());
					}
				}
				comboBoxCreatures.Items.Add(creature.Name);
			}

			comboBoxCreatures.SelectedIndex = 0;
		}

		private void boutonSauver_Click(object sender, EventArgs e)
		{

		}

		private void BoutonGenerer_Click(object sender, EventArgs e)
		{
            foreach (var groupe in Groupes)
            {
				groupe.Roll();
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
		{
            /*int selected = comboBoxName.SelectedIndex;
			Creature active = Creatures[selected];
			for (int i = 0; i < active.StatList.Count; i++)
			{
				Stats[i].NumDice = active.StatList[i].NumDice;
				Stats[i].Faces = active.StatList[i].Faces;
				Stats[i].Modifier = active.StatList[i].Modifier;
				// Should also change the two updowns and the combo, but that would require more work
				// Mayby by using the FormStat class*/
        }
    }
}
