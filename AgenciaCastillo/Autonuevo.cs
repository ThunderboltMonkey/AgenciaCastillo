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
    
    public partial class Autonuevo : Form
    {
        public Autonuevo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Autonuevo.ActiveForm.Close();
        }

        /* ESPACIO PARA DECLARACIÓN DE VARIABLES */
        // Declaración de los precios base de los autos disponibles
        double focus = 190000;
        double hyundai = 230000;
        double sentra = 265000;
        // Declaración de precios de transmisiones
        double automatica = 15000;
        // Declaración de los precios de los colores
        double gris = 3000;
        double azul = 5000;
        double rojo = 5000;
        // Acumuladores para las modificaciones
        double modFocus = 0;
        double modHyundai = 0;
        double modSentra = 0;
        // Variable del subtotal correspondiente a cada auto
        double subFocus = 0;
        double subHyundai = 0;
        double subSentra = 0;
        // Variable del IVA correspondiente a cada auto
        double IFocus = 0;
        double IHyundai = 0;
        double ISentra = 0;
        /* TERMINA ESPACIO PARA DECLARACIÓN DE VARIABLES */

        /* CÓDIGO DE RADIOBUTTON PARA EL AUTO MARCA FORD */ 
        private void rbFord_CheckedChanged(object sender, EventArgs e)
        {
            // Si está seleccionado ese radioButton entonces mostrar en el pictureBox la imagen del auto en cuestión
            if (rbFord.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Negro.jpg");
            }
            // Seleccionar configuración por default para el auto
            rbNegro.Checked = true;
            rbv4.Checked = true;
            rbSport.Checked = true;
            rbManual.Checked = true;

            // Hacer invisibles dichos radioButtons ya que no entran en las especificaciones posibles del auto
            rbv8.Visible = false;
            rbDeluxe.Visible = false;
            rbSencillo.Visible = false;

            //Devolver visibilidad a configuraciones para otros autos
            rbManual.Visible = true;

            // Mostrar información en cajas de texto
            txtMarca.Text = "Ford";
            txtModelo.Text = "Focus";
            txtYear.Text = "2015";
            txtPBase.Text = focus.ToString();
        }
        /* TERMINA CÓDIGO DE RADIOBUTTON PARA EL AUTO MARCA FORD */

        /* CÓDIGO DE RADIOBUTTON PARA EL AUTO MARCA HYUNDAI */ 
        private void rbHyundai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHyundai.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantranegro.jpg");
            }

            // Seleccionar configuración por default para el auto
            rbNegro.Checked = true;
            rbv4.Checked = true;
            rbSencillo.Checked = true;
            rbManual.Checked = true;

            // Hacer invisibles dichos radioButtons ya que no entran en las especificaciones posibles del auto
            rbv8.Visible = false;
            rbDeluxe.Visible = false;

            //Devolver visibilidad a configuraciones para otros autos
            rbSencillo.Visible = true;
            rbManual.Visible = true;

            // Mostrar información en cajas de texto
            txtMarca.Text = "Hyundai";
            txtModelo.Text = "Elantra";
            txtYear.Text = "2014";
            txtPBase.Text = hyundai.ToString();
        }
        /* TERMINA CÓDIGO DE RADIOBUTTON PARA EL AUTO MARCA HYUNDAI */

        /* CÓDIGO DE RADIOBUTTON PARA EL AUTO MARCA NISSAN */ 
        private void rbNissan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNissan.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\sentranegro.jpg");
            }

            // Seleccionar configuración por default para el auto
            rbNegro.Checked = true;
            rbv4.Checked = true;
            rbSencillo.Checked = true;
            rbAutomatica.Checked = true;

            // Hacer invisibles dichos radioButtons ya que no entran en las especificaciones posibles del auto
            rbv8.Visible = false;
            rbManual.Visible = false;

            //Devolver visibilidad a configuraciones para otros autos
            rbSencillo.Visible = true;
            rbDeluxe.Visible = true;

            // Mostrar información en cajas de texto
            txtMarca.Text = "Nissan";
            txtModelo.Text = "Sentra";
            txtYear.Text = "2016";
            txtPBase.Text = sentra.ToString();
        }
        /* TERMINA CÓDIGO DE RADIOBUTTON PARA EL AUTO MARCA NISSAN */ 

        /* CÓDIGO DE RADIOBUTTON QUE MANIPULA EL COLOR NEGRO A MOSTRAR EL AUTO EN EL PICTUREBOX */ 
        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            // Si está seleccionado el modelo del auto y el color negro entonces mostrar el auto en ese color
            if (rbFord.Checked && rbNegro.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Negro.jpg");
            }

            if (rbHyundai.Checked && rbNegro.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantranegro.jpg");
            }

            if (rbNissan.Checked && rbNegro.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\sentranegro.jpg");
            }

            // Mostrar el color del auto
            txtColor.Text = "Negro";
        }
        /* TERMINA CÓDIGO DE RADIOBUTTON QUE MANIPULA EL COLOR NEGRO A MOSTRAR EL AUTO EN EL PICTUREBOX */



        /* CÓDIGO DE RADIOBUTTON QUE MANIPULA EL COLOR BLANCO A MOSTRAR EL AUTO EN EL PICTUREBOX */ 
        private void rbBlanco_CheckedChanged(object sender, EventArgs e)
        {

            // Si está seleccionado el modelo del auto y el color blanco entonces mostrar el auto en ese color
            if (rbFord.Checked && rbBlanco.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Blanco.jpg");
            }

            if (rbHyundai.Checked && rbBlanco.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantrablanco.jpg");
            }

            if (rbNissan.Checked && rbBlanco.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\sentrablanco.jpg");
            }

            // Mostrar el color del auto
            txtColor.Text = "Blanco";
        }
        /* TERMINA CÓDIGO DE RADIOBUTTON QUE MANIPULA EL COLOR BLANCO A MOSTRAR EL AUTO EN EL PICTUREBOX */ 

        // radioButton que manipula el color a mostrar el auto en el pictureBox
        private void rbGris_CheckedChanged(object sender, EventArgs e)
        {

            // Si está seleccionado el modelo del auto y el color gris entonces mostrar el auto en ese color
            if (rbFord.Checked && rbGris.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Gris.jpg");
            }

            if (rbHyundai.Checked && rbGris.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantragris.jpg");
            }

            if (rbNissan.Checked && rbGris.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Sentragris.jpg");
            }

            // Mostrar el color del auto
            txtColor.Text = "Gris";
        }

        // radioButton que manipula el color a mostrar el auto en el pictureBox
        private void rbAzul_CheckedChanged(object sender, EventArgs e)
        {

            // Si está seleccionado el modelo del auto y el color azul entonces mostrar el auto en ese color
            if (rbFord.Checked && rbAzul.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Azul.jpg");
            }

            if (rbHyundai.Checked && rbAzul.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantraazul.jpg");
            }

            if (rbNissan.Checked && rbAzul.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\sentraazul.jpg");
            }

            // Mostrar el color del auto
            txtColor.Text = "Azul";
        }

        // radioButton que manipula el color a mostrar el auto en el pictureBox
        private void rbRojo_CheckedChanged(object sender, EventArgs e)
        {

            // Si está seleccionado el modelo del auto y el color rojo entonces mostrar el auto en ese color
            if (rbFord.Checked && rbRojo.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Focus2015Rojo.jpg");
            }

            if (rbHyundai.Checked && rbRojo.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\Elantrarojo.jpg");
            }

            if (rbNissan.Checked && rbRojo.Checked)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(@"C:\Users\Monkey\Documents\Visual Studio 2013\Projects\AgenciaCastillo\AgenciaCastillo\images\sentrarojo.jpg");
            }

            // Mostrar el color del auto
            txtColor.Text = "Rojo";
        }

        private void rbSencillo_CheckedChanged(object sender, EventArgs e)
        {
            txtEdicion.Text = "Sencillo";
        }

        private void rbSport_CheckedChanged(object sender, EventArgs e)
        {
            txtEdicion.Text = "Sport";
        }

        private void rbDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            txtEdicion.Text = "De lujo";
        }

        private void rbv4_CheckedChanged(object sender, EventArgs e)
        {
            txtCilindros.Text = "4";


            if (rbFord.Checked)
            {
                txtMotor.Text = "1.6";
            }

            if (rbHyundai.Checked)
            {
                txtMotor.Text = "1.8";
            }

            if (rbNissan.Checked)
            {
                txtMotor.Text = "1.8";
            }
        }

        private void rbv6_CheckedChanged(object sender, EventArgs e)
        {
            txtCilindros.Text = "6";

            if (rbFord.Checked)
            {
                txtMotor.Text = "2.0";
            }

            if (rbHyundai.Checked)
            {
                txtMotor.Text = "2.0";
            }

            if (rbNissan.Checked)
            {
                txtMotor.Text = "2.4";
            }
        }

        private void rbv8_CheckedChanged(object sender, EventArgs e)
        {
            txtCilindros.Text = "8";

            if (rbFord.Checked)
            {
                txtMotor.Text = "2.4";
            }

            if (rbHyundai.Checked)
            {
                txtMotor.Text = "2.0";
            }

            if (rbNissan.Checked)
            {
                txtMotor.Text = "2.7";
            }
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            txtTrans.Text = "Manual";
        }

        private void rbAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            txtTrans.Text = "Automática";

            if (rbFord.Checked && rbAzul.Checked && rbAutomatica.Checked)
            {
                subFocus = 20000;
                txtMods.Text = subFocus.ToString();
            }

            if (rbHyundai.Checked && rbAzul.Checked && rbAutomatica.Checked)
            {
                subHyundai = 18000;
                txtMods.Text = subHyundai.ToString();
            }

            if (rbNissan.Checked && rbAzul.Checked && rbAutomatica.Checked)
            {
                subSentra = 18000;
                txtMods.Text = subSentra.ToString();
            }

            if (rbFord.Checked && rbGris.Checked && rbAutomatica.Checked)
            {
                subFocus = 18000;
                txtMods.Text = subFocus.ToString();
            }

            if (rbHyundai.Checked && rbGris.Checked && rbAutomatica.Checked)
            {
                subHyundai = 18000;
                txtMods.Text = subHyundai.ToString();
            }

            if (rbNissan.Checked && rbGris.Checked && rbAutomatica.Checked)
            {
                subSentra = 18000;
                txtMods.Text = subSentra.ToString();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Financiamiento fina = new Financiamiento();
            fina.txtPrecio.Text = textBox1.Text;
            fina.picGuardar.Image = pictureBox1.Image;
            
            //Agregar los datos al listBox oculto
            fina.lbOculto.Items.Add("Marca: " + txtMarca.Text);
            fina.lbOculto.Items.Add("Modelo: " + txtModelo.Text);
            fina.lbOculto.Items.Add("Edición: " + txtEdicion.Text);
            fina.lbOculto.Items.Add("Año: " + txtYear.Text);
            fina.lbOculto.Items.Add("Color: " + txtColor.Text);
            fina.lbOculto.Items.Add("Transmisión: " + txtTrans.Text);
            fina.lbOculto.Items.Add("Motor: " + txtMotor.Text);
            fina.lbOculto.Items.Add("Cilindros: " + txtCilindros.Text);
            fina.lbOculto.Items.Add("Precio base del auto: $ " + txtPBase.Text + " MX");
            fina.lbOculto.Items.Add("Precio de modificaciones: $ " + txtMods.Text + " MX");
            fina.lbOculto.Items.Add("Subtotal de la venta: $ " + txtSub.Text + " MX");
            fina.lbOculto.Items.Add("Iva calculado: " + txtIva.Text + " MX");
            fina.lbOculto.Items.Add("Total: $ " + textBox1.Text + " MX");
            fina.Show();
        }

        private void Autonuevo_Load(object sender, EventArgs e)
        {
            rbFord.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bloque de condiciones para el radioButton "rbAutomatica"
            if (rbFord.Checked && rbAzul.Checked && rbAutomatica.Checked)
            {
                subFocus = 20000;
                txtMods.Text = subFocus.ToString();
                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString(); 
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbAzul.Checked && rbAutomatica.Checked)
            {
                subHyundai = 20000;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbAzul.Checked && rbAutomatica.Checked)
            {
                subSentra = 20000;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbRojo.Checked && rbAutomatica.Checked)
            {
                subFocus = 20000;
                txtMods.Text = subFocus.ToString();
                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbRojo.Checked && rbAutomatica.Checked)
            {
                subHyundai = 20000;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbRojo.Checked && rbAutomatica.Checked)
            {
                subSentra = 20000;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbGris.Checked && rbAutomatica.Checked)
            {
                subFocus = 18000;
                txtMods.Text = subFocus.ToString();

                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbGris.Checked && rbAutomatica.Checked)
            {
                subHyundai = 18000;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbGris.Checked && rbAutomatica.Checked)
            {
                subSentra = 18000;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbBlanco.Checked && rbAutomatica.Checked)
            {
                subFocus = 0;
                txtMods.Text = subFocus.ToString();

                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbBlanco.Checked && rbAutomatica.Checked)
            {
                subHyundai = 0;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbBlanco.Checked && rbAutomatica.Checked)
            {
                subSentra = 0;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbNegro.Checked && rbAutomatica.Checked)
            {
                subFocus = 0;
                txtMods.Text = subFocus.ToString();

                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbNegro.Checked && rbAutomatica.Checked)
            {
                subHyundai = 0;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbNegro.Checked && rbAutomatica.Checked)
            {
                subSentra = 0;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            //Bloque de condiciones para el radioButton "rbManual"
            if (rbFord.Checked && rbAzul.Checked && rbManual.Checked)
            {
                subFocus = 5000;
                txtMods.Text = subFocus.ToString();
                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbAzul.Checked && rbManual.Checked)
            {
                subHyundai = 5000;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbAzul.Checked && rbManual.Checked)
            {
                subSentra = 5000;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbRojo.Checked && rbManual.Checked)
            {
                subFocus = 5000;
                txtMods.Text = subFocus.ToString();
                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbRojo.Checked && rbManual.Checked)
            {
                subHyundai = 5000;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbRojo.Checked && rbManual.Checked)
            {
                subSentra = 5000;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbGris.Checked && rbManual.Checked)
            {
                subFocus = 3000;
                txtMods.Text = subFocus.ToString();

                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbGris.Checked && rbManual.Checked)
            {
                subHyundai = 3000;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbGris.Checked && rbManual.Checked)
            {
                subSentra = 3000;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbBlanco.Checked && rbManual.Checked)
            {
                subFocus = 0;
                txtMods.Text = subFocus.ToString();
                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbBlanco.Checked && rbManual.Checked)
            {
                subHyundai = 0;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbBlanco.Checked && rbManual.Checked)
            {
                subSentra = 0;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }

            if (rbFord.Checked && rbNegro.Checked && rbManual.Checked)
            {
                subFocus = 0;
                txtMods.Text = subFocus.ToString();
                // subtotal
                modFocus = focus + subFocus;
                txtSub.Text = modFocus.ToString();
                // iva
                IFocus = modFocus * 0.16;
                txtIva.Text = IFocus.ToString();
                // total
                textBox1.Text = (modFocus + IFocus).ToString();
            }

            if (rbHyundai.Checked && rbNegro.Checked && rbManual.Checked)
            {
                subHyundai = 0;
                txtMods.Text = subHyundai.ToString();
                // subtotal
                modHyundai = hyundai + subHyundai;
                txtSub.Text = modHyundai.ToString();
                // iva
                IHyundai = modHyundai * 0.16;
                txtIva.Text = IHyundai.ToString();
                // total
                textBox1.Text = (modHyundai + IHyundai).ToString();
            }

            if (rbNissan.Checked && rbNegro.Checked && rbManual.Checked)
            {
                subSentra = 0;
                txtMods.Text = subSentra.ToString();
                // subtotal
                modSentra = sentra + subSentra;
                txtSub.Text = modSentra.ToString();
                // iva
                ISentra = modSentra * 0.16;
                txtIva.Text = ISentra.ToString();
                // total
                textBox1.Text = (modSentra + ISentra).ToString();
            }
        }
    }
}
