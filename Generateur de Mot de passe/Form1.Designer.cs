namespace Generateur_de_Mot_de_passe
{
    partial class Form1
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
            Nouveau = new Button();
            Modifier = new Button();
            Sauvegarder = new Button();
            Effacer = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Titre = new Label();
            Description = new Label();
            textBox1 = new TextBox();
            Motdepasse = new Label();
            Affichermdp = new CheckBox();
            copier = new Button();
            generermdp = new Button();
            groupBox1 = new GroupBox();
            checkchiffre = new CheckBox();
            checkcar = new CheckBox();
            checkmaj = new CheckBox();
            longueurmdp = new Label();
            longueur = new Label();
            trackbar = new TrackBar();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackbar).BeginInit();
            SuspendLayout();
            // 
            // Nouveau
            // 
            Nouveau.Location = new Point(92, 3);
            Nouveau.Name = "Nouveau";
            Nouveau.Size = new Size(94, 29);
            Nouveau.TabIndex = 0;
            Nouveau.Text = "Nouveau";
            Nouveau.UseVisualStyleBackColor = true;
            Nouveau.Click += Nouveau_Click;
            // 
            // Modifier
            // 
            Modifier.Location = new Point(192, 3);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(94, 29);
            Modifier.TabIndex = 1;
            Modifier.Text = "Modifier";
            Modifier.UseVisualStyleBackColor = true;
            Modifier.Click += buttonModifier_Click;
            // 
            // Sauvegarder
            // 
            Sauvegarder.Location = new Point(292, 3);
            Sauvegarder.Name = "Sauvegarder";
            Sauvegarder.Size = new Size(94, 29);
            Sauvegarder.TabIndex = 2;
            Sauvegarder.Text = "Sauvegarder";
            Sauvegarder.UseVisualStyleBackColor = true;
            Sauvegarder.Click += buttonSauvegarder_Click;
            // 
            // Effacer
            // 
            Effacer.Location = new Point(392, 3);
            Effacer.Name = "Effacer";
            Effacer.Size = new Size(94, 29);
            Effacer.TabIndex = 3;
            Effacer.Text = "Effacer";
            Effacer.UseVisualStyleBackColor = true;
            Effacer.Click += buttonEffacer_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 444);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(Nouveau);
            panel1.Controls.Add(Modifier);
            panel1.Controls.Add(Effacer);
            panel1.Controls.Add(Sauvegarder);
            panel1.Location = new Point(229, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 91);
            panel1.TabIndex = 5;
            
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(320, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 27);
            textBox3.TabIndex = 8;
            // 
            // Titre
            // 
            Titre.AutoSize = true;
            Titre.Location = new Point(229, 117);
            Titre.Name = "Titre";
            Titre.Size = new Size(39, 20);
            Titre.TabIndex = 9;
            Titre.Text = "Titre";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(229, 161);
            Description.Name = "Description";
            Description.Size = new Size(85, 20);
            Description.TabIndex = 10;
            Description.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 11;
            // 
            // Motdepasse
            // 
            Motdepasse.AutoSize = true;
            Motdepasse.Location = new Point(217, 208);
            Motdepasse.Name = "Motdepasse";
            Motdepasse.Size = new Size(98, 20);
            Motdepasse.TabIndex = 12;
            Motdepasse.Text = "Mot de passe";
            // 
            // Affichermdp
            // 
            Affichermdp.AutoSize = true;
            Affichermdp.Location = new Point(621, 208);
            Affichermdp.Name = "Affichermdp";
            Affichermdp.Size = new Size(83, 24);
            Affichermdp.TabIndex = 13;
            Affichermdp.Text = "Afficher";
            Affichermdp.UseVisualStyleBackColor = true;
            // 
            // copier
            // 
            copier.Location = new Point(618, 240);
            copier.Name = "copier";
            copier.Size = new Size(94, 29);
            copier.TabIndex = 14;
            copier.Text = "Copier";
            copier.UseVisualStyleBackColor = true;
            copier.Click += buttonCopier_Click;
            // 
            // generermdp
            // 
            generermdp.Location = new Point(292, 240);
            generermdp.Name = "generermdp";
            generermdp.Size = new Size(94, 29);
            generermdp.TabIndex = 15;
            generermdp.Text = "Générer";
            generermdp.UseVisualStyleBackColor = true;
            generermdp.Click += buttonGenerer_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(checkchiffre);
            groupBox1.Controls.Add(checkcar);
            groupBox1.Controls.Add(checkmaj);
            groupBox1.Controls.Add(longueurmdp);
            groupBox1.Controls.Add(longueur);
            groupBox1.Controls.Add(trackbar);
            groupBox1.Location = new Point(217, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 172);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Option du générateur";
            // 
            // checkchiffre
            // 
            checkchiffre.AutoSize = true;
            checkchiffre.Location = new Point(6, 103);
            checkchiffre.Name = "checkchiffre";
            checkchiffre.Size = new Size(81, 24);
            checkchiffre.TabIndex = 21;
            checkchiffre.Text = "Chiffres";
            checkchiffre.UseVisualStyleBackColor = true;
            // 
            // checkcar
            // 
            checkcar.AutoSize = true;
            checkcar.Location = new Point(6, 133);
            checkcar.Name = "checkcar";
            checkcar.Size = new Size(161, 24);
            checkcar.TabIndex = 20;
            checkcar.Text = "Caractères spéciaux";
            checkcar.UseVisualStyleBackColor = true;
            // 
            // checkmaj
            // 
            checkmaj.AutoSize = true;
            checkmaj.Location = new Point(6, 73);
            checkmaj.Name = "checkmaj";
            checkmaj.Size = new Size(97, 24);
            checkmaj.TabIndex = 17;
            checkmaj.Text = "Majuscule";
            checkmaj.UseVisualStyleBackColor = true;
            // 
            // longueurmdp
            // 
            longueurmdp.AutoSize = true;
            longueurmdp.Location = new Point(401, 38);
            longueurmdp.Name = "longueurmdp";
            longueurmdp.Size = new Size(23, 20);
            longueurmdp.TabIndex = 19;
            longueurmdp.Text = "??";
            // 
            // longueur
            // 
            longueur.AutoSize = true;
            longueur.Location = new Point(26, 38);
            longueur.Name = "longueur";
            longueur.Size = new Size(71, 20);
            longueur.TabIndex = 18;
            longueur.Text = "Longueur";
            // 
            // trackbar
            // 
            trackbar.Location = new Point(187, 16);
            trackbar.Maximum = 50;
            trackbar.Minimum = 6;
            trackbar.Name = "trackbar";
            trackbar.Size = new Size(202, 56);
            trackbar.TabIndex = 17;
            trackbar.Value = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(generermdp);
            Controls.Add(copier);
            Controls.Add(Affichermdp);
            Controls.Add(Motdepasse);
            Controls.Add(textBox1);
            Controls.Add(Description);
            Controls.Add(Titre);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Cursor = Cursors.Cross;
            Name = "Form1";
            Text = "Generateur de mot de passe";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nouveau;
        private Button Modifier;
        private Button Sauvegarder;
        private Button Effacer;
        private ListBox listBox1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Titre;
        private Label Description;
        private TextBox textBox1;
        private Label Motdepasse;
        private CheckBox Affichermdp;
        private Button copier;
        private Button generermdp;
        private GroupBox groupBox1;
        private TrackBar trackbar;
        private Label longueur;
        private Label longueurmdp;
        private CheckBox checkchiffre;
        private CheckBox checkcar;
        private CheckBox checkmaj;
    }
}
