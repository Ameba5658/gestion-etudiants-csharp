namespace projetgestionsEtudiant
{
    partial class FormListeEtudiants
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
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExporterExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classe";
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(175, 51);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(189, 28);
            this.cmbClasses.TabIndex = 1;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.AllowUserToAddRows = false;
            this.dgvEtudiants.AllowUserToDeleteRows = false;
            this.dgvEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Location = new System.Drawing.Point(401, 12);
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.ReadOnly = true;
            this.dgvEtudiants.RowHeadersWidth = 62;
            this.dgvEtudiants.RowTemplate.Height = 28;
            this.dgvEtudiants.Size = new System.Drawing.Size(896, 379);
            this.dgvEtudiants.TabIndex = 2;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(83, 416);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(286, 71);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Exporter en Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExporterExcel
            // 
            this.btnExporterExcel.Location = new System.Drawing.Point(579, 426);
            this.btnExporterExcel.Name = "btnExporterExcel";
            this.btnExporterExcel.Size = new System.Drawing.Size(253, 61);
            this.btnExporterExcel.TabIndex = 4;
            this.btnExporterExcel.Text = "Exporter Meilleurs Etudiants";
            this.btnExporterExcel.UseVisualStyleBackColor = true;
            this.btnExporterExcel.Click += new System.EventHandler(this.btnExporterExcel_Click);
            // 
            // FormListeEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1309, 536);
            this.Controls.Add(this.btnExporterExcel);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dgvEtudiants);
            this.Controls.Add(this.cmbClasses);
            this.Controls.Add(this.label1);
            this.Name = "FormListeEtudiants";
            this.Text = "FormListeEtudiants";
            this.Load += new System.EventHandler(this.FormListeEtudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExporterExcel;
    }
}