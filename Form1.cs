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

			Stat stat = new Stat();
			Creatures = new List<Creature>();
			Groupes = new List<Groupe>();
			for (int i = 0; i < 6; i++)
			{
				stat.Name = noms[i];
				Addgroupe(stat, i);
			}
			InitializeComponent();
		}

		private void Addgroupe(Stat stat, int number)
		{
			int x, y;
			Groupe groupe;
			x = number % 2 == 0 ? 136 : 462;
			y = 87 + 118 * (number / 2);
			groupe = new Groupe(stat, new Point(x, y));
			groupe.AddTo(this);
			Groupes.Add(groupe);
		}

		private void RemoveGroupe(int index)
		{
			Groupes[index].RemoveFrom(this);
			Groupes.RemoveAt(index);
		}

		private void LoadCreaturesFromXml(string filePath)
		{
			// charge le fichier XML
			XDocument doc = XDocument.Load(filePath);

			// extrait les créatures
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
			Creatures = creatures;
		}

		private void BoutonCharger_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Sélectionner un fichier XML",
				Filter = "Fichiers XML (*.xml)|*.xml", // Limiter aux fichiers .xml
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedFile = openFileDialog.FileName;
				try
				{
					LoadCreaturesFromXml(selectedFile);
					MessageBox.Show($"Fichier chargé avec succès : {selectedFile}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Erreur lors du chargement du fichier : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			foreach (var creature in Creatures)
			{
				comboBoxCreatures.Items.Add(creature.Name);
			}
			comboBoxCreatures.SelectedIndex = 0;
		}

		private void BoutonSauver_Click(object sender, EventArgs e)
		{

		}

		private void BoutonGenerer_Click(object sender, EventArgs e)
		{
			foreach (var groupe in Groupes)
			{
				groupe.Roll();
			}
		}

		private void ComboBoxCreatures_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = 0;
			int selected = comboBoxCreatures.SelectedIndex;
			Creature active = Creatures[selected];
			int groupeSize = Groupes.Count;
			int statListSize = active.StatList.Count;
			// Ajoute des groupes de stats jusqu'a en avoir le même nombre que celui des stats des créatures
			for (i = 0; i < statListSize - groupeSize; i++)
			{
				Addgroupe(active.StatList[i], i + groupeSize);
			}
			// Enlève des groupes de stats jusqu'a en avoir le même nombre que celui des stats des créatures
			groupeSize = Groupes.Count;
			while (statListSize != groupeSize)
			{
				RemoveGroupe(groupeSize - 1);
				groupeSize = Groupes.Count;
			}
			for (i = 0; i < statListSize; i++)
			{
				Groupes[i].UpdateGroupe(active.StatList[i]);
			}
		}
	}
}
