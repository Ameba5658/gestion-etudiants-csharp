namespace projetgestionsEtudiant
{
    partial class FormAssocierClasse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.clbCours = new System.Windows.Forms.CheckedListBox();
            this.clbMatieres = new System.Windows.Forms.CheckedListBox();
            this.btnAssocier = new System.Windows.Forms.Button();
            this.dgvCoursClasse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matiere";
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(129, 28);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(267, 28);
            this.cmbClasses.TabIndex = 4;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // clbCours
            // 
            this.clbCours.FormattingEnabled = true;
            this.clbCours.Location = new System.Drawing.Point(129, 92);
            this.clbCours.Name = "clbCours";
            this.clbCours.Size = new System.Drawing.Size(267, 73);
            this.clbCours.TabIndex = 5;
            // 
            // clbMatieres
            // 
            this.clbMatieres.FormattingEnabled = true;
            this.clbMatieres.Location = new System.Drawing.Point(129, 248);
            this.clbMatieres.Name = "clbMatieres";
            this.clbMatieres.Size = new System.Drawing.Size(267, 73);
            this.clbMatieres.TabIndex = 6;
            // 
            // btnAssocier
            // 
            this.btnAssocier.Location = new System.Drawing.Point(32, 486);
            this.btnAssocier.Name = "btnAssocier";
            this.btnAssocier.Size = new System.Drawing.Size(257, 42);
            this.btnAssocier.TabIndex = 8;
            this.btnAssocier.Text = "Association";
            this.btnAssocier.UseVisualStyleBackColor = true;
            this.btnAssocier.Click += new System.EventHandler(this.btnAssocier_Click);
            // 
            // dgvCoursClasse
            // 
            this.dgvCoursClasse.AllowUserToAddRows = false;
            this.dgvCoursClasse.AllowUserToDeleteRows = false;
            this.dgvCoursClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoursClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursClasse.Location = new System.Drawing.Point(487, 31);
            this.dgvCoursClasse.Name = "dgvCoursClasse";
            this.dgvCoursClasse.ReadOnly = true;
            this.dgvCoursClasse.RowHeadersWidth = 62;
            this.dgvCoursClasse.RowTemplate.Height = 28;
            this.dgvCoursClasse.Size = new System.Drawing.Size(771, 290);
            this.dgvCoursClasse.TabIndex = 9;
            // 
            // FormAssocierClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1288, 540);
            this.Controls.Add(this.dgvCoursClasse);
            this.Controls.Add(this.btnAssocier);
            this.Controls.Add(this.clbMatieres);
            this.Controls.Add(this.clbCours);
            this.Controls.Add(this.cmbClasses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAssocierClasse";
            this.Text = "FormAssocierClasse";
            this.Load += new System.EventHandler(this.FormAssocierClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.CheckedListBox clbCours;
        private System.Windows.Forms.CheckedListBox clbMatieres;
        private System.Windows.Forms.Button btnAssocier;
        private System.Windows.Forms.DataGridView dgvCoursClasse;
    }
}