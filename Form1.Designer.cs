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
            textNbFor = new TextBox();
            comboFor = new ComboBox();
            textModFor = new TextBox();
            textNbDex = new TextBox();
            comboDex = new ComboBox();
            textModDex = new TextBox();
            textNbCon = new TextBox();
            comboCon = new ComboBox();
            textModCon = new TextBox();
            textNbPou = new TextBox();
            comboPou = new ComboBox();
            textModPou = new TextBox();
            textNbApp = new TextBox();
            comboApp = new ComboBox();
            textModApp = new TextBox();
            textNbEdu = new TextBox();
            comboEdu = new ComboBox();
            textModEdu = new TextBox();
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
            SuspendLayout();

            List<string> dice = new List<string> { "d4", "d6", "d8", "d10", "d12", "d20", "d100" };

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
            // 
            // boutonGenerer
            // 
            boutonGenerer.Location = new Point(298, 444);
            boutonGenerer.Name = "boutonGenerer";
            boutonGenerer.Size = new Size(180, 29);
            boutonGenerer.TabIndex = 18;
            boutonGenerer.Text = "Générer les statisiques";
            boutonGenerer.UseVisualStyleBackColor = true;
            boutonGenerer.Click += BoutonGenerer_Click;
            // 
            // textNbFor
            // 
            textNbFor.Location = new Point(136, 112);
            textNbFor.Name = "textNbFor";
            textNbFor.Size = new Size(46, 27);
            textNbFor.TabIndex = 7;
            //
            // comboFor
            //
            comboFor.Items.AddRange(dice.ToArray());
            comboFor.SelectedIndex = 0;
            comboFor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFor.FormattingEnabled = true;
            comboFor.Location = new Point(188, 112);
            comboFor.Name = "comboFor";
            comboFor.Size = new Size(70, 28);
            comboFor.TabIndex = 2;
            // 
            // textModFor
            // 
            textModFor.Location = new Point(285, 112);
            textModFor.Name = "textModFor";
            textModFor.Size = new Size(31, 27);
            textModFor.TabIndex = 19;
            // 
            // textNbDex
            // 
            textNbDex.Location = new Point(487, 109);
            textNbDex.Name = "textNbDex";
            textNbDex.Size = new Size(46, 27);
            textNbDex.TabIndex = 35;
            // 
            // comboDex
            //
            comboDex.Items.AddRange(dice.ToArray());
            comboDex.SelectedIndex = 0;
            comboDex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDex.FormattingEnabled = true;
            comboDex.Location = new Point(539, 109);
            comboDex.Name = "comboDex";
            comboDex.Size = new Size(75, 28);
            comboDex.TabIndex = 34;
            // 
            // textModDex
            // 
            textModDex.Location = new Point(639, 109);
            textModDex.Name = "textModDex";
            textModDex.Size = new Size(31, 27);
            textModDex.TabIndex = 36;
            // 
            // textNbCon
            // 
            textNbCon.Location = new Point(136, 228);
            textNbCon.Name = "textNbCon";
            textNbCon.Size = new Size(46, 27);
            textNbCon.TabIndex = 27;
            // 
            // comboCon
            // 
            comboCon.Items.AddRange(dice.ToArray());
            comboCon.SelectedIndex = 0;
            comboCon.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCon.FormattingEnabled = true;
            comboCon.Location = new Point(188, 228);
            comboCon.Name = "comboCon";
            comboCon.Size = new Size(70, 28);
            comboCon.TabIndex = 26;
            // 
            // textModCon
            // 
            textModCon.Location = new Point(285, 228);
            textModCon.Name = "textModCon";
            textModCon.Size = new Size(31, 27);
            textModCon.TabIndex = 28;
            // 
            // textNbPou
            // 
            textNbPou.Location = new Point(487, 229);
            textNbPou.Name = "textNbPou";
            textNbPou.Size = new Size(46, 27);
            textNbPou.TabIndex = 39;
            // 
            // comboPou
            // 
            comboPou.Items.AddRange(dice.ToArray());
            comboPou.SelectedIndex = 0;
            comboPou.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPou.FormattingEnabled = true;
            comboPou.Location = new Point(539, 229);
            comboPou.Name = "comboPou";
            comboPou.Size = new Size(75, 28);
            comboPou.TabIndex = 38;
            // 
            // textModPou
            // 
            textModPou.Location = new Point(639, 229);
            textModPou.Name = "textModPou";
            textModPou.Size = new Size(31, 27);
            textModPou.TabIndex = 40;
            // 
            // textNbApp
            // 
            textNbApp.Location = new Point(136, 333);
            textNbApp.Name = "textNbApp";
            textNbApp.Size = new Size(46, 27);
            textNbApp.TabIndex = 31;
            // 
            // comboApp
            //
            comboApp.Items.AddRange(dice.ToArray());
            comboApp.SelectedIndex = 0;
            comboApp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboApp.FormattingEnabled = true;
            comboApp.Location = new Point(188, 333);
            comboApp.Name = "comboApp";
            comboApp.Size = new Size(70, 28);
            comboApp.TabIndex = 30;
            // 
            // textModApp
            // 
            textModApp.Location = new Point(285, 333);
            textModApp.Name = "textModApp";
            textModApp.Size = new Size(31, 27);
            textModApp.TabIndex = 32;
            // 
            // textNbEdu
            // 
            textNbEdu.Location = new Point(487, 333);
            textNbEdu.Name = "textNbEdu";
            textNbEdu.Size = new Size(46, 27);
            textNbEdu.TabIndex = 43;
            // 
            // comboEdu
            //
            comboEdu.Items.AddRange(dice.ToArray());
            comboEdu.SelectedIndex = 0;
            comboEdu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEdu.FormattingEnabled = true;
            comboEdu.Location = new Point(539, 333);
            comboEdu.Name = "comboEdu";
            comboEdu.Size = new Size(75, 28);
            comboEdu.TabIndex = 42;
            // 
            // textModEdu
            // 
            textModEdu.Location = new Point(639, 333);
            textModEdu.Name = "textModEdu";
            textModEdu.Size = new Size(31, 27);
            textModEdu.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 116);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 25;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 232);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 29;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 337);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 33;
            label3.Text = "+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 113);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 37;
            label4.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 233);
            label5.Name = "label5";
            label5.Size = new Size(19, 20);
            label5.TabIndex = 41;
            label5.Text = "+";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(618, 337);
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
            label8.Location = new Point(487, 87);
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
            label10.Location = new Point(487, 205);
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
            label12.Location = new Point(487, 310);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 51;
            label12.Text = "Education";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textModEdu);
            Controls.Add(textNbEdu);
            Controls.Add(comboEdu);
            Controls.Add(label5);
            Controls.Add(textModPou);
            Controls.Add(textNbPou);
            Controls.Add(comboPou);
            Controls.Add(label4);
            Controls.Add(textModDex);
            Controls.Add(textNbDex);
            Controls.Add(comboDex);
            Controls.Add(label3);
            Controls.Add(textModApp);
            Controls.Add(textNbApp);
            Controls.Add(comboApp);
            Controls.Add(label2);
            Controls.Add(textModCon);
            Controls.Add(textNbCon);
            Controls.Add(comboCon);
            Controls.Add(label1);
            Controls.Add(textModFor);
            Controls.Add(boutonGenerer);
            Controls.Add(textNbFor);
            Controls.Add(comboFor);
            Controls.Add(boutonSauver);
            Controls.Add(boutonCharger);
            Name = "MainForm";
            Text = "Lovecraftian Creature Roller";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boutonCharger;
        private Button boutonSauver;
        private ComboBox comboFor;
        private TextBox textNbFor;
        private Button boutonGenerer;
        private TextBox textModFor;
        private Label label1;
        private Label label2;
        private TextBox textModCon;
        private TextBox textNbCon;
        private ComboBox comboCon;
        private Label label3;
        private TextBox textModApp;
        private TextBox textNbApp;
        private ComboBox comboApp;
        private Label label4;
        private TextBox textModDex;
        private TextBox textNbDex;
        private ComboBox comboDex;
        private Label label5;
        private TextBox textModPou;
        private TextBox textNbPou;
        private ComboBox comboPou;
        private Label label6;
        private TextBox textModEdu;
        private TextBox textNbEdu;
        private ComboBox comboEdu;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
