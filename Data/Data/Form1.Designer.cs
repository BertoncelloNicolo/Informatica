
namespace Data
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtINSERIMENTO = new System.Windows.Forms.TextBox();
            this.pnlCONTROLLI = new System.Windows.Forms.Panel();
            this.ckBISESTILE = new System.Windows.Forms.CheckBox();
            this.rdNUMERO = new System.Windows.Forms.RadioButton();
            this.rdLETTERE = new System.Windows.Forms.RadioButton();
            this.btnCONTROLLA = new System.Windows.Forms.Button();
            this.pnlUPDOWN = new System.Windows.Forms.Panel();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnRESET = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlCONTROLLI.SuspendLayout();
            this.pnlUPDOWN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtINSERIMENTO
            // 
            this.txtINSERIMENTO.Location = new System.Drawing.Point(12, 12);
            this.txtINSERIMENTO.Name = "txtINSERIMENTO";
            this.txtINSERIMENTO.Size = new System.Drawing.Size(263, 20);
            this.txtINSERIMENTO.TabIndex = 0;
            this.txtINSERIMENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINSERIMENTO_KeyPress);
            // 
            // pnlCONTROLLI
            // 
            this.pnlCONTROLLI.Controls.Add(this.ckBISESTILE);
            this.pnlCONTROLLI.Controls.Add(this.rdNUMERO);
            this.pnlCONTROLLI.Controls.Add(this.rdLETTERE);
            this.pnlCONTROLLI.Location = new System.Drawing.Point(12, 38);
            this.pnlCONTROLLI.Name = "pnlCONTROLLI";
            this.pnlCONTROLLI.Size = new System.Drawing.Size(99, 98);
            this.pnlCONTROLLI.TabIndex = 1;
            // 
            // ckBISESTILE
            // 
            this.ckBISESTILE.AutoSize = true;
            this.ckBISESTILE.Location = new System.Drawing.Point(16, 61);
            this.ckBISESTILE.Name = "ckBISESTILE";
            this.ckBISESTILE.Size = new System.Drawing.Size(64, 17);
            this.ckBISESTILE.TabIndex = 2;
            this.ckBISESTILE.Text = "Bisestile";
            this.ckBISESTILE.UseVisualStyleBackColor = true;
            // 
            // rdNUMERO
            // 
            this.rdNUMERO.AutoSize = true;
            this.rdNUMERO.Location = new System.Drawing.Point(16, 23);
            this.rdNUMERO.Name = "rdNUMERO";
            this.rdNUMERO.Size = new System.Drawing.Size(62, 17);
            this.rdNUMERO.TabIndex = 1;
            this.rdNUMERO.TabStop = true;
            this.rdNUMERO.Text = "Numero";
            this.rdNUMERO.UseVisualStyleBackColor = true;
            this.rdNUMERO.Click += new System.EventHandler(this.rdNUMERO_Click);
            // 
            // rdLETTERE
            // 
            this.rdLETTERE.AutoSize = true;
            this.rdLETTERE.Location = new System.Drawing.Point(16, 41);
            this.rdLETTERE.Name = "rdLETTERE";
            this.rdLETTERE.Size = new System.Drawing.Size(58, 17);
            this.rdLETTERE.TabIndex = 0;
            this.rdLETTERE.TabStop = true;
            this.rdLETTERE.Text = "Lettere";
            this.rdLETTERE.UseVisualStyleBackColor = true;
            this.rdLETTERE.Click += new System.EventHandler(this.rdLETTERE_Click);
            // 
            // btnCONTROLLA
            // 
            this.btnCONTROLLA.Location = new System.Drawing.Point(12, 316);
            this.btnCONTROLLA.Name = "btnCONTROLLA";
            this.btnCONTROLLA.Size = new System.Drawing.Size(263, 23);
            this.btnCONTROLLA.TabIndex = 2;
            this.btnCONTROLLA.Text = "CONTROLLO DATA";
            this.btnCONTROLLA.UseVisualStyleBackColor = true;
            this.btnCONTROLLA.Click += new System.EventHandler(this.btnCONTROLLA_Click);
            // 
            // pnlUPDOWN
            // 
            this.pnlUPDOWN.Controls.Add(this.numericUpDown1);
            this.pnlUPDOWN.Controls.Add(this.btnDOWN);
            this.pnlUPDOWN.Controls.Add(this.btnUP);
            this.pnlUPDOWN.Location = new System.Drawing.Point(117, 38);
            this.pnlUPDOWN.Name = "pnlUPDOWN";
            this.pnlUPDOWN.Size = new System.Drawing.Size(158, 98);
            this.pnlUPDOWN.TabIndex = 3;
            // 
            // btnDOWN
            // 
            this.btnDOWN.Location = new System.Drawing.Point(87, 57);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(56, 23);
            this.btnDOWN.TabIndex = 1;
            this.btnDOWN.Text = "DOWN";
            this.btnDOWN.UseVisualStyleBackColor = true;
            this.btnDOWN.Click += new System.EventHandler(this.btnDOWN_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(87, 17);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(56, 23);
            this.btnUP.TabIndex = 0;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(12, 348);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(263, 23);
            this.btnRESET.TabIndex = 4;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 145);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(289, 382);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.pnlUPDOWN);
            this.Controls.Add(this.btnCONTROLLA);
            this.Controls.Add(this.pnlCONTROLLI);
            this.Controls.Add(this.txtINSERIMENTO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCONTROLLI.ResumeLayout(false);
            this.pnlCONTROLLI.PerformLayout();
            this.pnlUPDOWN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtINSERIMENTO;
        private System.Windows.Forms.Panel pnlCONTROLLI;
        private System.Windows.Forms.CheckBox ckBISESTILE;
        private System.Windows.Forms.RadioButton rdNUMERO;
        private System.Windows.Forms.RadioButton rdLETTERE;
        private System.Windows.Forms.Button btnCONTROLLA;
        private System.Windows.Forms.Panel pnlUPDOWN;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

