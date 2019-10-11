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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        public void Nuevo()
        {
            // Declara una nueva instancia de la forma "Autonuevo", luego esconde la forma activa
            // y muestra la forma "Autonuevo"
            Autonuevo n = new Autonuevo();
            n.Show();
        }

        public void Seminuevo()
        {
            // Declara una nueva instancia de la forma "Seminuevo" luego esconde la forma activa
            // y muestra la forma "Seminuevo"
            Seminuevo s = new Seminuevo();
            s.Show();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            // Cierra la forma activa para poder regresar a la forma "Form1"
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llamada al método para ir a la forma "Nuevo"
            Nuevo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Llamada al método para ir a la forma "Seminuevo"
            Seminuevo();
        }

    }
}
