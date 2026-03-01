using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autok_Szervíz
{
    public enum Tipus
    {
        Audi,BMW,Wolkswagen,Toyota,Mazda,Honda,Seat,Suzuki,Mercedes,Nissan
    }
    public class Autok
    {
        #region Adattagok
        private int id;
        private string rendszam;
        private Tipus tipus;
        private DateTime evjarat;
        private List<Szervizek> bejegyzes;
        #endregion

        #region Konstruktor
        public Autok(string rendszam,Tipus tipus,DateTime evjarat)
        {
            this.Rendszam = rendszam;
            this.Tipus = tipus;
            this.Evjarat = evjarat;
            Bejegyzes = new List<Szervizek>();
        }
        public Autok(int id,string rendszam,Tipus tipus,DateTime evjarat)
        {
            this.id = id;
            this.Rendszam = rendszam;
            this.Tipus = tipus;
            this.Evjarat = evjarat;
            Bejegyzes = new List<Szervizek>();
        }
        #endregion

        #region Alprogramok
        public override string ToString()
        {
            return $"ID:({Id}) Rendszám:{Rendszam}-->Típus:{Tipus}-(Évjárat:{Evjarat})";
        }
        #endregion

        #region Tulajdonságok
        public string Rendszam
        {
            get => rendszam;
            set
            {
                if(string.IsNullOrWhiteSpace(value) || value.Length != 7)
                {
                    throw new ArgumentException("A rendszám 7 karakter hosszunak kell lennie!" +
                        "Megadása köteelző");
                }
                else
                {
                    rendszam = value;
                }
            }
        }
        public DateTime Evjarat
        {
            get => evjarat;
            set
            {
                if(value.Year <= 1950)
                {
                    throw new ArgumentException("Az évjárat nem lehet 1950 előtt!");
                }
                else
                {
                    evjarat = value;
                }
            }
        }

        public Tipus Tipus { get => tipus; set => tipus = value; }
        public int Id { get => id; set => id = value; }
        public List<Szervizek> Bejegyzes { get => bejegyzes; set => bejegyzes = value; }
        #endregion
    }
}
