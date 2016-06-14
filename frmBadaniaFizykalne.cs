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
    public partial class frmBadaniaFizykalne : Form
    {
        public frmBadaniaFizykalne()
        {
            InitializeComponent();
        }

        private void BadaniaFizykalne_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1","255", "Grypa");
            dataGridView1.Rows.Add("2","585", "Ospa");
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
