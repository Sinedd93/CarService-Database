using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Autok_Szervíz
{
    public class Szervizek
    {
        #region Adattagok
        private int autoId;
        private DateTime datum;
        private string leiras;
        private int koltseg;
        #endregion

        #region Konstruktor
        public Szervizek(int autoid,DateTime datum,string leiras,int koltseg)
        {
            this.AutoId = autoid;
            this.Datum = datum;
            this.Leiras = leiras;
            this.Koltseg = koltseg;
        }
        #endregion

        #region Alprogramok
        public override string ToString()
        {
            return $"ID:({AutoId}) Dátum:{Datum.ToShortDateString()}-->Leírás:{Leiras} Költség:{Koltseg}";
        }
        #endregion

        #region Tulajdonságok
       
        public string Leiras
        {
            get => leiras;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A leirás megadása kötelező!");
                }
                else
                {
                    leiras = value;
                }
            }
        }
        public int Koltseg
        {
            get => koltseg;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("A költség nem lehet negatív és nulla!");
                }
                else
                {
                    koltseg = value;
                }
            }

        }

        public int AutoId { get => autoId; set => autoId = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        #endregion
    }
}
