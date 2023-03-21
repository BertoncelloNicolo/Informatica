using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class Form1 : Form
    {
        ClasseData data;
        DateTime data_time;
        string data_scritta;
        string[] stringa_splittata;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCONTROLLA_Click(object sender, EventArgs e)
        {
            pnlCONTROLLI.Enabled = true;
            pnlUPDOWN.Enabled = true;
            data_scritta = txtINSERIMENTO.Text;
            if (Controlli.Sintassi(data_scritta))
            {
                stringa_splittata = data_scritta.Split('/');
                data = new ClasseData(Convert.ToInt32(stringa_splittata[0]), Convert.ToInt32(stringa_splittata[1]), Convert.ToInt32(stringa_splittata[2]));
                ckBISESTILE.Checked = Controlli.bisestile(Convert.ToInt32(stringa_splittata[2]));
                data_time = new DateTime(data.Anno, data.Mese, data.Giorno);
                monthCalendar1.SetDate(data_time);
            }
            else
            {
                MessageBox.Show("inserimento errato della data");
                txtINSERIMENTO.Clear();
                ckBISESTILE.Checked = false;
                rdNUMERO.Checked = true;
                pnlCONTROLLI.Enabled = false;
                pnlUPDOWN.Enabled = false;
                ckBISESTILE.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdNUMERO.Checked = true;
            pnlCONTROLLI.Enabled = false;
            pnlUPDOWN.Enabled = false;
            ckBISESTILE.Enabled = false;
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            txtINSERIMENTO.Clear();
            pnlCONTROLLI.Enabled = false;
            pnlUPDOWN.Enabled = false;
        }

        private void txtINSERIMENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char carattere = e.KeyChar;
            if (!char.IsDigit(carattere) && carattere != '/' && carattere != '\b')
            {
                MessageBox.Show("inserire solo numeri e /");
                txtINSERIMENTO.Clear();
                e.Handled = true;//gestisce l'evento in modo che non scriva nulla 
            }
        }

        private void rdNUMERO_Click(object sender, EventArgs e)
        {
            if (txtINSERIMENTO.Text != string.Empty)
            {
                txtINSERIMENTO.Text = data.Giorno + "/" + data.Mese + "/" + data.Anno;
            }
            else
            {
                MessageBox.Show("Inserisci una stringa con una data valida");
            }
        }

        private void rdLETTERE_Click(object sender, EventArgs e)
        {
            if (txtINSERIMENTO.Text!=string.Empty)
            {
                txtINSERIMENTO.Text = data.Giorno + "/" + data.NomeMese() + "/" + data.Anno;
            }
            else
            {
                MessageBox.Show("Inserisci una stringa con una data valida");
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            data.Incremento_Giorni(Convert.ToInt32(numericUpDown1.Value));
            txtINSERIMENTO.Text = data.Giorno + "/" + data.Mese + "/" + data.Anno;
        }

        private void btnDOWN_Click(object sender, EventArgs e)
        {
            data.Decremento_Giorni(Convert.ToInt32(numericUpDown1.Value));
            txtINSERIMENTO.Text = data.Giorno + "/" + data.Mese + "/" + data.Anno;
        }
    }
}
