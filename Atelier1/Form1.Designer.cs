namespace Atelier1
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
            tabControl = new TabControl();
            tabPage_Profil = new TabPage();
            label6 = new Label();
            tabPage_Affichage = new TabPage();
            label_Avatar = new Label();
            groupBox_Avatar = new GroupBox();
            radioButton_Rouge = new RadioButton();
            radioButton_Bleu = new RadioButton();
            pictureBox_Image = new PictureBox();
            comboBox_Ville = new ComboBox();
            comboBox_Pays = new ComboBox();
            dateTimePicker_DateDeNaissance = new DateTimePicker();
            label_Ville = new Label();
            label_Pays = new Label();
            label_DateDeNaissance = new Label();
            label_Identifiant = new Label();
            label_Courriel = new Label();
            textBox_Identifiant = new TextBox();
            textBox_Courriel = new TextBox();
            button_Quitter = new Button();
            radioButton_Vert = new RadioButton();
            button_CreerLeProfil = new Button();
            tabControl.SuspendLayout();
            tabPage_Profil.SuspendLayout();
            tabPage_Affichage.SuspendLayout();
            groupBox_Avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_Profil);
            tabControl.Controls.Add(tabPage_Affichage);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 343);
            tabControl.TabIndex = 0;
            // 
            // tabPage_Profil
            // 
            tabPage_Profil.Controls.Add(label6);
            tabPage_Profil.Location = new Point(4, 24);
            tabPage_Profil.Name = "tabPage_Profil";
            tabPage_Profil.Padding = new Padding(3);
            tabPage_Profil.Size = new Size(768, 315);
            tabPage_Profil.TabIndex = 0;
            tabPage_Profil.Text = "Profil";
            tabPage_Profil.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 228);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 8;
            // 
            // tabPage_Affichage
            // 
            tabPage_Affichage.Controls.Add(button_CreerLeProfil);
            tabPage_Affichage.Controls.Add(label_Avatar);
            tabPage_Affichage.Controls.Add(groupBox_Avatar);
            tabPage_Affichage.Controls.Add(pictureBox_Image);
            tabPage_Affichage.Controls.Add(comboBox_Ville);
            tabPage_Affichage.Controls.Add(comboBox_Pays);
            tabPage_Affichage.Controls.Add(dateTimePicker_DateDeNaissance);
            tabPage_Affichage.Controls.Add(label_Ville);
            tabPage_Affichage.Controls.Add(label_Pays);
            tabPage_Affichage.Controls.Add(label_DateDeNaissance);
            tabPage_Affichage.Controls.Add(label_Identifiant);
            tabPage_Affichage.Controls.Add(label_Courriel);
            tabPage_Affichage.Controls.Add(textBox_Identifiant);
            tabPage_Affichage.Controls.Add(textBox_Courriel);
            tabPage_Affichage.Location = new Point(4, 24);
            tabPage_Affichage.Name = "tabPage_Affichage";
            tabPage_Affichage.Padding = new Padding(3);
            tabPage_Affichage.Size = new Size(768, 315);
            tabPage_Affichage.TabIndex = 1;
            tabPage_Affichage.Text = "Affichage";
            tabPage_Affichage.UseVisualStyleBackColor = true;
            // 
            // label_Avatar
            // 
            label_Avatar.AutoSize = true;
            label_Avatar.Location = new Point(40, 239);
            label_Avatar.Name = "label_Avatar";
            label_Avatar.Size = new Size(41, 15);
            label_Avatar.TabIndex = 30;
            label_Avatar.Text = "Avatar";
            // 
            // groupBox_Avatar
            // 
            groupBox_Avatar.Controls.Add(radioButton_Vert);
            groupBox_Avatar.Controls.Add(radioButton_Rouge);
            groupBox_Avatar.Controls.Add(radioButton_Bleu);
            groupBox_Avatar.Location = new Point(220, 215);
            groupBox_Avatar.Name = "groupBox_Avatar";
            groupBox_Avatar.Size = new Size(200, 49);
            groupBox_Avatar.TabIndex = 29;
            groupBox_Avatar.TabStop = false;
            // 
            // radioButton_Rouge
            // 
            radioButton_Rouge.AutoSize = true;
            radioButton_Rouge.Location = new Point(6, 20);
            radioButton_Rouge.Name = "radioButton_Rouge";
            radioButton_Rouge.Size = new Size(59, 19);
            radioButton_Rouge.TabIndex = 27;
            radioButton_Rouge.TabStop = true;
            radioButton_Rouge.Text = "Rouge";
            radioButton_Rouge.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bleu
            // 
            radioButton_Bleu.AutoSize = true;
            radioButton_Bleu.Location = new Point(83, 20);
            radioButton_Bleu.Name = "radioButton_Bleu";
            radioButton_Bleu.Size = new Size(48, 19);
            radioButton_Bleu.TabIndex = 28;
            radioButton_Bleu.TabStop = true;
            radioButton_Bleu.Text = "Bleu";
            radioButton_Bleu.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Image
            // 
            pictureBox_Image.Location = new Point(529, 39);
            pictureBox_Image.Name = "pictureBox_Image";
            pictureBox_Image.Size = new Size(199, 170);
            pictureBox_Image.TabIndex = 26;
            pictureBox_Image.TabStop = false;
            // 
            // comboBox_Ville
            // 
            comboBox_Ville.FormattingEnabled = true;
            comboBox_Ville.Location = new Point(220, 186);
            comboBox_Ville.Name = "comboBox_Ville";
            comboBox_Ville.Size = new Size(200, 23);
            comboBox_Ville.TabIndex = 25;
            // 
            // comboBox_Pays
            // 
            comboBox_Pays.FormattingEnabled = true;
            comboBox_Pays.Location = new Point(220, 146);
            comboBox_Pays.Name = "comboBox_Pays";
            comboBox_Pays.Size = new Size(200, 23);
            comboBox_Pays.TabIndex = 24;
            // 
            // dateTimePicker_DateDeNaissance
            // 
            dateTimePicker_DateDeNaissance.Location = new Point(220, 113);
            dateTimePicker_DateDeNaissance.Name = "dateTimePicker_DateDeNaissance";
            dateTimePicker_DateDeNaissance.Size = new Size(200, 23);
            dateTimePicker_DateDeNaissance.TabIndex = 23;
            // 
            // label_Ville
            // 
            label_Ville.AutoSize = true;
            label_Ville.Location = new Point(40, 189);
            label_Ville.Name = "label_Ville";
            label_Ville.Size = new Size(29, 15);
            label_Ville.TabIndex = 21;
            label_Ville.Text = "Ville";
            // 
            // label_Pays
            // 
            label_Pays.AutoSize = true;
            label_Pays.Location = new Point(40, 149);
            label_Pays.Name = "label_Pays";
            label_Pays.Size = new Size(31, 15);
            label_Pays.TabIndex = 20;
            label_Pays.Text = "Pays";
            // 
            // label_DateDeNaissance
            // 
            label_DateDeNaissance.AutoSize = true;
            label_DateDeNaissance.Location = new Point(40, 113);
            label_DateDeNaissance.Name = "label_DateDeNaissance";
            label_DateDeNaissance.Size = new Size(101, 15);
            label_DateDeNaissance.TabIndex = 19;
            label_DateDeNaissance.Text = "Date de naissance";
            // 
            // label_Identifiant
            // 
            label_Identifiant.AutoSize = true;
            label_Identifiant.Location = new Point(40, 80);
            label_Identifiant.Name = "label_Identifiant";
            label_Identifiant.Size = new Size(61, 15);
            label_Identifiant.TabIndex = 18;
            label_Identifiant.Text = "Identifiant";
            // 
            // label_Courriel
            // 
            label_Courriel.AutoSize = true;
            label_Courriel.Location = new Point(40, 42);
            label_Courriel.Name = "label_Courriel";
            label_Courriel.Size = new Size(49, 15);
            label_Courriel.TabIndex = 17;
            label_Courriel.Text = "Courriel";
            // 
            // textBox_Identifiant
            // 
            textBox_Identifiant.Location = new Point(220, 77);
            textBox_Identifiant.Name = "textBox_Identifiant";
            textBox_Identifiant.Size = new Size(200, 23);
            textBox_Identifiant.TabIndex = 16;
            // 
            // textBox_Courriel
            // 
            textBox_Courriel.Location = new Point(220, 39);
            textBox_Courriel.Name = "textBox_Courriel";
            textBox_Courriel.Size = new Size(200, 23);
            textBox_Courriel.TabIndex = 15;
            textBox_Courriel.TextChanged += textBox_Courriel_TextChanged;
            // 
            // button_Quitter
            // 
            button_Quitter.Location = new Point(633, 371);
            button_Quitter.Name = "button_Quitter";
            button_Quitter.Size = new Size(95, 37);
            button_Quitter.TabIndex = 1;
            button_Quitter.Text = "Quitter";
            button_Quitter.UseVisualStyleBackColor = true;
            // 
            // radioButton_Vert
            // 
            radioButton_Vert.AutoSize = true;
            radioButton_Vert.Location = new Point(149, 20);
            radioButton_Vert.Name = "radioButton_Vert";
            radioButton_Vert.Size = new Size(45, 19);
            radioButton_Vert.TabIndex = 29;
            radioButton_Vert.TabStop = true;
            radioButton_Vert.Text = "Vert";
            radioButton_Vert.UseVisualStyleBackColor = true;
            // 
            // button_CreerLeProfil
            // 
            button_CreerLeProfil.Location = new Point(529, 225);
            button_CreerLeProfil.Name = "button_CreerLeProfil";
            button_CreerLeProfil.Size = new Size(199, 39);
            button_CreerLeProfil.TabIndex = 31;
            button_CreerLeProfil.Text = "Créer le profil";
            button_CreerLeProfil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Quitter);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPage_Profil.ResumeLayout(false);
            tabPage_Profil.PerformLayout();
            tabPage_Affichage.ResumeLayout(false);
            tabPage_Affichage.PerformLayout();
            groupBox_Avatar.ResumeLayout(false);
            groupBox_Avatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage_Affichage;
        private Button button_Quitter;
        private TabPage tabPage_Profil;
        private Label label6;
        private RadioButton radioButton_Bleu;
        private RadioButton radioButton_Rouge;
        private PictureBox pictureBox_Image;
        private ComboBox comboBox_Ville;
        private ComboBox comboBox_Pays;
        private DateTimePicker dateTimePicker_DateDeNaissance;
        private Label label1;
        private Label label_Ville;
        private Label label_Pays;
        private Label label_DateDeNaissance;
        private Label label_Identifiant;
        private Label label_Courriel;
        private TextBox textBox_Identifiant;
        private TextBox textBox_Courriel;
        private Label label_Avatar;
        private GroupBox groupBox_Avatar;
        private RadioButton radioButton_Vert;
        private Button button_CreerLeProfil;
    }
}
