using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1_8_08_24.Models
{
    internal class Alacena
    {
        private double harina;
        private double frutas;

        public double Harina { get;private set; }
        public double Frutas { get;private set; }
        
        
        public void ReponerHarina(double cantidad)
        {
            Harina += cantidad;
        }
        public void ReponerFruta(double cantidad)
        {
            Frutas += cantidad;
        }
        public double TomarFruta(double requerido)
        {
            if (Harina <= requerido)
            {
                Harina -= requerido;
                return requerido;
            }
            else
            {
                double restante = Harina;
                Harina = 0;
                return restante;
            }
           
        }
        public double TomarHarina(double requerido)
        {
            if (Frutas <= requerido)
            {
                Frutas -= requerido;
                return requerido;
            }
            else
            {
                double restante = Frutas;
                Frutas = 0;
                return restante;
            }
    }
}
