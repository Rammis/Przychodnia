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
    public partial class frmBadanieFizykalne : Form
    {
        int id_wizyta;
        int kod;
        String nazwa;
        bool _czyNowy = true;
        public frmBadanieFizykalne(int _id_wizyta)
        {
            InitializeComponent();
            id_wizyta = _id_wizyta;
            label_id_badania.Visible = false;
            textbox_id_badania.Visible = false;
            _czyNowy = true;

        }
        public frmBadanieFizykalne(int _id_wizyta, int _id_badania)
        {
            InitializeComponent();
            id_wizyta = _id_wizyta;
            Badanie_fizykalne badanie = BadaniaFizykalneFacade.GetBadanie(_id_badania);
            textbox_id_badania.Text = badanie.id_bad_fiz.ToString();
            textbox_kod.Text = badanie.kod.ToString();
            textbox_nazwa.Text = badanie.Slownik_badan.nazwa.ToString();
            textbox_wynik.Text = badanie.wynik.ToString();

            textbox_id_badania.ReadOnly = true;
            textbox_kod.ReadOnly = true;
            textbox_nazwa.ReadOnly = true;
            textbox_wynik.ReadOnly = true;
            _czyNowy = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSlownikBadanFizykalnych slownikBadan = new frmSlownikBadanFizykalnych();
            slownikBadan.ShowDialog();
            kod = slownikBadan.getKod();
            textbox_kod.Text = kod.ToString();
            var singleBadanie = SlownikBadanFizykalnychFacade.GetBadanie(kod);
            String nazwa = singleBadanie.nazwa.ToString();
            textbox_nazwa.Text = singleBadanie.nazwa.ToString();
            textbox_wynik.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_czyNowy)
            {
                Badanie_fizykalne badanieFizykalne = new Badanie_fizykalne();

                badanieFizykalne.data_wykonania = DateTime.Now;
                badanieFizykalne.kod = kod;
                badanieFizykalne.wynik = textbox_wynik.Text;
                badanieFizykalne.id_wizyty = id_wizyta;
                BadaniaFizykalneFacade.InsertBadaniaFizykalne(badanieFizykalne);
            }
            this.Close();
        }

        

       
    }
}
