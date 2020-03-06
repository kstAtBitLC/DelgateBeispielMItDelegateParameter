using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RumTesten {

    // delegate
    delegate int ZeigAufWas (int x, int y);

    class Program {
        static void Main ( string [] args ) {

            // delegate variable
            ZeigAufWas zeigtAuf;

            // delegate objekt + Zeiger
            zeigtAuf = new ZeigAufWas (Demo.Subtrahiere);

            // indekten Methodenaufruf
           // int ergebnis = zeigtAuf (10,5);

           // Console.WriteLine (ergebnis);

            // Array deklarieren
            int [] array = { 5, 4, 3, 2, 1 };

            int ergebnis2 = MachWasMitDelegateParameter (array, zeigtAuf);
            Console.WriteLine ("Hauptprogramm: {0}", ergebnis2);

            Console.Read ();
        }

        public static int MachWasMitDelegateParameter (int[] a, ZeigAufWas zaw) {
            int [] intArray = new int [ a.Length ];
            for ( int i = 0 ; i < a.Length ; i++ ) {
                intArray[i] = zaw (a[i], 2);
                Console.WriteLine (intArray[i]);
            }
            Console.WriteLine ();
            int ergebnis = intArray.Sum ();

            Console.WriteLine ("Methode {0}",ergebnis);            
            return ergebnis;
        }
    }


    class Demo {
        public static int Addiere ( int x, int y ) {
            return x + y;
        }

        public static int Subtrahiere ( int x, int y ) {
            return x - y;
        }
    }

}




