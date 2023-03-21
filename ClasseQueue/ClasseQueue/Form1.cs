using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseQueue
{
    public partial class Form1 : Form
    {
        ClasseQueue queue = new ClasseQueue();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void enqueue_Click(object sender, EventArgs e)
        {
            int elemento;
            if (!int.TryParse(textBox1.Text, out elemento)) //se l'inserimento nella textbox è un intero allora è possibile inserirlo nella queue
                MessageBox.Show("Inserimento errato");
            else
            {
                queue.Enqueue(elemento);
                VisualizzaQueue();
                textBox1.Clear();
            }
        }

        private void dequeue_Click(object sender, EventArgs e)
        {
            try
            {
                int rimosso = queue.Dequeue();
                MessageBox.Show(rimosso + " rimosso");
                VisualizzaQueue();
            }
            catch
            {
                MessageBox.Show("La queue è vuota");
            }
        }

        private void peek_Click(object sender, EventArgs e)
        {
            try
            {
                int primo = queue.Peek();
                MessageBox.Show("l'elemento in testa alla queue è: "+ primo);
            }
            catch
            {
                MessageBox.Show("La queue è vuota");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            queue.Clear(); 
            VisualizzaQueue();
        }

        private void VisualizzaQueue() 
        {
            listBox1.DataSource = null;
            listBox1.DataSource = queue.GetElementi();
        }
    }
}
