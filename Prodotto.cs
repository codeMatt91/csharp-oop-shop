using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        // DICHIARO LE PROPRIETA

        private int codice;
        public int Codice 
        { 
            get 
            {
                return codice;
            }
            
        }
        private string nome;
        public string Nome 
        {
            get
            { 
                return nome;
            }

            set
            {
                if (value.Length <= 0)
                    Console.WriteLine("inserisci un nome valido");
                else
                    nome = value;
            }
        }
        private string descrizione;
        public string Descrizione {
            get
            {
                return descrizione;
            }
            set
            {
                if (value.Length < 10)
                    throw new Exception("Inserisci una descrizione piu lunga");
                else
                    descrizione = value;    
            }
        }
        private double prezzo;
        public double Prezzo {
            get
            { 
                return prezzo;
            }
            set 
            {
                if (double.IsNaN(value) || value <= 0)
                   throw new Exception("Il prezzo non e valido");
                else
                    prezzo = value;
            }
        }
        private double iva;
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        private static Random random = new Random();

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            //random = new Random();
            codice = random.Next();
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
            
        }


        public double prezzoIvato()
        {
            double newPrezzo;
            double pIva = (this.Prezzo * this.Iva)/100;
            return newPrezzo = this.Prezzo + pIva;
        }

        public string codicePiuNome()
        {
            string slug = this.Nome + this.Codice;
            return slug;
        }
    }
}
