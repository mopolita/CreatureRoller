namespace CreatureRoller
{
    public partial class MainForm : Form
    {
        List<Creature> Creatures;
        private Stat For;
        private Stat Dex;
        private Stat Con;
        private Stat Pou;
        private Stat App;
        private Stat Edu;

        public MainForm()
        {
            Creatures = new List<Creature>();
            For = new Stat();
            Dex = new Stat();
            Con = new Stat();
            Pou = new Stat();
            App = new Stat();
            Edu = new Stat();
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
            For.NumDice = (int)numericUpDownNbFor.Value;
            For.Faces = int.TryParse(comboFor.SelectedItem!.ToString().TrimStart('d', 'D'), out int d) ? d : 0;
            For.Modifier = (int)numericUpDownModFor.Value;

            Dex.NumDice = (int)numericUpDownNbDex.Value;
            Dex.Faces = int.TryParse(comboDex.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Dex.Modifier = (int)numericUpDownModDex.Value;

            Con.NumDice = (int)numericUpDownNbCon.Value;
            Con.Faces = int.TryParse(comboCon.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Con.Modifier = (int)numericUpDownModCon.Value;

            Pou.NumDice = (int)numericUpDownNbPou.Value;
            Pou.Faces = int.TryParse(comboPou.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Pou.Modifier = (int)numericUpDownModPou.Value;

            App.NumDice = (int)numericUpDownNbApp.Value;
            App.Faces = int.TryParse(comboApp.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            App.Modifier = (int)numericUpDownModApp.Value;

            Edu.NumDice = (int)numericUpDownNbEdu.Value;
            Edu.Faces = int.TryParse(comboEdu.SelectedItem!.ToString().TrimStart('d', 'D'), out d) ? d : 0;
            Edu.Modifier = (int)numericUpDownModEdu.Value;

            textResFor.Text = For.Roll().ToString();
            textResDex.Text = Dex.Roll().ToString();
            textResCon.Text = Con.Roll().ToString();
            textResPou.Text = Pou.Roll().ToString();
            textResApp.Text = App.Roll().ToString();
            textResEdu.Text = Edu.Roll().ToString();
        }
    }
}
