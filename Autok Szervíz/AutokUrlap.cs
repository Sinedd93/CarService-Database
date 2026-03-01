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
    public partial class AutokUrlap : Form
    {
        #region Adattagok
        private Autok autok;
        #endregion
        public AutokUrlap()
        {
            InitializeComponent();
            cb_tipus.DataSource = Enum.GetValues(typeof(Tipus));
        }
        public AutokUrlap(Autok auto) : this()
        {
            this.autok = auto;
            tb_rendszam.Text = autok.Rendszam;
            cb_tipus.SelectedItem = autok.Tipus;
            dtp_datum.Value = autok.Evjarat;
        }

        #region Alprogramok
        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if(autok == null)
                {
                    autok = new Autok(tb_rendszam.Text, (Tipus)cb_tipus.SelectedItem,dtp_datum.Value);
                }
                else
                {
                    autok.Rendszam = tb_rendszam.Text;
                    autok.Tipus = (Tipus)cb_tipus.SelectedItem;
                    autok.Evjarat = dtp_datum.Value;
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
        public Autok Autok
        {
            get => autok;
        }
        #endregion


    }
}
