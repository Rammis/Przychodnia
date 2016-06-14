using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class frmWizyta : Form
    {
        public frmWizyta(String _imie, String _nazwisko, String _data_rej, String _stan)
        {
            InitializeComponent();
            textBox4.Text = _imie;
            textBox1.Text = _nazwisko;
            textBox3.Text = _data_rej;
            textBox2.Text = _stan;
        }

        private void LekarzB_FormClosed(object sender, FormClosedEventArgs e)
        {



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBadaniaFizykalne newBadaniaFizykalne = new frmBadaniaFizykalne();
            newBadaniaFizykalne.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmListaBadanLaboratoryjnych newListaBadanLaboratoryjnych = new frmListaBadanLaboratoryjnych();
            newListaBadanLaboratoryjnych.ShowDialog();
        }




    }
}
