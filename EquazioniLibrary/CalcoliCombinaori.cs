using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinaori
    {
        //Metodo per calcolare il FATTORIALE di un numero
        public static long Fattoriale(long Numero) //Ho scelto il tipo di dato LONG in quanto in matematica, si definisce
                                                   //il fattoriale di un numero naturale, indicato con il prodotto dei numeri 
                                                   //interi positivi minori o uguali a tale numero, quindi rispetto al tipo di dato INT, il long 
                                                   //comprede i valori interi da -2147483648 a 2147483647 , che sono maggiori rispetto all'int
        {
            long Risultato =1;

            for (long i=1; i<=Numero; i++)
            {
                Risultato = Risultato * i ;

            }

            return Risultato;

        }


    }
}
