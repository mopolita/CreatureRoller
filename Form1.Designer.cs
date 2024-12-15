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
            comboBoxCreatures = new ComboBox();
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
            // comboBoxCreatures
            // 
            comboBoxCreatures.FormattingEnabled = true;
            comboBoxCreatures.Location = new Point(324, 40);
            comboBoxCreatures.Name = "comboBoxCreatures";
            comboBoxCreatures.Size = new Size(138, 28);
            comboBoxCreatures.TabIndex = 76;
            comboBoxCreatures.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(comboBoxCreatures);
            Controls.Add(boutonGenerer);
            Controls.Add(boutonSauver);
            Controls.Add(boutonCharger);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Lovecraftian Creature Roller";
            ResumeLayout(false);
        }

        #endregion

        private Button boutonCharger;
		private Button boutonSauver;
		private Button boutonGenerer;
		private ComboBox comboBoxCreatures;
	}
}
