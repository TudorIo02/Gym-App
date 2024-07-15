using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaFitness
{
    public class Echipamente
    {
        private int id_aparat;
        private string nume;
        private string grupa_muschi;
        private DateTime data_livrare;
        private double pret;
        public List<string> ValidationErrors = new List<string>();
        public Echipamente() { }
        public Echipamente(int id_aparat, string nume, string grupa_muschi, DateTime data_livrare, double pret)
        {
            this.id_aparat = id_aparat;
            this.nume = nume;
            this.grupa_muschi = grupa_muschi;
            this.data_livrare = data_livrare;
            this.pret = pret;
        }

        public int IdAparat
        {
            get { return id_aparat; }
            set { id_aparat = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Grupa_muschi
        {
            get { return grupa_muschi; }
            set { grupa_muschi = value; }
        }

        public DateTime Data_livrare
        {
            get { return data_livrare; }
            set { data_livrare = value; }
        }

        public double Pret
        {
            get { return pret; }
            set { if (value > 0) pret = value; }
        }

        public bool isValid
        {
            get
            {
                ValidationErrors.Clear();
                if (id_aparat < 0)
                    ValidationErrors.Add("Id-ul nu este completat corect");
                if (string.IsNullOrEmpty(nume))
                    ValidationErrors.Add("Numele nu poate sa fie gol");
                if (string.IsNullOrEmpty(Grupa_muschi))
                    ValidationErrors.Add("Grupa muschi nu poate sa fie gol");
                if (pret <= 0)
                    ValidationErrors.Add("Pretul nu este completat");
                return !ValidationErrors.Any();
            }
        }

        public override string ToString()
        {
            return $"Aparatul cu id-ul: {id_aparat}, numit: {nume}, pentru grupa de muschi: {grupa_muschi} se livreaza la: {data_livrare} si are pretul: {pret}";
        }
    }
}


    
