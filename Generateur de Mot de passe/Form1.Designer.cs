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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            trackBar1 = new TrackBar();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(92, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Nouveau";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(192, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(292, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Sauvegarder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(392, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Effacer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(229, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 91);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
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
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 117);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 9;
            label1.Text = "Titre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 161);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 10;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 208);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "Mot de passe";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(621, 208);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Afficher";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button5
            // 
            button5.Location = new Point(618, 240);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "Copier";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(292, 240);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 15;
            button6.Text = "Générer";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Location = new Point(217, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 172);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Option du générateur";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 103);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(81, 24);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "Chiffres";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 133);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(161, 24);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Caractères spéciaux";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 73);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 24);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Majuscule";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 38);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 19;
            label5.Text = "??";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 38);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 18;
            label4.Text = "Longueur";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(187, 16);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = 6;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(202, 56);
            trackBar1.TabIndex = 17;
            trackBar1.Value = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Cursor = Cursors.Cross;
            Name = "Form1";
            Text = "Generateur de mot de passe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private CheckBox checkBox1;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private Label label4;
        private Label label5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
    }
}