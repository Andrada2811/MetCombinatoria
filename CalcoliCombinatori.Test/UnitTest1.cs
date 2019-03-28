using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        //Effettuo il test solamente per i numeri maggiori o uguali a zero
        [DataTestMethod] //In questo modo posso variare i vari casi da testare senza creare ogni volta un nuovo test
        [DataRow(0, 1)]  //Il primo numero è il dato in  input mentre il secondo è il corrispondente output
        [DataRow(1, 1)]  //
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        [DataRow(11, 39916800)]
        [DataRow(12, 479001600)]
        [DataRow(13, 6227020800)]
        //[DataRow(50, 30414093201713378043612608166064768844377641568960512000000000000)]



        //Metodo per testare il fattoriale del N1
        public void TestMethod1(long N1, long N2 )
        {
            long Risultato = EquazioniLibrary.CalcoliCombinaori.Fattoriale(N1);

            Assert.AreEqual(Risultato,N2);
        }

        //Una cattiva scelta del tipo di dato può causare un overflow, dovuto al fatto che il computer non è in 
        //grado di memorizzare un qualsiasi numero di cifre, ma solo tante quante sono i bit a disposizione
        // nella memoria per quel tipo di dato.
        //Per esempio se avessimo un sistema a 16 bit e scegliessimo il tipo di dato LONG INTGER il sistema
        //andrebbe in overflow poichè non ha lo spazio necessario per contenere quelle cifre.

    }
}
