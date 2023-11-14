using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsipariş_Click(object sender, EventArgs e)
        {
            //ücret ve ekstra adında değişken tanımlıyoruz

            decimal ucret = 0;
            string ekstra = "";

            if (chket.Checked==true)
            {
                ekstra += "et";
                ucret = 20;

            }

            else if (chkmantar.Checked==true)
            {
                ekstra += "" + "mantar";
                ucret = 15;
            }

            else if (chkpeynir.Checked==true)
            {
                ekstra += "" + "peynir";
                ucret = 10;

            }
            else if (chksosis.Checked==true)
            {
                ekstra += "" + "sosis";
                ucret = 15;
            }
            else if (chksucuk.Checked==true)
            {
                ekstra += "" + "sucuk";
                ucret = 10;

            }
            else if (chkzeytin.Checked==true)
            {
                ekstra += "" + "zeytin";
                ucret = 5;
            }

            if (cmbPizzaBoyu.Text == "kucuk")
            {

                ucret += nmrPizzaAdet.Value * 15;
            }
            else if (cmbPizzaBoyu.Text == "orta")
            {
                ucret += nmrPizzaAdet.Value * 30;
            }
            else if (cmbPizzaBoyu.Text == "buyuk")
            {
                ucret += nmrPizzaAdet.Value * 45;
            }


            if(cmbicecek.Text=="2,5 Lt Coca Cola")
            {
                ucret += nmrİcecekAdet.Value * 55;
            }

            else if(cmbicecek.Text=="1 Lt Fanta")
            {
                ucret += nmrİcecekAdet.Value * 40;
            }

            else if(cmbicecek.Text=="1 Lt Sprite")
            {
                ucret += nmrİcecekAdet.Value * 45;
            }


            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listAdres.Items.Add(txtAdres.Text);
            listEkstra.Items.Add(ekstra);
            listPizzaBoyAdet.Items.Add("Adet" + nmrPizzaAdet.Value + "Boyut" + cmbPizzaBoyu.Text);
            listİcecekAdet.Items.Add("Adet" + nmrİcecekAdet.Value + "ıcecek" + cmbicecek.Text);
            listUcret.Items.Add(ucret +"TL");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPizzaBoyu.Items.Add("kucuk");
            cmbPizzaBoyu.Items.Add("orta");
            cmbPizzaBoyu.Items.Add("buyuk");

            cmbicecek.Items.Add("2,5 Lt Coca Cola");
            cmbicecek.Items.Add("1 Lt Fanta");
            cmbicecek.Items.Add("1 Lt Sprite");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtAdres.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();

            cmbicecek.Text = "";
            cmbPizzaBoyu.Text = "";

            nmrPizzaAdet.Value = 0;
            nmrİcecekAdet.Value = 0;

            chket.Checked = false;
            chkmantar.Checked = false;
            chkpeynir.Checked = false;
            chksosis.Checked = false;
            chksucuk.Checked = false;
            chkzeytin.Checked = false;


            listAdSoyad.Items.Clear();
            listTelefon.Items.Clear();
            listAdres.Items.Clear();
            listEkstra.Items.Clear();
            listPizzaBoyAdet.Items.Clear();
            listİcecekAdet.Items.Clear();
            listUcret.Items.Clear();



        }

        private void btnsipariştemizle_Click(object sender, EventArgs e)
        {

            txtAdres.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();

            cmbicecek.Text = "";
            cmbPizzaBoyu.Text = "";

            nmrPizzaAdet.Value = 0;
            nmrİcecekAdet.Value = 0;

            chket.Checked = false;
            chkmantar.Checked = false;
            chkpeynir.Checked = false;
            chksosis.Checked = false;
            chksucuk.Checked = false;
            chkzeytin.Checked = false;

        }
    }
}
