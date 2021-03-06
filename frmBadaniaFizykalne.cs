﻿using System;
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

        int id_wizyty;
        public frmBadaniaFizykalne(int _id_wizyty)
        {
            InitializeComponent();
            id_wizyty = _id_wizyty;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = BadaniaFizykalneFacade.GetBadania(id_wizyty);
        }

        private void BadaniaFizykalne_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBadanieFizykalne noweBadanie = new frmBadanieFizykalne(id_wizyty);
            noweBadanie.ShowDialog();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = BadaniaFizykalneFacade.GetBadania(id_wizyty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)

            {
                int id_badanie = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
               
                frmBadanieFizykalne noweBadanie = new frmBadanieFizykalne(id_wizyty,id_badanie);
                noweBadanie.ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
