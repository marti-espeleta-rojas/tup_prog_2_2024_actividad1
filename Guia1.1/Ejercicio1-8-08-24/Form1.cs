using Ejercicio1_8_08_24.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_8_08_24
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Cocina cocina; 
        private void btnClienteCrearCocina_Click(object sender, EventArgs e)
        {
            Alacena alacena = new Alacena();
            cocina = new Cocina(alacena);
            AmasadoraLaExploradora am = new AmasadoraLaExploradora();
            cocina = new Cocina(am);
           
        }

        private void btnClienteReponerIngredientes_Click(object sender, EventArgs e)
        {
            Alacena a = cocina.alacena;
            a.ReponerHarina(Convert.ToDouble(textBoxReponerHarina.Text));
            a.ReponerFruta(Convert.ToDouble(textBoxReponerFrutas.Text));
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            Alacena a = cocina.alacena;
            a.ReponerHarina(Convert.ToDouble(textBoxTomarHarina.Text));
            a.ReponerFruta(Convert.ToDouble(textBoxTomarFruta.Text));
        }

        private void btnCocinar_Click(object sender, EventArgs e)
        {
            Alacena a = cocina.alacena;
            AmasadoraLaExploradora am = cocina.am;
        }
    }
}
