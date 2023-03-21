namespace Stack
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Push = new System.Windows.Forms.Button();
            this.btn_Pop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Cima = new System.Windows.Forms.Button();
            this.btn_Elementi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 479);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Push
            // 
            this.btn_Push.Location = new System.Drawing.Point(365, 54);
            this.btn_Push.Name = "btn_Push";
            this.btn_Push.Size = new System.Drawing.Size(221, 54);
            this.btn_Push.TabIndex = 1;
            this.btn_Push.Text = "Push";
            this.btn_Push.UseVisualStyleBackColor = true;
            this.btn_Push.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Pop
            // 
            this.btn_Pop.Location = new System.Drawing.Point(365, 133);
            this.btn_Pop.Name = "btn_Pop";
            this.btn_Pop.Size = new System.Drawing.Size(221, 54);
            this.btn_Pop.TabIndex = 2;
            this.btn_Pop.Text = "Pop";
            this.btn_Pop.UseVisualStyleBackColor = true;
            this.btn_Pop.Click += new System.EventHandler(this.btn_Pop_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Cima
            // 
            this.btn_Cima.Location = new System.Drawing.Point(365, 292);
            this.btn_Cima.Name = "btn_Cima";
            this.btn_Cima.Size = new System.Drawing.Size(221, 54);
            this.btn_Cima.TabIndex = 4;
            this.btn_Cima.Text = "Cima Stack";
            this.btn_Cima.UseVisualStyleBackColor = true;
            this.btn_Cima.Click += new System.EventHandler(this.btn_Cima_Click);
            // 
            // btn_Elementi
            // 
            this.btn_Elementi.Location = new System.Drawing.Point(365, 366);
            this.btn_Elementi.Name = "btn_Elementi";
            this.btn_Elementi.Size = new System.Drawing.Size(221, 54);
            this.btn_Elementi.TabIndex = 5;
            this.btn_Elementi.Text = "Numero Elementi";
            this.btn_Elementi.UseVisualStyleBackColor = true;
            this.btn_Elementi.Click += new System.EventHandler(this.btn_Elementi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 31);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 617);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Elementi);
            this.Controls.Add(this.btn_Cima);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Pop);
            this.Controls.Add(this.btn_Push);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Push;
        private System.Windows.Forms.Button btn_Pop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Cima;
        private System.Windows.Forms.Button btn_Elementi;
        private System.Windows.Forms.TextBox textBox1;
    }
}

