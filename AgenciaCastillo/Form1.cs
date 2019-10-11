using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaCastillo
{
    public partial class Inicio : Form
    {
        // 16211981 - Castillo Solis Fabian Eduardo
        // Ingeniería de Software - 6to Semestre
        // Proyecto Agencia Automotriz

        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declara una nueva instancia de la forma "Menú", luego esconde la forma activa
            // y muestra la forma "Menú"
            Menú m = new Menú();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Declara una nueva instancia de la forma "Vender", luego esconde la forma activa
            // y muestra la forma "Vender"
            Vender v = new Vender();
            v.Show();
        }
    }
}
