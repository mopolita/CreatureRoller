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
            Stat force = new Stat(textNbFor.Text, textModFor.Text, comboFor.SelectedItem!.ToString());
            Stat dex = new Stat(textNbDex.Text, textModDex.Text, comboDex.SelectedItem!.ToString());
            Stat con = new Stat(textNbCon.Text, textModCon.Text, comboCon.SelectedItem!.ToString());
            Stat pou = new Stat(textNbPou.Text, textModPou.Text, comboPou.SelectedItem!.ToString());
            Stat app = new Stat(textNbApp.Text, textModApp.Text, comboApp.SelectedItem!.ToString());
            Stat edu = new Stat(textNbEdu.Text, textModEdu.Text, comboEdu.SelectedItem!.ToString());
        }
    }
}
