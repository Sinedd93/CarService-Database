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
    public partial class SzervizekUrlap : Form
    {
        #region Adattagok
        private Szervizek szervizek;
        private int autoId;
        #endregion

        #region Konstruktor
        public SzervizekUrlap(int autoid)
        {
            InitializeComponent();
            this.autoId = autoid;
        }
        public SzervizekUrlap(Szervizek szerviz):this(szerviz.AutoId)
        {
            this.szervizek = szerviz;
            dtp_datum.Value = szerviz.Datum;
            tb_leiras.Text = szerviz.Leiras;
            nud_koltseg.Value = szerviz.Koltseg;
        }
        #endregion

        #region Alprogramok
        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if(szervizek == null)
                {
                    szervizek = new Szervizek(autoId, dtp_datum.Value, tb_leiras.Text, (int)nud_koltseg.Value);
                }
                else
                {
                    szervizek.Datum = dtp_datum.Value;
                    szervizek.Leiras = tb_leiras.Text;
                    szervizek.Koltseg = (int)nud_koltseg.Value;
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }
        #endregion

        #region Tulajdonságok
        public Szervizek Szervizek
        {
            get => szervizek;
        }
        #endregion


    }
}
