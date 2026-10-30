using CegesAutoNyilvatartas.Data;
using CegesAutoNyilvatartas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CegesAutoNyilvatartas
{
    public partial class AutokNyilv : Form
    {
        public AutokNyilv()
        {
            InitializeComponent();
            Autok_Betolt();

        }
        private void AutokNyilv_Load(object sender, EventArgs e)
        {
            Autok_Betolt();
        }
        private void Autok_Betolt()
        {
            using AutoNyilvContext db = new AutoNyilvContext();
            lstAutok.Items.Clear();
            foreach (Auto auto in db.Autok)
            {
                lstAutok.Items.Add(auto);

            }
            //btnMentes.Enabled = false;
            //btnModosit.Enabled = false;



        }
        private void lstAutok_DoubleClick(object sender, EventArgs e)
        {
            if (lstAutok.SelectedItem == null)
            {
                return;
            }
            Auto kivalasztott = (Auto)lstAutok.SelectedItem;
            txtMarka.Text = kivalasztott.Marka;
            txtModell.Text = kivalasztott.Modell;
            txtRendszam.Text = kivalasztott.Rendszám;
            txtEvjarat.Text = kivalasztott.Evjarat.ToString();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            using AutoNyilvContext db = new AutoNyilvContext();

            int evjarat = 0;
            if (!int.TryParse(txtEvjarat.Text, out evjarat))
            {
                MessageBox.Show("Az évjáratnak számnak kell lennie.");
                return;
            }
            if (!duplikacioEllenorzes())
            {
                return;
            }

            db.Autok.Add(new Auto
            {
                Marka = txtMarka.Text,
                Modell = txtModell.Text,
                Rendszám = txtRendszam.Text,
                Evjarat = evjarat,


            });
            db.SaveChanges();
            Autok_Betolt();
            mezoUrites();

        }
        private void mezoUrites()
        {
            txtMarka.Clear();
            txtModell.Clear();
            txtRendszam.Clear();
            txtEvjarat.Clear();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (lstAutok.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztott autó!");
                return;
            }
            Auto kivalasztott = (Auto)lstAutok.SelectedItem;
            if (MessageBox.Show($"Biztosan törölni szeretnéd a {kivalasztott} autót?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }

            using AutoNyilvContext db = new AutoNyilvContext();
            Auto torlendo = db.Autok.Find(kivalasztott.Id);
            if (torlendo != null)
            {
                db.Autok.Remove(torlendo);
                db.SaveChanges();
                Autok_Betolt();
                mezoUrites();
            }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                errorProvider1.SetError(txtMarka, "A márka mező nem lehet üres!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtModell.Text))
            {
                errorProvider1.SetError(txtModell, "A modell mező nem lehet üres!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRendszam.Text))
            {
                errorProvider1.SetError(txtRendszam, "A rendszám mező nem lehet üres!");
                return;
            }
            if (!int.TryParse(txtEvjarat.Text, out int evjarat))
            {
                errorProvider1.SetError(txtEvjarat, "Az évjáratnak számnak kell lennie!");
                return;
            }
            if (evjarat < 1950 || evjarat > 2026)
            {
                errorProvider1.SetError(txtEvjarat, "Az évjáratnak 1950 és 2026 között kell lennie!");
                return;
            }
            if (lstAutok.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztott autó!");
                return;
            }
            Auto kivalasztott = (Auto)lstAutok.SelectedItem;
            if (!duplikacioEllenorzes(kivalasztott.Id))
            {
                return;
            }

            using AutoNyilvContext db = new AutoNyilvContext();
            Auto modositando = db.Autok.Find(kivalasztott.Id);
            modositando.Marka = txtMarka.Text;
            modositando.Modell = txtModell.Text;
            modositando.Rendszám = txtRendszam.Text;
            modositando.Evjarat = evjarat;

            db.SaveChanges();
            mezoUrites();
            Autok_Betolt();
        }
        private void lstAutok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAutok.SelectedItem == null)
            {
                return;
            }
            Auto kivalasztott = (Auto)lstAutok.SelectedItem;
            txtMarka.Text = kivalasztott.Marka;
            txtModell.Text = kivalasztott.Modell;
            txtRendszam.Text = kivalasztott.Rendszám;
            txtEvjarat.Text = kivalasztott.Evjarat.ToString();
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            mezoUrites();
            txtMarka.Focus();
        }

        private bool duplikacioEllenorzes(int? kihagyandoId = null)
        {
            errorProvider1.Clear();
            using AutoNyilvContext db = new AutoNyilvContext();
            string rendszam = txtRendszam.Text;
            var duplikaltAuto = db.Autok.FirstOrDefault(a =>
                a.Rendszám == rendszam && (!kihagyandoId.HasValue || a.Id != kihagyandoId.Value));
            if (duplikaltAuto != null)
            {
                errorProvider1.SetError(txtRendszam, "Ez a rendszám már létezik az adatbázisban!");
                txtMarka.Focus();
                return false;
            }

            return true;
        }
    }
}
