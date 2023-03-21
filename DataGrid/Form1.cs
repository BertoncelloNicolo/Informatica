using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        List<Utente> Abbonati;
        public Form1()
        {
            InitializeComponent();
            Abbonati = new List<Utente>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void inserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utente Abbonato = new Utente(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox4.Text));
            Abbonati.Add(Abbonato);
            dataGridView1.Rows.Add(Abbonato.Cognome, Abbonato.Nome, Abbonato.Credito);
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void cacnellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null && dataGridView1.CurrentRow.Index!=-1)
            {

            }
        }
    }
}
