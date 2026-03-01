using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok_Szervíz
{
    public partial class MainForm : Form
    {

        #region Adattagok
        private List<Autok> auto;
        #endregion

        #region Konstruktor
        public MainForm()
        {
            InitializeComponent();
            auto = new List<Autok>();
            AutokSzervizABKezelo.AutokCsatlakozas();
            auto = AutokSzervizABKezelo.AutokesSzervizLista();
            LBAutoFrissites();

        }
        #endregion

        #region Alprogramok
        private void LBAutoFrissites()
        {
            lb_autok.DataSource = null;
            lb_autok.DataSource = auto;
            lb_autok.SelectedIndex = -1;
        }
        private void LBSzervizFrissites()
        {
            lb_szerviz.DataSource = null;
        }
        private void LBSzervizfrissites(Autok kijelolt)
        {
            lb_szerviz.DataSource = null;
            lb_szerviz.DataSource = kijelolt.Bejegyzes;
        }
        private void bt_felvétel_Click(object sender, EventArgs e)
        {
            AutokUrlap frm = new AutokUrlap();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                
                auto.Add(frm.Autok);
                AutokSzervizABKezelo.AutoFelvetel(frm.Autok);
                LBAutoFrissites();
            }
        }

        private void bt_modositas_Click(object sender, EventArgs e)
        {
            if(lb_autok.SelectedIndex < 0)
            {
                MessageBox.Show("Az autok módosításához vegyen fel vagy jelöljön ki egy autót!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Autok update = (Autok)lb_autok.SelectedItem;
                AutokUrlap frm = new AutokUrlap(update);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int index = lb_autok.SelectedIndex;
                    auto.RemoveAt(index);
                    auto.Insert(index, frm.Autok);
                    lb_autok.SelectedIndex = index;
                    AutokSzervizABKezelo.AutoModositas(frm.Autok);
                    LBAutoFrissites();
                }
            }
        }

        private void bt_törlés_Click(object sender, EventArgs e)
        {
            if(lb_autok.SelectedIndex < 0)
            {
                MessageBox.Show("A törléshez jelöljön ki egy autot vagy vegyen fel egyet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Biztos törli az autót?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Autok törlés = (Autok)lb_autok.SelectedItem;
                    auto.Remove(törlés);
                    AutokSzervizABKezelo.AutokTorles(törlés);
                    LBAutoFrissites();
                }
            }
        }
        private void bt_Szervízfelvétel_Click(object sender, EventArgs e)
        {
            if(lb_autok.SelectedIndex < 0)
            {
                MessageBox.Show("A szerviz felvételére vegyen fel vagy jelöljön ki egy autot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Autok kijelolt = (Autok)lb_autok.SelectedItem;
                SzervizekUrlap frm = new SzervizekUrlap(kijelolt.Id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    kijelolt.Bejegyzes.Add(frm.Szervizek);
                    AutokSzervizABKezelo.SzerfizFelvétel(frm.Szervizek);
                    lb_autok_SelectedIndexChanged(null, null);
                }
            }
        }
        private void lb_autok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb_autok.SelectedIndex < 0)
            {
                LBSzervizFrissites();
            }
            else
            {
                Autok kijelolt = (Autok)lb_autok.SelectedItem;

                if(lb_autok.SelectedIndex >= 0)
                {
                    LBSzervizfrissites(kijelolt);
                }
            }
        }
        private void bt_szevizmodositas_Click(object sender, EventArgs e)
        {
            if(lb_szerviz.SelectedIndex < 0)
            {
                MessageBox.Show("A módosításhoz jelöljön ki vagy vegyen fel egy bejegyzest!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Autok auto = (Autok)lb_autok.SelectedItem;
                Szervizek kijelolt = (Szervizek)lb_szerviz.SelectedItem;
                SzervizekUrlap frm = new SzervizekUrlap(kijelolt);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int index = lb_szerviz.SelectedIndex;
                    auto.Bejegyzes.RemoveAt(index);
                    auto.Bejegyzes.Insert(index, frm.Szervizek);
                    lb_szerviz.SelectedIndex = index;
                    AutokSzervizABKezelo.SzervizModositas(frm.Szervizek);
                    lb_autok_SelectedIndexChanged(null,null);
                }
            }
        }

        private void bt_szerviztorles_Click(object sender, EventArgs e)
        {
            if (lb_szerviz.SelectedIndex < 0)
            {
                MessageBox.Show("A szervíz módosításához jelöljön ki vagy vegyen fel egy bejegyzest!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Biztos törli a bejegyzest?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Autok kijelolt = (Autok)lb_autok.SelectedItem;
                    Szervizek törlés = (Szervizek)lb_szerviz.SelectedItem;
                    kijelolt.Bejegyzes.Remove(törlés);
                    AutokSzervizABKezelo.SzervizTorles(törlés);
                    lb_autok_SelectedIndexChanged(null, null);
                }
            }
        }
        private void bt_autokereses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_rendszam.Text))
            {
                MessageBox.Show("A kereséshez írjon be egy keresett rendszámot a jobb oldali mezőbe!",
                        "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_rendszam.Focus();
                return;
            }

            string keres = tb_rendszam.Text.ToLower();

            var talalat = auto.FirstOrDefault(x => x.Rendszam.ToLower() == keres);

            if(talalat != null)
            {
                lb_autok.SelectedItem = talalat;
                lb_Kereses.Items.Clear();
                lb_Kereses.Items.Add(talalat);
            }
            else
            {
                MessageBox.Show("A redszám nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
