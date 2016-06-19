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
using DataLayer;
namespace Przychodnia
{
    public partial class frmSlownikBadanFizykalnych : Form

    {
        int kod_badania;
        public frmSlownikBadanFizykalnych()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = SlownikBadanFizykalnychFacade.GetSlownikBadan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
          

                if (selectedRowCount == 1)
                {
                    kod_badania = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Zaznacz badanie!");
                }  

            
        }

        public int getKod()
        {
            return kod_badania;
        }
    }
}
