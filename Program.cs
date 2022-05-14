/*
 * Esercizio di oggi: C# Shop nome repo: csharp-oop-shop Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. 
 * Un prodotto è caratterizzato da: 
 * - codice (numero intero) 
 * - nome 
 * - descrizione 
 * - prezzo 
 * - iva 
 * 
 * Usate opportunamente i livelli di accesso (public, private), 
 * i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che: 
 * alla creazione di un nuovo prodotto il codice sia valorizzato 
 * con un numero random 
 * Il codice prodotto sia accessibile solo in lettura 
 * Gli altri attributi siano accessibili sia in lettura che in scrittura 
 * Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva 
 * Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto. 
 * 
 * BONUS: create un metodo che restituisca il codice con un pad 
 * left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
 */



using csharp_oop_shop;
using System;

namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine(random.Next(0, 10));


            try
            {

                Prodotto prod1 = new Prodotto("pasta barilla", "pasta da fare al sugo", 1.69, 22);


                Console.WriteLine("Codice: {0}", prod1.Codice);
                Console.WriteLine("Nome: {0}", prod1.Nome);
                Console.WriteLine("Descrizione: {0}", prod1.Descrizione);
                Console.WriteLine(prod1.prezzoIvato());
                Console.WriteLine(prod1.codicePiuNome());
                Console.WriteLine(prod1.codeLenght(prod1.Codice));
                

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            
             
        }
    }
}
