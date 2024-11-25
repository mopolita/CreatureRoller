using System.Xml.Linq;

namespace CreatureRoller
{
	public partial class MainForm : Form
	{
		public List<Creature> Creatures;
		List<Stat> Stats;

		public MainForm()
		{
			Creatures = new List<Creature>();
			Stats = new List<Stat>() { new Stat(), new Stat(), new Stat(), new Stat(), new Stat(), new Stat() };
			Stats[0].Name = "Force";
            Stats[1].Name = "Dex";
            Stats[2].Name = "Con";
            Stats[3].Name = "Pou";
            Stats[4].Name = "App";
            Stats[5].Name = "Edu";
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
						Name = s.Element("Name")?.Value ?? "default_name",
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

			if (Creatures.Count < 6)
			{
				for (int i = Creatures.Count; i < 6; i++)
				{
					Creatures.Add(new Creature());
				}
			}
		}

		private void boutonSauver_Click(object sender, EventArgs e)
		{

		}

		private void BoutonGenerer_Click(object sender, EventArgs e)
		{
            Stats[0].NumDice = (int)numericUpDownNbFor.Value;
            Stats[0].Faces = int.TryParse(comboFor.SelectedItem!.ToString().TrimStart('d', 'D'), out int d) ? d : 0;
            Stats[0].Modifier = (int)numericUpDownModFor.Value;

            Stats[1].NumDice = (int)numericUpDownNbDex.Value;
            Stats[1].Faces = int.TryParse(comboDex.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Stats[1].Modifier = (int)numericUpDownModDex.Value;

            Stats[2].NumDice = (int)numericUpDownNbCon.Value;
            Stats[2].Faces = int.TryParse(comboCon.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Stats[2].Modifier = (int)numericUpDownModCon.Value;

            Stats[3].NumDice = (int)numericUpDownNbPou.Value;
            Stats[3].Faces = int.TryParse(comboPou.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Stats[3].Modifier = (int)numericUpDownModPou.Value;

            Stats[4].NumDice = (int)numericUpDownNbApp.Value;
            Stats[4].Faces = int.TryParse(comboApp.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Stats[4].Modifier = (int)numericUpDownModApp.Value;

            Stats[5].NumDice = (int)numericUpDownNbEdu.Value;
            Stats[5].Faces = int.TryParse(comboEdu.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Stats[5].Modifier = (int)numericUpDownModEdu.Value;

			textResFor.Text = Stats[0].Roll().ToString();
			textResDex.Text = Stats[1].Roll().ToString();
			textResCon.Text = Stats[2].Roll().ToString();
			textResPou.Text = Stats[3].Roll().ToString();
			textResApp.Text = Stats[4].Roll().ToString();
			textResEdu.Text = Stats[5].Roll().ToString();
		}
	}
}
