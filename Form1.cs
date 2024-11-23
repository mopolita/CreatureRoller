namespace CreatureRoller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BoutonCharger_Click(object sender, EventArgs e)
        {

        }

        private void BoutonGenerer_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des TextBox et de la ComboBox
            string NbFor = textNbFor.Text; // Contenu de la 1ère TextBox
            string ModFor = textModFor.Text; // Contenu de la 2ème TextBox
            string comboForVal = comboFor.SelectedItem!.ToString(); // Valeur sélectionnée dans la ComboBox
        }
    }
}
