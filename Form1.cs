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
            Stat force = new Stat((int)numericUpDownFor.Value, textModFor.Text, comboFor.SelectedItem!.ToString());
            Stat dex = new Stat((int)numericUpDownDex.Value, textModDex.Text, comboDex.SelectedItem!.ToString());
            Stat con = new Stat((int)numericUpDownCon.Value, textModCon.Text, comboCon.SelectedItem!.ToString());
            Stat pou = new Stat((int)numericUpDownPou.Value, textModPou.Text, comboPou.SelectedItem!.ToString());
            Stat app = new Stat((int)numericUpDownApp.Value, textModApp.Text, comboApp.SelectedItem!.ToString());
            Stat edu = new Stat((int)numericUpDownEdu.Value, textModEdu.Text, comboEdu.SelectedItem!.ToString());
        }
    }
}
