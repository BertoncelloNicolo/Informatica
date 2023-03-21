namespace ClasseQueue
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
            this.enqueue = new System.Windows.Forms.Button();
            this.dequeue = new System.Windows.Forms.Button();
            this.peek = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enqueue
            // 
            this.enqueue.BackColor = System.Drawing.Color.Gainsboro;
            this.enqueue.Location = new System.Drawing.Point(320, 47);
            this.enqueue.Name = "enqueue";
            this.enqueue.Size = new System.Drawing.Size(171, 50);
            this.enqueue.TabIndex = 0;
            this.enqueue.Text = "Enqueue";
            this.enqueue.UseVisualStyleBackColor = false;
            this.enqueue.Click += new System.EventHandler(this.enqueue_Click);
            // 
            // dequeue
            // 
            this.dequeue.BackColor = System.Drawing.Color.Gainsboro;
            this.dequeue.Location = new System.Drawing.Point(320, 131);
            this.dequeue.Name = "dequeue";
            this.dequeue.Size = new System.Drawing.Size(171, 50);
            this.dequeue.TabIndex = 1;
            this.dequeue.Text = "Dequeue";
            this.dequeue.UseVisualStyleBackColor = false;
            this.dequeue.Click += new System.EventHandler(this.dequeue_Click);
            // 
            // peek
            // 
            this.peek.BackColor = System.Drawing.Color.Gainsboro;
            this.peek.Location = new System.Drawing.Point(320, 215);
            this.peek.Name = "peek";
            this.peek.Size = new System.Drawing.Size(171, 50);
            this.peek.TabIndex = 2;
            this.peek.Text = "Peek";
            this.peek.UseVisualStyleBackColor = false;
            this.peek.Click += new System.EventHandler(this.peek_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Gainsboro;
            this.clear.Location = new System.Drawing.Point(320, 299);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(171, 50);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(33, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 244);
            this.listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserisci elemento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(541, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.peek);
            this.Controls.Add(this.dequeue);
            this.Controls.Add(this.enqueue);
            this.Name = "Form1";
            this.Text = "FormQueue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enqueue;
        private System.Windows.Forms.Button dequeue;
        private System.Windows.Forms.Button peek;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

