namespace CreatureRoller
{

	public class NameInputForm : Form
	{
		private TextBox nameTextBox;
		private Button okButton;
		private Button cancelButton;

		public string EnteredName { get; private set; }

		public NameInputForm()
		{
			EnteredName = "";
			Text = "Entrez un nom";
			Size = new Size(300, 150);
			StartPosition = FormStartPosition.CenterParent;
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;

			// TextBox pour entrer le nom
			nameTextBox = new TextBox
			{
				Location = new Point(10, 10),
				Width = 260
			};

			// Bouton OK
			okButton = new Button
			{
				Text = "OK",
				Location = new Point(100, 50),
				DialogResult = DialogResult.OK,
				Size = new Size(75, 25)
			};
			okButton.Click += OkButton_Click;

			// Bouton Annuler
			cancelButton = new Button
			{
				Text = "Annuler",
				Location = new Point(180, 50),
				DialogResult = DialogResult.Cancel,
				Size = new Size(75, 25)
			};
			cancelButton.Click += (sender, e) => Close();

			Controls.Add(nameTextBox);
			Controls.Add(okButton);
			Controls.Add(cancelButton);

			AcceptButton = okButton; // Permet d'utiliser Entrée pour valider
			CancelButton = cancelButton; // Permet d'utiliser Échap pour annuler
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			EnteredName = nameTextBox.Text; // Récupérer le texte entré
			DialogResult = DialogResult.OK; // Indiquer que l'utilisateur a validé
			Close();
		}
	}
}