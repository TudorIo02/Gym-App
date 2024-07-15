using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaFitness
{
    [Serializable]
    internal class Clasa_aerobic
    {
        private string nume_clasa;
        private int nivel_greutate;
        private double durata;
        public List<string> ValidationErrors = new List<string>();
        public Clasa_aerobic() { }
        public Clasa_aerobic(string nume_clasa, int nivel_greutate, double Durata)
        {
            this.nume_clasa = nume_clasa;
            this.nivel_greutate = nivel_greutate;
            this.durata = Durata;
        }

        public string NumeClasa
        {  get { return nume_clasa; } set { nume_clasa = value; } }
        public int NivelGreutate { get {  return nivel_greutate; } set { nivel_greutate = value; } }
        public double Durata
        {
            get { return durata; }
            set { durata = value; }
        }
        public bool isValid
        {
            get
            {
                bool isValid = false;
                ValidationErrors.Clear();
                if (nivel_greutate >10 || nivel_greutate <= 0)
                    ValidationErrors.Add("Nivelul greutatii trebuie sa fie intre 1 si 10");

                if (string.IsNullOrEmpty(nume_clasa))
                    ValidationErrors.Add("Numele clasei nu poate sa fie gol");
                if (durata >3 || durata <= 0.5)
                    ValidationErrors.Add("O clasa trebuie sa dureze intre 1 si 3 ore");

                return ValidationErrors.Any() ? false : true;
            }
        }

        public override string ToString()
        {
            return "Clasa " + nume_clasa + " are nivelul de greutate:  " + nivel_greutate + " si dureaza  " + durata;
        }
    }
}
