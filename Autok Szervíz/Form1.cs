using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok_Szervíz
{
    public partial class Form1 : Form
    {
       
        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
            FelhasznaloABKezelo.Csatlakozas();
            
        }
        #endregion

        #region Alprogramok
        private void bt_ok_Click(object sender, EventArgs e)
        {
            string fnev = tb_felhasznalo.Text;
            string fjelszo = tb_jelszo.Text;

            

            try
            {

                Felhasznalok felhasznalo = new Felhasznalok(fnev, fjelszo);

                if (FelhasznaloABKezelo.Belepes(fnev, fjelszo))
                {
                    this.Hide();
                    MainForm frm = new MainForm();
                    frm.Show();
                }


            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }
        #endregion


    }
}
