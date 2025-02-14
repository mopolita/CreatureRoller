namespace CreatureRoller 
{
	public class Groupe
	{
		private readonly List<string> comboRange = new List<string> { "d4", "d6", "d8", "d10", "d12", "d20", "d100" };

        private GroupBox StatBox;
		private NumericUpDown NumericUpDownNb;
		private ComboBox ComboStat;
		private NumericUpDown NumericUpDownMod;
		private TextBox TextResultat;
		private Stat Stat;

		public Groupe(Stat stat, Point location)
		{
            Label resultat = new Label
            {
                Location = new Point(1, 57),
                Text = "Résultat :",
                Size = new Size(69, 20)
            };

            Label plus = new Label
            {
                Location = new Point(122, 23),
                Text = "+",
                Size = new Size(15, 20)
            };

            Stat = stat;
			StatBox = new GroupBox
			{
				Text = stat.Name,
				Location = location,
				Size = new Size(200, 90)
			};

			NumericUpDownNb = new NumericUpDown
			{
				Location = new Point(2, 20),
				ReadOnly = true,
				Size = new Size(48, 27),
				TabIndex = 0,
				Value = new decimal(new int[] { 1, 0, 0, 0 })
			};

			ComboStat = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				FormattingEnabled = true,
				Location = new Point(56, 20),
				Name = "comboFor",
				Size = new Size(62, 27),
				TabIndex = 1
			};

			NumericUpDownMod = new NumericUpDown
			{
				Location = new Point(140, 20),
				ReadOnly = true,
				Size = new Size(54, 27),
				TabIndex = 2,
				Minimum = -100
			};

			ComboStat.Items.AddRange(comboRange.ToArray());
			ComboStat.SelectedIndex = 1;

			TextResultat = new TextBox
			{
				Location = new Point(74, 52),
				ReadOnly = true,
				Size = new Size(120, 27),
				TabIndex = 3
			};

			StatBox.Controls.Add(ComboStat);
            StatBox.Controls.Add(NumericUpDownNb);
            StatBox.Controls.Add(NumericUpDownMod);
			StatBox.Controls.Add(TextResultat);
			StatBox.Controls.Add(resultat);
			StatBox.Controls.Add(plus);
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
			Stat = stat;
			NumericUpDownNb.Value = new decimal(stat.NumDice);
			NumericUpDownMod.Value = new decimal(stat.Modifier);
			StatBox.Text = stat.Name;
            ComboStat.SelectedIndex = FacesToIndex(stat.Faces);
        }

		public void AddTo(Control control)
		{
			control.Controls.Add(StatBox);
		}

		public void RemoveFrom(Control control)
		{
			control.Controls.Remove(StatBox);
		}

		public void Roll()
		{
            Stat.NumDice = (int)NumericUpDownNb.Value;
            Stat.Faces = int.TryParse(ComboStat.SelectedItem!.ToString().TrimStart('d', 'D'), out int d) ? d : 0;
            Stat.Modifier = (int)NumericUpDownMod.Value;

            TextResultat.Text = Stat.Roll().ToString();
        }
	}
}
