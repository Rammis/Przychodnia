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
    public partial class frmLaboratorium : Form
    {
        public frmLaboratorium()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            charCounterKLab.Text = uwagiKLabBadania.TextLength.ToString() + " / 150";         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            charCounterLab.Text = uwagiLabBadania.TextLength.ToString() + " / 150";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSlownikBadanLab slownikBadabLab = new frmSlownikBadanLab();
            slownikBadabLab.ShowDialog();
        }

    }
}
