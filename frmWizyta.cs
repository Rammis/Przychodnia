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
    public partial class frmWizyta : Form
    {
        int id_wizyty;
        
        public frmWizyta(int _id, String _imie, String _nazwisko)
        {
            InitializeComponent();
            id_wizyty = _id;
            var wizyta = DoctorFacade.GetVisit(id_wizyty);
            textbox_imie.Text = _imie;
            textbox_nazwisko.Text = _nazwisko;
            textbox_datarej.Text = wizyta.data_rej.ToString();
            textbox_stan.Text = wizyta.data_wyk_wizyty.ToString();
            textbox_opis.Text = wizyta.opis;
            textbox_stan.Text = wizyta.stan;
            textbox_diagnoza.Text = wizyta.diagnoza;

        }

        public frmWizyta(int _id, String _imie, String _nazwisko,bool przeglad)
        {
            InitializeComponent();
            id_wizyty = _id;
            var wizyta = DoctorFacade.GetVisit(id_wizyty);
            textbox_imie.Text = _imie;
            textbox_nazwisko.Text = _nazwisko;
            textbox_datarej.Text = wizyta.data_rej.ToString();
            textbox_stan.Text = wizyta.data_wyk_wizyty.ToString();
            textbox_opis.Text = wizyta.opis;
            textbox_stan.Text = wizyta.stan;
            textbox_diagnoza.Text = wizyta.diagnoza;

            button_zakoncz.Visible = false;
            button_anuluj.Visible = false;

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
            Wizyta wizyta = new Wizyta();
            wizyta.id_wizyty = id_wizyty;
            wizyta.stan = "Zakończona";
            wizyta.opis = textbox_opis.Text;
            wizyta.diagnoza = textbox_diagnoza.Text;
            DoctorFacade.UpdateVisitData(wizyta);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wizyta wizyta = new Wizyta();
            wizyta.id_wizyty = id_wizyty;
            wizyta.stan = "Anulowana";
            wizyta.opis = textbox_opis.Text;
            wizyta.diagnoza = textbox_diagnoza.Text;
            DoctorFacade.UpdateVisitData(wizyta);
            this.Close();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wizyta wizyta = new Wizyta();
            wizyta.id_wizyty = id_wizyty;
            wizyta.stan = textbox_stan.Text;
            wizyta.opis = textbox_opis.Text;
            wizyta.diagnoza = textbox_diagnoza.Text;
            DoctorFacade.UpdateVisitData(wizyta);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBadaniaFizykalne newBadaniaFizykalne = new frmBadaniaFizykalne(id_wizyty);
            newBadaniaFizykalne.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmListaBadanLaboratoryjnych newListaBadanLaboratoryjnych = new frmListaBadanLaboratoryjnych();
            newListaBadanLaboratoryjnych.ShowDialog();
        }




    }
}
