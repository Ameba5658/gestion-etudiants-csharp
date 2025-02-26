namespace projetgestionsEtudiant
{
    partial class FormProfesseur
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNomProf = new System.Windows.Forms.TextBox();
            this.txtPrenomProf = new System.Windows.Forms.TextBox();
            this.txtEmailProf = new System.Windows.Forms.TextBox();
            this.txtTelephoneProf = new System.Windows.Forms.TextBox();
            this.dgvProfesseurs = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNomProf
            // 
            this.txtNomProf.Location = new System.Drawing.Point(193, 38);
            this.txtNomProf.Name = "txtNomProf";
            this.txtNomProf.Size = new System.Drawing.Size(139, 26);
            this.txtNomProf.TabIndex = 4;
            // 
            // txtPrenomProf
            // 
            this.txtPrenomProf.Location = new System.Drawing.Point(191, 102);
            this.txtPrenomProf.Name = "txtPrenomProf";
            this.txtPrenomProf.Size = new System.Drawing.Size(141, 26);
            this.txtPrenomProf.TabIndex = 5;
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.Location = new System.Drawing.Point(193, 179);
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.Size = new System.Drawing.Size(139, 26);
            this.txtEmailProf.TabIndex = 6;
            // 
            // txtTelephoneProf
            // 
            this.txtTelephoneProf.Location = new System.Drawing.Point(191, 243);
            this.txtTelephoneProf.Name = "txtTelephoneProf";
            this.txtTelephoneProf.Size = new System.Drawing.Size(132, 26);
            this.txtTelephoneProf.TabIndex = 7;
            // 
            // dgvProfesseurs
            // 
            this.dgvProfesseurs.AllowUserToAddRows = false;
            this.dgvProfesseurs.AllowUserToDeleteRows = false;
            this.dgvProfesseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfesseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesseurs.Location = new System.Drawing.Point(357, 12);
            this.dgvProfesseurs.Name = "dgvProfesseurs";
            this.dgvProfesseurs.ReadOnly = true;
            this.dgvProfesseurs.RowHeadersWidth = 62;
            this.dgvProfesseurs.RowTemplate.Height = 28;
            this.dgvProfesseurs.Size = new System.Drawing.Size(559, 334);
            this.dgvProfesseurs.TabIndex = 8;
            this.dgvProfesseurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesseurs_CellClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(16, 382);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(152, 38);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(269, 382);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(147, 38);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifer";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(523, 382);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 38);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FormProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvProfesseurs);
            this.Controls.Add(this.txtTelephoneProf);
            this.Controls.Add(this.txtEmailProf);
            this.Controls.Add(this.txtPrenomProf);
            this.Controls.Add(this.txtNomProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProfesseur";
            this.Text = "FormProfesseur";
            this.Load += new System.EventHandler(this.FormProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNomProf;
        private System.Windows.Forms.TextBox txtPrenomProf;
        private System.Windows.Forms.TextBox txtEmailProf;
        private System.Windows.Forms.TextBox txtTelephoneProf;
        private System.Windows.Forms.DataGridView dgvProfesseurs;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}