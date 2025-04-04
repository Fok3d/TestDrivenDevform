namespace TestDrivenDev
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblSpecializace = new System.Windows.Forms.Label();
            this.lblPozice = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.txtPoziceX = new System.Windows.Forms.TextBox();
            this.txtPoziceY = new System.Windows.Forms.TextBox();
            this.cmbSpecializace = new System.Windows.Forms.ComboBox();
            this.btnVytvorit = new System.Windows.Forms.Button();
            this.btnZmenPozici = new System.Windows.Forms.Button();
            this.btnPridatXP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(9, 280);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(81, 13);
            this.lblJmeno.TabIndex = 0;
            this.lblJmeno.Text = "Jméno postavy:";
            // 
            // lblSpecializace
            // 
            this.lblSpecializace.AutoSize = true;
            this.lblSpecializace.Location = new System.Drawing.Point(12, 309);
            this.lblSpecializace.Name = "lblSpecializace";
            this.lblSpecializace.Size = new System.Drawing.Size(70, 13);
            this.lblSpecializace.TabIndex = 1;
            this.lblSpecializace.Text = "Specializace:";
            // 
            // lblPozice
            // 
            this.lblPozice.AutoSize = true;
            this.lblPozice.Location = new System.Drawing.Point(12, 339);
            this.lblPozice.Name = "lblPozice";
            this.lblPozice.Size = new System.Drawing.Size(106, 13);
            this.lblPozice.TabIndex = 2;
            this.lblPozice.Text = "Změna pozice (X, Y):";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 373);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(153, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Zobrazení informací o postavě";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(12, 58);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(100, 20);
            this.txtJmeno.TabIndex = 4;
            this.txtJmeno.Text = "Sem zadej jmeno";
            // 
            // txtPoziceX
            // 
            this.txtPoziceX.Location = new System.Drawing.Point(12, 179);
            this.txtPoziceX.Name = "txtPoziceX";
            this.txtPoziceX.Size = new System.Drawing.Size(165, 20);
            this.txtPoziceX.TabIndex = 5;
            this.txtPoziceX.Text = "0";
            // 
            // txtPoziceY
            // 
            this.txtPoziceY.Location = new System.Drawing.Point(198, 179);
            this.txtPoziceY.Name = "txtPoziceY";
            this.txtPoziceY.Size = new System.Drawing.Size(165, 20);
            this.txtPoziceY.TabIndex = 6;
            this.txtPoziceY.Text = "0";
            // 
            // cmbSpecializace
            // 
            this.cmbSpecializace.FormattingEnabled = true;
            this.cmbSpecializace.Items.AddRange(new object[] {
            "Kouzelník",
            "Berserker",
            "Inženýr"});
            this.cmbSpecializace.Location = new System.Drawing.Point(12, 84);
            this.cmbSpecializace.Name = "cmbSpecializace";
            this.cmbSpecializace.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecializace.TabIndex = 7;
            // 
            // btnVytvorit
            // 
            this.btnVytvorit.Location = new System.Drawing.Point(12, 115);
            this.btnVytvorit.Name = "btnVytvorit";
            this.btnVytvorit.Size = new System.Drawing.Size(174, 23);
            this.btnVytvorit.TabIndex = 8;
            this.btnVytvorit.Text = "Vytvořit postavu";
            this.btnVytvorit.UseVisualStyleBackColor = true;
            this.btnVytvorit.Click += new System.EventHandler(this.btnVytvorit_Click);
            // 
            // btnZmenPozici
            // 
            this.btnZmenPozici.Location = new System.Drawing.Point(12, 210);
            this.btnZmenPozici.Name = "btnZmenPozici";
            this.btnZmenPozici.Size = new System.Drawing.Size(165, 23);
            this.btnZmenPozici.TabIndex = 9;
            this.btnZmenPozici.Text = "Změnit pozici";
            this.btnZmenPozici.UseVisualStyleBackColor = true;
            this.btnZmenPozici.Click += new System.EventHandler(this.btnZmenPozici_Click);
            // 
            // btnPridatXP
            // 
            this.btnPridatXP.Location = new System.Drawing.Point(198, 210);
            this.btnPridatXP.Name = "btnPridatXP";
            this.btnPridatXP.Size = new System.Drawing.Size(165, 23);
            this.btnPridatXP.TabIndex = 10;
            this.btnPridatXP.Text = "Přidat level";
            this.btnPridatXP.UseVisualStyleBackColor = true;
            this.btnPridatXP.Click += new System.EventHandler(this.btnPridatXP_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Souradnice x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Souradnice y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPridatXP);
            this.Controls.Add(this.btnZmenPozici);
            this.Controls.Add(this.btnVytvorit);
            this.Controls.Add(this.cmbSpecializace);
            this.Controls.Add(this.txtPoziceY);
            this.Controls.Add(this.txtPoziceX);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPozice);
            this.Controls.Add(this.lblSpecializace);
            this.Controls.Add(this.lblJmeno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label lblSpecializace;
        private System.Windows.Forms.Label lblPozice;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.TextBox txtPoziceX;
        private System.Windows.Forms.TextBox txtPoziceY;
        private System.Windows.Forms.ComboBox cmbSpecializace;
        private System.Windows.Forms.Button btnVytvorit;
        private System.Windows.Forms.Button btnZmenPozici;
        private System.Windows.Forms.Button btnPridatXP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

