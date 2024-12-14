namespace CreatureRoller 
{
	public class Groupe
	{
		private readonly List<string> comboRange = new List<string> { "d4", "d6", "d8", "d10", "d12", "d20", "d100" };

        public GroupBox StatBox;
		private NumericUpDown NumericUpDownNb;
		private ComboBox ComboStat;
		private NumericUpDown NumericUpDownMod;
		private readonly Label Resultat;
		private TextBox TextResultat;

		public Groupe(Stat stat, Point location)
		{
			StatBox = new GroupBox
			{
				Text = stat.Name,
				Location = location,
				Size = new Size(195, 60)
			};

			NumericUpDownNb = new NumericUpDown
			{
				Location = new Point(2, 1),
				ReadOnly = true,
				Size = new Size(48, 27),
				TabIndex = 0,
				Value = new decimal(new int[] { 1, 0, 0, 0 })
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

			Resultat = new Label
			{
				Location = new Point(2, 39),
				Text = "Résultat :",
				Size = new Size(69,20)
			};

			TextResultat = new TextBox
			{
				Location = new Point(74, 36),
				ReadOnly = true,
				Size = new Size(120, 27),
				TabIndex = 3
			};

			StatBox.Controls.Add(ComboStat);
            StatBox.Controls.Add(NumericUpDownNb);
            StatBox.Controls.Add(NumericUpDownMod);
			StatBox.Controls.Add(TextResultat);
			StatBox.Controls.Add(Resultat);
		}

		private int FacesToIndex(int faces)
        {
			int index = 0;
            switch (faces)
            {
                case 4:
					index = 0;
					break;
                case 6:
                    index = 1;
                    break;
                case 8:
                    index = 2;
                    break;
                case 10:
                    index = 3;
                    break;
				case 12:
                    index = 4;
                    break;
                case 20:
                    index = 5;
                    break;
				case 100:
                    index = 6;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
		}

		public void UpdateGroupe(Stat stat) 
		{
			NumericUpDownNb.Value = new decimal(stat.NumDice);
			NumericUpDownMod.Value = new decimal(stat.Modifier);
			StatBox.Text = stat.Name;
            ComboStat.SelectedIndex = FacesToIndex(stat.Faces);
        }
	}
}
