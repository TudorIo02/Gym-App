using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaFitness
{
    public class Rezervari
    {
        private int id_rezervare;
        private string nume_client;
        private DateTime data;
        private TimeSpan ora;
        public List<string> ValidationErrors = new List<string>();
        public Rezervari() { }
        public Rezervari(int id_rezervare, string nume_client, DateTime data, TimeSpan ora)
        {
            this.id_rezervare = id_rezervare;
            this.nume_client = nume_client;
            this.data = data;
            this.ora = ora;
           
        }


        public int IdRezervare
        {
            get { return id_rezervare; }
            set { id_rezervare = value; }
        }

        

        public string NumeClient
        {
            get { return nume_client; }
            set { nume_client = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public TimeSpan Ora
        {
            get { return ora; }
            set { ora = value; }
        }

        
        public bool isValid
        {
            get
            {
                bool isValid = false;
                ValidationErrors.Clear();

 
                if (string.IsNullOrEmpty(nume_client))
                    ValidationErrors.Add("Numele nu poate sa fie gol");
                if (data < DateTime.Today)
                {
                    ValidationErrors.Add("Data rezervării nu poate fi în trecut.");
                }
                if (ora < new TimeSpan(6, 0, 0) || ora > new TimeSpan(22, 0, 0))
                {
                    ValidationErrors.Add("Ora rezervării trebuie să fie între 06:00 și 22:00.");
                }
                if (string.IsNullOrEmpty(nume_client))
                    ValidationErrors.Add("Numele nu poate sa fie gol");
                return ValidationErrors.Any() ? false : true;
            }
        }

        public override string ToString()
        {
            return "Clientul are numele " + nume_client + " si are programarea la data de: " + data + "la ora: " + ora;
        }
    }
}
