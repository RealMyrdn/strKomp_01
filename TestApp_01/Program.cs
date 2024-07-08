using System;

namespace StringKomprimierung {
    class Programm {
        static string Quetschen(string bilddaten) {
            int i = 0;
            int j = 0;
            int k;
            char[] daten = bilddaten.ToCharArray();
            string kompStr = "";
            char z;
            while (i < (daten).Length) {
                z = daten[i];
                while (i < (daten).Length && z == daten[i]) {
                    i++;
                    j++;
                }
                if (j < 4) {
                    for (k = 1; k <= j; k++) {
                        kompStr += z;
                    }
                }
                else {
                    kompStr += "§" + j + z;
                }
                j = 0;
            }
            return kompStr;
        }
        static void Main(string[] args) {
            string input = "DDDDDHHNNMMUUUUUUUIIIIGGGGGGGLLLLLLLLLLLLXXXXXXXYYTTTTTTTTTTTT";
            int unkomp = (input).Length;
            string komprimiert = Quetschen(input);
            int komp = (komprimiert).Length;
            Console.WriteLine("Unkomprimierter String: " + input + "\n\nGröße in Zeichen: " + unkomp +"\n");
            Console.WriteLine("Komprimierter String: " + komprimiert + "\n\nGröße in Zeichen: " + komp);
        }
    }
}