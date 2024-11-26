using System;

namespace CreatureRoller 
{
    public class Groupe
    {
        public GroupBox StatBox;
        private NumericUpDown NumericUpDownNb;
        private ComboBox ComboStat;
        private NumericUpDown NumericUpDownMod;
        private Label Resultat;
        private TextBox TextResultat;

        private Stat Stat;

        public Groupe(Stat stat, List<string> comboRange, Point location)
        {
            Stat = stat;

            StatBox = new GroupBox
            {
                Text = Stat.Name,
                Location = location,
                Size = new Size(195, 60)
            };

            NumericUpDownNb = new NumericUpDown
            {
                Location = new Point(2, 1),
                ReadOnly = true,
                Size = new Size(48, 27),
                TabIndex = 0,
                Value = new decimal(new int[] { 1, 0, 0, 0 }),
            };

            ComboStat = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true,
                Location = new Point(56, 1),
                Name = "comboFor",
                Size = new Size(62, 27),
                TabIndex = 1
            };

            NumericUpDownMod = new NumericUpDown
            {
                Location = new Point(140, 1),
                ReadOnly = true,
                Size = new Size(54, 27),
                TabIndex = 2
            };

            ComboStat.Items.AddRange(comboRange.ToArray());
            ComboStat.SelectedIndex = 0;
        }
    }
}
