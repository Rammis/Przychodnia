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
    public partial class BadaniaFizykalne : Form
    {
        public BadaniaFizykalne()
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
            Badanie noweBadanie = new Badanie();
            noweBadanie.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Badanie noweBadanie = new Badanie();
            noweBadanie.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
