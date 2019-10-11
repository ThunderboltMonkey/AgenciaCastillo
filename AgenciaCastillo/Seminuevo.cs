using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AgenciaCastillo
{
    public partial class Seminuevo : Form
    {
        public Seminuevo()
        {
            InitializeComponent();
        }

        // Declaración de los precios de los autos disponibles
        float focus = 190000;
        float hyundai = 220000;
        float sentra = 265000;
        float prius = 230000;
        float accord = 200000;
        // Variable del subtotal correspondiente a cada auto
        float ivaFocus = 0;
        float ivaHyundai = 0;
        float ivaSentra = 0;
        float ivaPrius = 0;
        float ivaAccord = 0;
        // Variable del total correspondiente a cada auto
        float totFocus = 0;
        float totHyundai = 0;
        float totSentra = 0;
        float totPrius = 0;
        float totAccord = 0;
        // iva
        float iva = 0.16f;
        //
        float mods = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbFord_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "Ford";
            txtModelo.Text = "Focus";
            txtEdicion.Text = "Normal";
            txtYear.Text = "2015";
            txtColor.Text = "Negro";
            txtTrans.Text = "Automática";
            txtMotor.Text = "2.7 Litros";
            txtCilindros.Text = "6";
            txtPBase.Text = focus.ToString();
            txtMods.Text = mods.ToString();
            txtSub.Text = (focus + mods).ToString();
            ivaFocus = focus * iva;
            txtIva.Text = ivaFocus.ToString();
            totFocus = focus + ivaFocus;
            txtTotal.Text = totFocus.ToString();

            if (rbFord.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Negro.jpg");
            }
        }

        private void rbHyundai_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "Hyundai";
            txtModelo.Text = "Elantra";
            txtEdicion.Text = "Normal";
            txtYear.Text = "2014";
            txtColor.Text = "Blanco";
            txtTrans.Text = "Automática";
            txtMotor.Text = "1.8 Litros";
            txtCilindros.Text = "4";
            txtPBase.Text = hyundai.ToString();
            txtMods.Text = mods.ToString();
            txtSub.Text = (hyundai + mods).ToString();
            ivaHyundai = hyundai * iva;
            txtIva.Text = ivaHyundai.ToString();
            totHyundai = hyundai + ivaHyundai;
            txtTotal.Text = totHyundai.ToString();

            if (rbHyundai.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantrablanco.jpg");
            }
        }

        private void rbNissan_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "Nissan";
            txtModelo.Text = "Sentra";
            txtEdicion.Text = "Sport";
            txtYear.Text = "2016";
            txtColor.Text = "Rojo";
            txtTrans.Text = "Automática";
            txtMotor.Text = "2.0 Litros";
            txtCilindros.Text = "6";
            txtPBase.Text = sentra.ToString();
            txtMods.Text = mods.ToString();
            txtSub.Text = (sentra + mods).ToString();
            ivaSentra = sentra * iva;
            txtIva.Text = ivaSentra.ToString();
            totSentra = sentra + ivaSentra;
            txtTotal.Text = totSentra.ToString();

            if (rbNissan.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\sentrarojo.jpg");
            }
        }

        private void rbToyota_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "Toyota";
            txtModelo.Text = "Prius";
            txtEdicion.Text = "Sport";
            txtYear.Text = "2015";
            txtColor.Text = "Azul";
            txtTrans.Text = "Automática";
            txtMotor.Text = "2.7 Litros";
            txtCilindros.Text = "4";
            txtPBase.Text = prius.ToString();
            txtMods.Text = mods.ToString();
            txtSub.Text = (prius + mods).ToString();
            ivaPrius = prius * iva;
            txtIva.Text = ivaPrius.ToString();
            totPrius = prius + ivaPrius;
            txtTotal.Text = totPrius.ToString();

            if (rbToyota.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\priusazul.jpg");
            }
        }

        private void rbHonda_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "Honda";
            txtModelo.Text = "Accord";
            txtEdicion.Text = "De lujo";
            txtYear.Text = "2013";
            txtColor.Text = "Gris";
            txtTrans.Text = "Automática";
            txtMotor.Text = "2.4 Litros";
            txtCilindros.Text = "4";
            txtPBase.Text = accord.ToString();
            txtMods.Text = mods.ToString();
            txtSub.Text = (accord + mods).ToString();
            ivaAccord = accord * iva;
            txtIva.Text = ivaAccord.ToString();
            totAccord = accord + ivaAccord;
            txtTotal.Text = totAccord.ToString();

            if (rbHonda.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\accordgris.jpg");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Financiamiento finan = new Financiamiento();
            finan.txtPrecio.Text = txtTotal.Text;
            finan.picGuardar.Image = pictureBox1.Image;


            //Agregar los datos al listBox oculto
            finan.lbOculto.Items.Add("Marca: " + txtMarca.Text);
            finan.lbOculto.Items.Add("Modelo: " + txtModelo.Text);
            finan.lbOculto.Items.Add("Edición: " + txtEdicion.Text);
            finan.lbOculto.Items.Add("Año: " + txtYear.Text);
            finan.lbOculto.Items.Add("Color: " + txtColor.Text);
            finan.lbOculto.Items.Add("Transmisión: " + txtTrans.Text);
            finan.lbOculto.Items.Add("Motor: " + txtMotor.Text);
            finan.lbOculto.Items.Add("Cilindros: " + txtCilindros.Text);
            finan.lbOculto.Items.Add("Precio base del auto: $ " + txtPBase.Text + " MX");
            finan.lbOculto.Items.Add("Precio de modificaciones: $ " + txtMods.Text + " MX");
            finan.lbOculto.Items.Add("Subtotal de la venta: $ " + txtSub.Text + " MX");
            finan.lbOculto.Items.Add("Iva calculado: " + txtIva.Text + " MX");
            finan.lbOculto.Items.Add("Total: $ " + txtTotal.Text + " MX");
            finan.Show();
        }
    }
}
