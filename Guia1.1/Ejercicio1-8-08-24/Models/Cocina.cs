using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_8_08_24.Models
{
    internal class Cocina
    {
        public Alacena alacena;
        public AmasadoraLaExploradora am;
        public Cocina(Alacena a)
        {
            this.alacena = a;
        }
        public Cocina(AmasadoraLaExploradora am)
        {
            this.am = am;
        }
    }
}
