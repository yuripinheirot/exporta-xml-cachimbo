namespace exportaXML
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxSaveOn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tbxYearMonth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbxSaveOn
            // 
            this.tbxSaveOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSaveOn.Location = new System.Drawing.Point(15, 25);
            this.tbxSaveOn.Name = "tbxSaveOn";
            this.tbxSaveOn.Size = new System.Drawing.Size(330, 20);
            this.tbxSaveOn.TabIndex = 0;
            this.tbxSaveOn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSalvarEm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salvar em";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mês/Ano";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 51);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(403, 23);
            this.progressBar.TabIndex = 2;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(343, 95);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblProgresso
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(12, 98);
            this.lblProgress.Name = "lblProgresso";
            this.lblProgress.Size = new System.Drawing.Size(25, 16);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "0/0";
            // 
            // tbxYearMonth
            // 
            this.tbxYearMonth.CustomFormat = "MM/yyyy";
            this.tbxYearMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbxYearMonth.Location = new System.Drawing.Point(352, 26);
            this.tbxYearMonth.Name = "tbxYearMonth";
            this.tbxYearMonth.Size = new System.Drawing.Size(66, 20);
            this.tbxYearMonth.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 127);
            this.Controls.Add(this.tbxYearMonth);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSaveOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporta XML";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxSaveOn;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.DateTimePicker tbxYearMonth;
    }
}


