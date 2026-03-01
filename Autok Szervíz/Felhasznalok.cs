using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autok_Szervíz
{
    public class Felhasznalok
    {
        #region Adattagok
        private string fnev;
        private string fjelszo;
        #endregion

        #region Konstruktor
       
        public Felhasznalok(string fnev, string fjelszo)
        {
            this.Fnev = fnev;
            this.Fjelszo = fjelszo;
        }
        #endregion

        #region Tulajdonságok
        public string Fnev
        {
            get => fnev;
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length != 8)
                {
                    throw new ArgumentException("A felhasználó név megadása kötelelző! 8 karakter hosszunak kell lennie!");
                }
                else
                {
                    fnev = value;
                }
            }
        }
        public string Fjelszo
        {
            get => fjelszo;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A jelszo megadása kötelező!");
                }
                else
                {
                    fjelszo = value;
                }
            }
        }
        #endregion
    }
}
