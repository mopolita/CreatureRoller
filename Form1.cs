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

        private void boutonSauver_Click(object sender, EventArgs e)
        {

        }

        private void BoutonGenerer_Click(object sender, EventArgs e)
        {
            Stat force = new Stat((int)numericUpDownNbFor.Value, comboFor.SelectedItem!.ToString(), (int)numericUpDownModFor.Value);
            Stat dex = new Stat((int)numericUpDownNbDex.Value, comboDex.SelectedItem!.ToString(), (int)numericUpDownModDex.Value);
            Stat con = new Stat((int)numericUpDownNbCon.Value, comboCon.SelectedItem!.ToString(), (int)numericUpDownModCon.Value);
            Stat pou = new Stat((int)numericUpDownNbPou.Value, comboPou.SelectedItem!.ToString(), (int)numericUpDownModPou.Value);
            Stat app = new Stat((int)numericUpDownNbApp.Value, comboApp.SelectedItem!.ToString(), (int)numericUpDownModApp.Value);
            Stat edu = new Stat((int)numericUpDownNbEdu.Value, comboEdu.SelectedItem!.ToString(), (int)numericUpDownModEdu.Value);

            textResFor.Text = force.Roll().ToString();
            textResDex.Text = dex.Roll().ToString();
            textResCon.Text = con.Roll().ToString();
            textResPou.Text = pou.Roll().ToString();
            textResApp.Text = app.Roll().ToString();
            textResEdu.Text = edu.Roll().ToString();
        }
    }
}
