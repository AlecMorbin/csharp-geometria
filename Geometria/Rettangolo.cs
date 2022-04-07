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
    }
}
