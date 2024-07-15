using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaFitness
{
    [Serializable]
    public class Clienti
    {
        // Proprietăți private
        private int id_client;
        private string nume;
        private string prenume;
        private int varsta;
        private string nr_telefon;
        public List<string> ValidationErrors = new List<string>();
        public Clienti() { }
        public Clienti(int id_client, string nume, string prenume, int varsta, string nr_telefon)
        {
            this.id_client = id_client;
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.nr_telefon = nr_telefon;
        }

        public int IdClient
        {
            get { return id_client; }
            set { id_client = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string NrTelefon
        {
            get { return nr_telefon; }
            set { nr_telefon = value; }
        }


        public bool isValid
        {
            get
            {
                bool isValid = false;
                ValidationErrors.Clear();
                //if (id_client == null || id_client <= 0)
                    //ValidationErrors.Add("Id-ul nu este completat");
                if (string.IsNullOrEmpty(nume))
                    ValidationErrors.Add("Numele nu poate sa fie gol");
                if (string.IsNullOrEmpty(Prenume))
                    ValidationErrors.Add("Prenumele nu poate sa fie gol");
                if (varsta == null || Varsta <= 0)
                    ValidationErrors.Add("Varsta nu este completata");
                if (string.IsNullOrEmpty(nr_telefon))
                    ValidationErrors.Add("Numarul de telefon nu poate sa fie gol");
                return ValidationErrors.Any() ? false : true;
            }
        }
        public override string ToString()
        {
            return "Clientul cu id-ul:" + id_client + ", numit: " + nume + " " + prenume + ", are varsta: " + varsta + ", nr telefon:" + nr_telefon;
        }
    }
}
