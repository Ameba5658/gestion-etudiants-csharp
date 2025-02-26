namespace projetgestionsEtudiant
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGestionClasses = new System.Windows.Forms.Button();
            this.btnGestionMatieres = new System.Windows.Forms.Button();
            this.btnGestionProfesseurs = new System.Windows.Forms.Button();
            this.btnAssocierProfesseurs = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnGestionClasses
            // 
            this.btnGestionClasses.Location = new System.Drawing.Point(107, 56);
            this.btnGestionClasses.Name = "btnGestionClasses";
            this.btnGestionClasses.Size = new System.Drawing.Size(157, 53);
            this.btnGestionClasses.TabIndex = 0;
            this.btnGestionClasses.Text = "Gestions des cours";
            this.btnGestionClasses.UseVisualStyleBackColor = true;
            this.btnGestionClasses.Click += new System.EventHandler(this.btnGestionClasses_Click_1);
            // 
            // btnGestionMatieres
            // 
            this.btnGestionMatieres.Location = new System.Drawing.Point(456, 50);
            this.btnGestionMatieres.Name = "btnGestionMatieres";
            this.btnGestionMatieres.Size = new System.Drawing.Size(139, 64);
            this.btnGestionMatieres.TabIndex = 1;
            this.btnGestionMatieres.Text = "Gestions des Matieres";
            this.btnGestionMatieres.UseVisualStyleBackColor = true;
            this.btnGestionMatieres.Click += new System.EventHandler(this.btnGestionMatieres_Click);
            // 
            // btnGestionProfesseurs
            // 
            this.btnGestionProfesseurs.Location = new System.Drawing.Point(107, 166);
            this.btnGestionProfesseurs.Name = "btnGestionProfesseurs";
            this.btnGestionProfesseurs.Size = new System.Drawing.Size(157, 65);
            this.btnGestionProfesseurs.TabIndex = 2;
            this.btnGestionProfesseurs.Text = "Gestions Professeurs";
            this.btnGestionProfesseurs.UseVisualStyleBackColor = true;
            this.btnGestionProfesseurs.Click += new System.EventHandler(this.btnGestionProfesseurs_Click);
            // 
            // btnAssocierProfesseurs
            // 
            this.btnAssocierProfesseurs.Location = new System.Drawing.Point(474, 177);
            this.btnAssocierProfesseurs.Name = "btnAssocierProfesseurs";
            this.btnAssocierProfesseurs.Size = new System.Drawing.Size(152, 54);
            this.btnAssocierProfesseurs.TabIndex = 3;
            this.btnAssocierProfesseurs.Text = "Associer un Professeur";
            this.btnAssocierProfesseurs.UseVisualStyleBackColor = true;
            this.btnAssocierProfesseurs.Click += new System.EventHandler(this.btnAssocierProfesseurs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssocierProfesseurs);
            this.Controls.Add(this.btnGestionProfesseurs);
            this.Controls.Add(this.btnGestionMatieres);
            this.Controls.Add(this.btnGestionClasses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionClasses;
        private System.Windows.Forms.Button btnGestionMatieres;
        private System.Windows.Forms.Button btnGestionProfesseurs;
        private System.Windows.Forms.Button btnAssocierProfesseurs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

