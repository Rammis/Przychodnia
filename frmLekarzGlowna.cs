using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BizzLayer;
namespace Przychodnia
{
    public partial class frmLekarzGlowna : Form
    {
        public frmLekarzGlowna()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = DoctorFacade.GetVisits();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String imie;
            String nazwisko;
            String data_rej;
            String stan;

            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                imie = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nazwisko = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                data_rej = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                stan = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                frmWizyta childForm = new frmWizyta(imie, nazwisko, data_rej, stan);

                childForm.ShowDialog();
            }
            else if (selectedRowCount > 1)
                MessageBox.Show("Zaznaczyles wiecej niz jedna wizyte!");
            else if (selectedRowCount == 0)
                MessageBox.Show("Nie zaznaczyles wizyty!");

        }



    }
}
