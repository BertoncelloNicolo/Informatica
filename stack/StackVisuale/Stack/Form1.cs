using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack tmp = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        void Data()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = tmp.Data.FindAll(x=>x!=0);//stampa gli elementi diversi da 0 
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tmp.Push(Convert.ToInt32(textBox1.Text));
                Data();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}, non si può effettuare la seguente operazione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
            }

        }

        private void btn_Pop_Click(object sender, EventArgs e)
        {
            int pop = tmp.Pop;

            if(pop != -1 )
            {
                MessageBox.Show($"Elemento eliminato:{pop}", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Lo Stack è vuoto, impossibile rimuovere elementi", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmp.Reset();
            Data();
        }

        private void btn_Cima_Click(object sender, EventArgs e)
        {
            if (tmp.GetElementi > 0)
            {
                MessageBox.Show($"L'elemento in cima allo stack è : {tmp.Cima}", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Lo Stack è vuoto", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Elementi_Click(object sender, EventArgs e)
        {
            if (tmp.GetElementi > 0)
            {
                MessageBox.Show($"Gli elementi sono: {tmp.GetElementi}", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Lo Stack è vuoto", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
