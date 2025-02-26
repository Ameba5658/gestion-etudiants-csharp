namespace projetgestionsEtudiant
{
    partial class FormAssocierProfesseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProfesseurs = new System.Windows.Forms.ComboBox();
            this.btnAssocier = new System.Windows.Forms.Button();
            this.clbMatieres = new System.Windows.Forms.CheckedListBox();
            this.clbClasses = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professeur";
            // 
            // cmbProfesseurs
            // 
            this.cmbProfesseurs.FormattingEnabled = true;
            this.cmbProfesseurs.Location = new System.Drawing.Point(214, 32);
            this.cmbProfesseurs.Name = "cmbProfesseurs";
            this.cmbProfesseurs.Size = new System.Drawing.Size(121, 28);
            this.cmbProfesseurs.TabIndex = 3;
            // 
            // btnAssocier
            // 
            this.btnAssocier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocier.Location = new System.Drawing.Point(61, 243);
            this.btnAssocier.Name = "btnAssocier";
            this.btnAssocier.Size = new System.Drawing.Size(124, 37);
            this.btnAssocier.TabIndex = 6;
            this.btnAssocier.Text = "Associer";
            this.btnAssocier.UseVisualStyleBackColor = true;
            this.btnAssocier.Click += new System.EventHandler(this.btnAssocier_Click);
            // 
            // clbMatieres
            // 
            this.clbMatieres.FormattingEnabled = true;
            this.clbMatieres.Location = new System.Drawing.Point(50, 109);
            this.clbMatieres.Name = "clbMatieres";
            this.clbMatieres.Size = new System.Drawing.Size(173, 119);
            this.clbMatieres.TabIndex = 7;
            this.clbMatieres.SelectedIndexChanged += new System.EventHandler(this.clbMatieres_SelectedIndexChanged);
            // 
            // clbClasses
            // 
            this.clbClasses.FormattingEnabled = true;
            this.clbClasses.Location = new System.Drawing.Point(311, 109);
            this.clbClasses.Name = "clbClasses";
            this.clbClasses.Size = new System.Drawing.Size(175, 119);
            this.clbClasses.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Matiere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Classe";
            // 
            // FormAssocierProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbClasses);
            this.Controls.Add(this.clbMatieres);
            this.Controls.Add(this.btnAssocier);
            this.Controls.Add(this.cmbProfesseurs);
            this.Controls.Add(this.label1);
            this.Name = "FormAssocierProfesseur";
            this.Text = "FormAssocierProfesseur";
            this.Load += new System.EventHandler(this.FormAssocierProfesseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProfesseurs;
        private System.Windows.Forms.Button btnAssocier;
        private System.Windows.Forms.CheckedListBox clbMatieres;
        private System.Windows.Forms.CheckedListBox clbClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}