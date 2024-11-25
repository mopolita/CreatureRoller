namespace CreatureRoller
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			boutonCharger = new Button();
			boutonSauver = new Button();
			boutonGenerer = new Button();
			numericUpDownNbFor = new NumericUpDown();
			comboFor = new ComboBox();
			numericUpDownModFor = new NumericUpDown();
			textResFor = new TextBox();
			numericUpDownNbDex = new NumericUpDown();
			comboDex = new ComboBox();
			numericUpDownModDex = new NumericUpDown();
			textResDex = new TextBox();
			numericUpDownNbCon = new NumericUpDown();
			comboCon = new ComboBox();
			numericUpDownModCon = new NumericUpDown();
			textResCon = new TextBox();
			numericUpDownNbPou = new NumericUpDown();
			comboPou = new ComboBox();
			numericUpDownModPou = new NumericUpDown();
			textResPou = new TextBox();
			numericUpDownNbApp = new NumericUpDown();
			comboApp = new ComboBox();
			numericUpDownModApp = new NumericUpDown();
			textResApp = new TextBox();
			numericUpDownNbEdu = new NumericUpDown();
			comboEdu = new ComboBox();
			numericUpDownModEdu = new NumericUpDown();
			textResEdu = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			comboBoxName = new ComboBox();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbFor).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModFor).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbDex).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModDex).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbCon).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModCon).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbPou).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModPou).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbApp).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModApp).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbEdu).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModEdu).BeginInit();
			SuspendLayout();
			// 
			// boutonCharger
			// 
			boutonCharger.Location = new Point(12, 12);
			boutonCharger.Name = "boutonCharger";
			boutonCharger.Size = new Size(126, 56);
			boutonCharger.TabIndex = 0;
			boutonCharger.Text = "Charger un fichier";
			boutonCharger.UseVisualStyleBackColor = true;
			boutonCharger.Click += BoutonCharger_Click;
			// 
			// boutonSauver
			// 
			boutonSauver.Location = new Point(653, 15);
			boutonSauver.Name = "boutonSauver";
			boutonSauver.Size = new Size(135, 53);
			boutonSauver.TabIndex = 1;
			boutonSauver.Text = "Sauvegarder un modèle";
			boutonSauver.UseVisualStyleBackColor = true;
			boutonSauver.Click += boutonSauver_Click;
			// 
			// boutonGenerer
			// 
			boutonGenerer.Location = new Point(324, 424);
			boutonGenerer.Name = "boutonGenerer";
			boutonGenerer.Size = new Size(138, 48);
			boutonGenerer.TabIndex = 18;
			boutonGenerer.Text = "Générer les statistiques";
			boutonGenerer.UseVisualStyleBackColor = true;
			boutonGenerer.Click += BoutonGenerer_Click;
			// 
			// numericUpDownNbFor
			// 
			numericUpDownNbFor.Location = new Point(136, 109);
			numericUpDownNbFor.Name = "numericUpDownNbFor";
			numericUpDownNbFor.ReadOnly = true;
			numericUpDownNbFor.Size = new Size(48, 27);
			numericUpDownNbFor.TabIndex = 52;
			numericUpDownNbFor.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// comboFor
			// 
			comboFor.DropDownStyle = ComboBoxStyle.DropDownList;
			comboFor.FormattingEnabled = true;
			comboFor.Location = new Point(190, 109);
			comboFor.Name = "comboFor";
			comboFor.Size = new Size(62, 28);
			comboFor.TabIndex = 2;
			// 
			// numericUpDownModFor
			// 
			numericUpDownModFor.Location = new Point(274, 109);
			numericUpDownModFor.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDownModFor.Name = "numericUpDownModFor";
			numericUpDownModFor.ReadOnly = true;
			numericUpDownModFor.Size = new Size(54, 27);
			numericUpDownModFor.TabIndex = 58;
			// 
			// textResFor
			// 
			textResFor.Location = new Point(208, 144);
			textResFor.Name = "textResFor";
			textResFor.ReadOnly = true;
			textResFor.Size = new Size(120, 27);
			textResFor.TabIndex = 64;
			// 
			// numericUpDownNbDex
			// 
			numericUpDownNbDex.Location = new Point(462, 109);
			numericUpDownNbDex.Name = "numericUpDownNbDex";
			numericUpDownNbDex.ReadOnly = true;
			numericUpDownNbDex.Size = new Size(48, 27);
			numericUpDownNbDex.TabIndex = 53;
			numericUpDownNbDex.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// comboDex
			// 
			comboDex.DropDownStyle = ComboBoxStyle.DropDownList;
			comboDex.FormattingEnabled = true;
			comboDex.Location = new Point(516, 109);
			comboDex.Name = "comboDex";
			comboDex.Size = new Size(62, 28);
			comboDex.TabIndex = 34;
			// 
			// numericUpDownModDex
			// 
			numericUpDownModDex.Location = new Point(600, 109);
			numericUpDownModDex.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDownModDex.Name = "numericUpDownModDex";
			numericUpDownModDex.ReadOnly = true;
			numericUpDownModDex.Size = new Size(54, 27);
			numericUpDownModDex.TabIndex = 63;
			// 
			// textResDex
			// 
			textResDex.Location = new Point(534, 144);
			textResDex.Name = "textResDex";
			textResDex.ReadOnly = true;
			textResDex.Size = new Size(120, 27);
			textResDex.TabIndex = 70;
			// 
			// numericUpDownNbCon
			// 
			numericUpDownNbCon.Location = new Point(136, 228);
			numericUpDownNbCon.Name = "numericUpDownNbCon";
			numericUpDownNbCon.ReadOnly = true;
			numericUpDownNbCon.Size = new Size(48, 27);
			numericUpDownNbCon.TabIndex = 54;
			numericUpDownNbCon.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// comboCon
			// 
			comboCon.DropDownStyle = ComboBoxStyle.DropDownList;
			comboCon.FormattingEnabled = true;
			comboCon.Location = new Point(190, 228);
			comboCon.Name = "comboCon";
			comboCon.Size = new Size(62, 28);
			comboCon.TabIndex = 26;
			// 
			// numericUpDownModCon
			// 
			numericUpDownModCon.Location = new Point(274, 228);
			numericUpDownModCon.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDownModCon.Name = "numericUpDownModCon";
			numericUpDownModCon.ReadOnly = true;
			numericUpDownModCon.Size = new Size(54, 27);
			numericUpDownModCon.TabIndex = 62;
			// 
			// textResCon
			// 
			textResCon.Location = new Point(208, 263);
			textResCon.Name = "textResCon";
			textResCon.ReadOnly = true;
			textResCon.Size = new Size(120, 27);
			textResCon.TabIndex = 66;
			// 
			// numericUpDownNbPou
			// 
			numericUpDownNbPou.Location = new Point(462, 228);
			numericUpDownNbPou.Name = "numericUpDownNbPou";
			numericUpDownNbPou.ReadOnly = true;
			numericUpDownNbPou.Size = new Size(48, 27);
			numericUpDownNbPou.TabIndex = 55;
			numericUpDownNbPou.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// comboPou
			// 
			comboPou.DropDownStyle = ComboBoxStyle.DropDownList;
			comboPou.FormattingEnabled = true;
			comboPou.Location = new Point(516, 228);
			comboPou.Name = "comboPou";
			comboPou.Size = new Size(62, 28);
			comboPou.TabIndex = 38;
			// 
			// numericUpDownModPou
			// 
			numericUpDownModPou.Location = new Point(600, 228);
			numericUpDownModPou.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDownModPou.Name = "numericUpDownModPou";
			numericUpDownModPou.ReadOnly = true;
			numericUpDownModPou.Size = new Size(54, 27);
			numericUpDownModPou.TabIndex = 59;
			// 
			// textResPou
			// 
			textResPou.Location = new Point(534, 263);
			textResPou.Name = "textResPou";
			textResPou.ReadOnly = true;
			textResPou.Size = new Size(120, 27);
			textResPou.TabIndex = 72;
			// 
			// numericUpDownNbApp
			// 
			numericUpDownNbApp.Location = new Point(136, 333);
			numericUpDownNbApp.Name = "numericUpDownNbApp";
			numericUpDownNbApp.ReadOnly = true;
			numericUpDownNbApp.Size = new Size(48, 27);
			numericUpDownNbApp.TabIndex = 56;
			numericUpDownNbApp.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// comboApp
			// 
			comboApp.DropDownStyle = ComboBoxStyle.DropDownList;
			comboApp.FormattingEnabled = true;
			comboApp.Location = new Point(190, 333);
			comboApp.Name = "comboApp";
			comboApp.Size = new Size(62, 28);
			comboApp.TabIndex = 30;
			// 
			// numericUpDownModApp
			// 
			numericUpDownModApp.Location = new Point(274, 333);
			numericUpDownModApp.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDownModApp.Name = "numericUpDownModApp";
			numericUpDownModApp.ReadOnly = true;
			numericUpDownModApp.Size = new Size(54, 27);
			numericUpDownModApp.TabIndex = 61;
			// 
			// textResApp
			// 
			textResApp.Location = new Point(208, 368);
			textResApp.Name = "textResApp";
			textResApp.ReadOnly = true;
			textResApp.Size = new Size(120, 27);
			textResApp.TabIndex = 68;
			// 
			// numericUpDownNbEdu
			// 
			numericUpDownNbEdu.Location = new Point(462, 333);
			numericUpDownNbEdu.Name = "numericUpDownNbEdu";
			numericUpDownNbEdu.ReadOnly = true;
			numericUpDownNbEdu.Size = new Size(48, 27);
			numericUpDownNbEdu.TabIndex = 57;
			numericUpDownNbEdu.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// comboEdu
			// 
			comboEdu.DropDownStyle = ComboBoxStyle.DropDownList;
			comboEdu.FormattingEnabled = true;
			comboEdu.Location = new Point(516, 333);
			comboEdu.Name = "comboEdu";
			comboEdu.Size = new Size(62, 28);
			comboEdu.TabIndex = 42;
			// 
			// numericUpDownModEdu
			// 
			numericUpDownModEdu.Location = new Point(600, 333);
			numericUpDownModEdu.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
			numericUpDownModEdu.Name = "numericUpDownModEdu";
			numericUpDownModEdu.ReadOnly = true;
			numericUpDownModEdu.Size = new Size(54, 27);
			numericUpDownModEdu.TabIndex = 60;
			// 
			// textResEdu
			// 
			textResEdu.Location = new Point(534, 368);
			textResEdu.Name = "textResEdu";
			textResEdu.ReadOnly = true;
			textResEdu.Size = new Size(120, 27);
			textResEdu.TabIndex = 74;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(253, 111);
			label1.Name = "label1";
			label1.Size = new Size(19, 20);
			label1.TabIndex = 25;
			label1.Text = "+";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(253, 230);
			label2.Name = "label2";
			label2.Size = new Size(19, 20);
			label2.TabIndex = 29;
			label2.Text = "+";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(253, 335);
			label3.Name = "label3";
			label3.Size = new Size(19, 20);
			label3.TabIndex = 33;
			label3.Text = "+";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(579, 111);
			label4.Name = "label4";
			label4.Size = new Size(19, 20);
			label4.TabIndex = 37;
			label4.Text = "+";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(579, 230);
			label5.Name = "label5";
			label5.Size = new Size(19, 20);
			label5.TabIndex = 41;
			label5.Text = "+";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(579, 335);
			label6.Name = "label6";
			label6.Size = new Size(19, 20);
			label6.TabIndex = 45;
			label6.Text = "+";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(136, 87);
			label7.Name = "label7";
			label7.Size = new Size(45, 20);
			label7.TabIndex = 46;
			label7.Text = "Force";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(462, 87);
			label8.Name = "label8";
			label8.Size = new Size(70, 20);
			label8.TabIndex = 47;
			label8.Text = "Dextérité";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(136, 205);
			label9.Name = "label9";
			label9.Size = new Size(89, 20);
			label9.TabIndex = 48;
			label9.Text = "Constitution";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(462, 205);
			label10.Name = "label10";
			label10.Size = new Size(58, 20);
			label10.TabIndex = 49;
			label10.Text = "Pouvoir";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(136, 310);
			label11.Name = "label11";
			label11.Size = new Size(81, 20);
			label11.TabIndex = 50;
			label11.Text = "Apparence";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(462, 310);
			label12.Name = "label12";
			label12.Size = new Size(75, 20);
			label12.TabIndex = 51;
			label12.Text = "Education";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(136, 147);
			label13.Name = "label13";
			label13.Size = new Size(69, 20);
			label13.TabIndex = 65;
			label13.Text = "Résultat :";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(136, 266);
			label14.Name = "label14";
			label14.Size = new Size(69, 20);
			label14.TabIndex = 67;
			label14.Text = "Résultat :";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(136, 371);
			label15.Name = "label15";
			label15.Size = new Size(69, 20);
			label15.TabIndex = 69;
			label15.Text = "Résultat :";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(462, 147);
			label16.Name = "label16";
			label16.Size = new Size(69, 20);
			label16.TabIndex = 71;
			label16.Text = "Résultat :";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(462, 266);
			label17.Name = "label17";
			label17.Size = new Size(69, 20);
			label17.TabIndex = 73;
			label17.Text = "Résultat :";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(462, 375);
			label18.Name = "label18";
			label18.Size = new Size(69, 20);
			label18.TabIndex = 75;
			label18.Text = "Résultat :";
			// 
			// comboBoxName
			// 
			comboBoxName.FormattingEnabled = true;
			comboBoxName.Location = new Point(324, 40);
			comboBoxName.Name = "comboBoxName";
			comboBoxName.Size = new Size(138, 28);
			comboBoxName.TabIndex = 76;
			comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 485);
			Controls.Add(comboBoxName);
			Controls.Add(label18);
			Controls.Add(textResEdu);
			Controls.Add(label17);
			Controls.Add(textResPou);
			Controls.Add(label16);
			Controls.Add(textResDex);
			Controls.Add(label15);
			Controls.Add(textResApp);
			Controls.Add(label14);
			Controls.Add(textResCon);
			Controls.Add(label13);
			Controls.Add(textResFor);
			Controls.Add(numericUpDownModDex);
			Controls.Add(numericUpDownModCon);
			Controls.Add(numericUpDownModApp);
			Controls.Add(numericUpDownModEdu);
			Controls.Add(numericUpDownModPou);
			Controls.Add(numericUpDownModFor);
			Controls.Add(numericUpDownNbEdu);
			Controls.Add(numericUpDownNbApp);
			Controls.Add(numericUpDownNbPou);
			Controls.Add(numericUpDownNbCon);
			Controls.Add(numericUpDownNbDex);
			Controls.Add(numericUpDownNbFor);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(comboEdu);
			Controls.Add(label5);
			Controls.Add(comboPou);
			Controls.Add(label4);
			Controls.Add(comboDex);
			Controls.Add(label3);
			Controls.Add(comboApp);
			Controls.Add(label2);
			Controls.Add(comboCon);
			Controls.Add(label1);
			Controls.Add(boutonGenerer);
			Controls.Add(comboFor);
			Controls.Add(boutonSauver);
			Controls.Add(boutonCharger);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Lovecraftian Creature Roller";
			((System.ComponentModel.ISupportInitialize)numericUpDownNbFor).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModFor).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbDex).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModDex).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbCon).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModCon).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbPou).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModPou).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbApp).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModApp).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNbEdu).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownModEdu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private void AddComboRanges()
		{
			comboFor.Items.AddRange(dice.ToArray());
			comboFor.SelectedIndex = 0;
			comboDex.Items.AddRange(dice.ToArray());
			comboDex.SelectedIndex = 0;
			comboCon.Items.AddRange(dice.ToArray());
			comboCon.SelectedIndex = 0;
			comboPou.Items.AddRange(dice.ToArray());
			comboPou.SelectedIndex = 0;
			comboApp.Items.AddRange(dice.ToArray());
			comboApp.SelectedIndex = 0;
			comboEdu.Items.AddRange(dice.ToArray());
			comboEdu.SelectedIndex = 0;
		}

		private readonly List<string> dice = new List<string> { "d4", "d6", "d8", "d10", "d12", "d20", "d100" };

		private Button boutonCharger;
		private Button boutonSauver;
		private Button boutonGenerer;
		
		private NumericUpDown numericUpDownNbFor;
		private ComboBox comboFor;
		private NumericUpDown numericUpDownModFor;
		private TextBox textResFor;

		private NumericUpDown numericUpDownNbDex;
		private ComboBox comboDex;
		private NumericUpDown numericUpDownModDex;
		private TextBox textResDex;        
		
		private NumericUpDown numericUpDownNbCon;
		private ComboBox comboCon;
		private NumericUpDown numericUpDownModCon;
		private TextBox textResCon;        
		
		private NumericUpDown numericUpDownNbPou;
		private ComboBox comboPou;
		private NumericUpDown numericUpDownModPou;
		private TextBox textResPou;        
		
		private NumericUpDown numericUpDownNbApp;
		private ComboBox comboApp;
		private NumericUpDown numericUpDownModApp;
		private TextBox textResApp;
		
		private NumericUpDown numericUpDownNbEdu;
		private ComboBox comboEdu;
		private NumericUpDown numericUpDownModEdu;
		private TextBox textResEdu;
		
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private ComboBox comboBoxName;
	}
}
