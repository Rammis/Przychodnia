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
            dataGridView1.Rows.Add("255", "Grypa");
            dataGridView1.Rows.Add("585", "Ospa");
        }

        

       
    }
}
