using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Frazione
{
    internal class Class1
    {
        class Frazione 
        {
            private int numeratore;
            private int denominatore;
            public Frazione()
            {
                Numeratore = numeratore;
                Denominatore = denominatore;
            }
            public int Numeratore
            {
                get { return numeratore; }
                set
                {
                    if(value != 0)
                    {
                        numeratore = value;
                    }
                    else
                    {
                        throw new ArgumentException("il numeratore non può essere 0");
                    }
                }
            }
            public int Denominatore
            {
                get { return denominatore; }
                set
                {
                    if(value != 0)
                    {
                        denominatore = value;
                    }
                    else
                    {
                        throw new ArgumentException("il denominatore non può essere 0");     
                    }
                }
            }
            private int Calcola_Mcd(int a , int b)
            {
                while(b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
            public void Semplifica()
            {
                int mcd = Calcola_Mcd(numeratore,denominatore);
                numeratore /= mcd;
                denominatore /= mcd;
            }
        }
    }
}
