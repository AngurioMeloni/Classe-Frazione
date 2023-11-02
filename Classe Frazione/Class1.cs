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
            public Frazione(int numeratore,int denominatore)
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
            public Frazione Somma(Frazione altraFrazione)
            {
                int N_numeratore = numeratore * altraFrazione.Denominatore + altraFrazione.numeratore * denominatore;
                int N_denominatore = denominatore * altraFrazione.denominatore;
                return new Frazione(N_numeratore,N_denominatore);
            }
            public Frazione Sottrai(Frazione altraFrazione)
            {
                int N_numeratore = numeratore * altraFrazione.denominatore - altraFrazione.numeratore * denominatore;
                int N_denominatore = denominatore * altraFrazione.denominatore;
                return new Frazione(N_numeratore, N_denominatore);
            }
            public Frazione Moltiplica(Frazione altraFrazione)
            {
                int N_numeratore = numeratore * altraFrazione.denominatore;
                int N_denominatore = denominatore * altraFrazione.numeratore;
                return new Frazione(N_numeratore, N_denominatore);
            }
            public Frazione Dividi(Frazione altraFrazione)
            {
                int N_numeratore = numeratore * altraFrazione.denominatore;
                int N_denominatore = denominatore * altraFrazione.numeratore;
                return new Frazione(N_numeratore, N_denominatore);
            }
            public Frazione(Frazione altraFrazione)
            {
                numeratore = altraFrazione.numeratore;
                denominatore = altraFrazione.denominatore;
            }
            public Frazione Clone()
            {
                return new Frazione(this);
            }
            public override string ToString()
            {
                return $"{numeratore}/{denominatore}";
            }
        }
    }
}
