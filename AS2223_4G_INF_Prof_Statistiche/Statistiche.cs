using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Statistiche
{
    public class Statistiche
    {
        private int sommaValori = 0;
        private int numeroValori = 0;
        private double sommaPesi = 0;
        

        /// <summary>
        /// https://github.com/GLomba68/AS2223_4G_INF_Prof_Statistiche
        /// </summary>
        public Statistiche()
        {

        }

        /// <summary>
        /// Aggiungi un valore senza peso per le statistiche (media aritmetica)
        /// </summary>
        /// <param name="valore"></param>
        public void AddValue(int valore)
        {
            
            Console.WriteLine("Inserisci valore");
            valore = Convert.ToInt32(Console.ReadLine());
            sommaValori += valore;
            numeroValori++;
            //inserire valore
        }

        /// <summary>
        /// Aggiungi un valore con peso per le statistiche (media ponderata)
        /// </summary>
        /// <param name="valore"></param>
        /// <param name="peso"></param>
        public void AddValue(int valore, double peso)
        {
            Console.WriteLine("Inserisci valore");
            valore = Convert.ToInt32(Console.ReadLine());
            sommaValori += valore;
            numeroValori++;
            Console.WriteLine("Inserisci peso del valore");
            peso = Convert.ToDouble(Console.ReadLine());
            sommaPesi += peso;
            //inserire valore e peso
        }

        /// <summary>
        /// Ritorna la media aritmetica dei valori :
        ///     mediaAritmetica = sommaValori/numeroValori
        /// </summary>
        /// <returns></returns>
        public double MediaAritmetica()
        {
            return sommaValori/numeroValori;
        }

        /// <summary>
        /// Ritorna la media ponderata dei valori :
        ///     mediaPonderata = sommaValoriPerPeso/sommaPesi
        /// </summary>
        /// <returns></returns>
        public double MediaPonderata()
        {
            return (sommaValori * sommaPesi) / sommaPesi;
        }

        /// <summary>
        /// Azzera i valori inseriti per la statistica
        /// </summary>
        public void ClearValue()
        {

        }

        /// <summary>
        /// Ritorna il numero di elementi inseriti per la statistica
        /// </summary>
        /// <returns></returns>
        public int CountValue()
        {

        }

    }
}
