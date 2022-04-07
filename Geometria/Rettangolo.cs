using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        //attributi
        private int baseRettangolo;
        private int altezzaRettangolo;

        //costruttore 

        public Rettangolo(int baseR, int altezzaR)
        {
            setBase(baseR);
            setAltezza(altezzaR);
        }

        //metodi

        public int getBase()
        {
            return baseRettangolo;
        }

        public void setBase(int baseR)
        {
            if (baseR<0)
            {
                this.baseRettangolo = 0;
            }else
            {
                this.baseRettangolo = baseR;
            }
        }

        public int getAltezza()
        {
            return altezzaRettangolo;
        }

        public void setAltezza(int altezzaR)
        {
            if (altezzaR < 0)
            {
                this.altezzaRettangolo=0;
            }
            else
            {
                this.altezzaRettangolo = altezzaR;
            }
        }

        public float calcolaArea()
        {
            return getBase()*getAltezza();
        }

        public int calcolaPerimetro()
        {
            return (getBase()+getAltezza())*2;
        }

        public string ToString()
        {
            return "Rettangolo: "+
                    "\nBase: " + getBase() + " cm"+
                    "\nAltezza: " + getAltezza() + " cm"+
                    "\nPerimetro: " + calcolaPerimetro() + " cm"+
                    "\nArea: " + calcolaArea() + " cm^2";
        }

        public string Disegna()
        {
            string disegno = "";
            //separata la costruzione del disegno in componennti per renderlo più chiaro e modulare
            disegno += disengaBordo(getBase());
            //richiamo i metodi per costruire il disegno e per il centro ciclo tante volte quante è alto il disegno
            for (int i = 0; i < getAltezza(); i++) 
                disegno += disengaCentrale(getBase()); 
            disegno += disengaBordo(getBase());

            return disegno;
        }

        //l'esterno non ha bisogno di vedere questi metodi perciò saranno privati
        private string disengaCentrale(int lunghezza)
        {
            string result = "|";
            //le barrela laterali rimangono statiche e per lunghezza orizzontale aggiungo spazi o -- 
            for (int i = 0; i < lunghezza; i++)
                result += "  ";
            result += "|\n";

            return result;
        }

        private string disengaBordo(int lunghezza)
        {
            string result = "|";

            for (int i = 0; i < lunghezza; i++)
                result += "--";
            result += "|\n";

            return result;
        }
    }
}
