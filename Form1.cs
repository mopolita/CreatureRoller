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
            // R�cup�rer les valeurs des TextBox et de la ComboBox
            string NbFor = textNbFor.Text; // Contenu de la 1�re TextBox
            string ModFor = textModFor.Text; // Contenu de la 2�me TextBox
            string comboForVal = comboFor.SelectedItem!.ToString(); // Valeur s�lectionn�e dans la ComboBox
        }
    }
}
