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
    public partial class frmBadaniaFizykalne : Form
    {
        public frmBadaniaFizykalne()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = SlownikBadanFacade.GetBadania();
        }

        private void BadaniaFizykalne_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBadanie noweBadanie = new frmBadanie();
            noweBadanie.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBadanie noweBadanie = new frmBadanie();
            noweBadanie.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
