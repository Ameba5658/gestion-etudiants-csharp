namespace projetgestionsEtudiant
{
    partial class FormReleveNotes
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        // cmbEtudiants.SelectedIndexChanged += cmbEtudiants_SelectedIndexChanged;

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
            this.cmbEtudiants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.btnGenererPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEtudiants
            // 
            this.cmbEtudiants.FormattingEnabled = true;
            this.cmbEtudiants.Location = new System.Drawing.Point(194, 93);
            this.cmbEtudiants.Name = "cmbEtudiants";
            this.cmbEtudiants.Size = new System.Drawing.Size(281, 28);
            this.cmbEtudiants.TabIndex = 0;
            this.cmbEtudiants.SelectedIndexChanged += new System.EventHandler(this.cmbEtudiants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etudiants";
            // 
            // lblMoyenne
            // 
            this.lblMoyenne.AutoSize = true;
            this.lblMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyenne.Location = new System.Drawing.Point(518, 23);
            this.lblMoyenne.Name = "lblMoyenne";
            this.lblMoyenne.Size = new System.Drawing.Size(234, 29);
            this.lblMoyenne.TabIndex = 2;
            this.lblMoyenne.Text = "Moyenne Generale";
            this.lblMoyenne.Click += new System.EventHandler(this.lblMoyenne_Click);
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(523, 65);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersWidth = 62;
            this.dgvNotes.RowTemplate.Height = 28;
            this.dgvNotes.Size = new System.Drawing.Size(791, 200);
            this.dgvNotes.TabIndex = 3;
            // 
            // btnGenererPDF
            // 
            this.btnGenererPDF.Location = new System.Drawing.Point(109, 464);
            this.btnGenererPDF.Name = "btnGenererPDF";
            this.btnGenererPDF.Size = new System.Drawing.Size(467, 87);
            this.btnGenererPDF.TabIndex = 4;
            this.btnGenererPDF.Text = "Exporter en PDF";
            this.btnGenererPDF.UseVisualStyleBackColor = true;
            this.btnGenererPDF.Click += new System.EventHandler(this.btnGenererPDF_Click);
            // 
            // FormReleveNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1326, 580);
            this.Controls.Add(this.btnGenererPDF);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.lblMoyenne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEtudiants);
            this.Name = "FormReleveNotes";
            this.Text = "FormReleveNotes";
            this.Load += new System.EventHandler(this.FormReleveNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEtudiants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnGenererPDF;
    }

}
