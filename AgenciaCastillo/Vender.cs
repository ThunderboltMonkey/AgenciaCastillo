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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }

        // Declara una nueva instancia de la forma "Negociacion", luego esconde la forma activa
        // y muestra la forma "Negociacion"
        Negociacion neg = new Negociacion();

        ErrorProvider error = new ErrorProvider();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar para un nuevo registro
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtEdicion.Clear();
            txtCilindros.Clear();
            txtColor.Clear();
            txtMotor.Clear();
            txtYear.Clear();
            lbArchivo.Items.Clear();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
            
        }


        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

            if (txtCelular.Text == "")
            {
                error.SetError(txtCelular, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
            
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtEdicion_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                error.SetError(txtYear, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

                       
        }

        private void txtMotor_TextChanged(object sender, EventArgs e)
        {
            if (txtMotor.Text == "")
            {
                error.SetError(txtMotor, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }

        }

        private void txtCilindros_TextChanged(object sender, EventArgs e)
        {
            if (txtCilindros.Text == "")
            {
                error.SetError(txtCilindros, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }

        }

        private void txtCilindros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string mensajeError;
            if (!CorreoValido(txtCorreo.Text, out mensajeError))
            {
                e.Cancel = true;
                txtCorreo.Select(0, txtCorreo.Text.Length);
                this.error.SetError(txtCorreo, mensajeError);
            }
        }

        public bool CorreoValido(string correo, out string mensajeError)
        {
            if(correo.Length == 0)
            {
                mensajeError = "Favor de introducir su correo.";
                return false;
            }

            if(correo.IndexOf("@") > -1)
            {
                if(correo.IndexOf(".",correo.IndexOf("@")) > correo.IndexOf("@"))
                {
                    mensajeError = "";
                    return true;
                }
            }

            mensajeError = "El correo necesita tener un formato válido. \n Por ejemplo: 'Alguien@algo.com'";
            return false;
        }



        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            error.SetError(txtCorreo, "");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                error.SetError(txtNombre, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellido.Text == "")
            {
                error.SetError(txtApellido, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (txtMarca.Text == "")
            {
                error.SetError(txtMarca, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtModelo_Validating(object sender, CancelEventArgs e)
        {
            if (txtModelo.Text == "")
            {
                error.SetError(txtModelo, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtEdicion_Validating(object sender, CancelEventArgs e)
        {
            if (txtEdicion.Text == "")
            {
                error.SetError(txtEdicion, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtColor_Validating(object sender, CancelEventArgs e)
        {
            if (txtColor.Text == "")
            {
                error.SetError(txtColor, "El campo es obligatorio");
            }
            else
            {
                error.Clear();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int year = 0;

            if(txtNombre.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtNombre),"E R R O R");
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtApellido), "E R R O R");
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtCorreo), "E R R O R");
            }
            else if (txtCelular.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtCelular), "E R R O R");
            }
            else if (txtMarca.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtMarca), "E R R O R");
            }
            else if (txtModelo.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtModelo), "E R R O R");
            }
            else if (txtEdicion.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtEdicion), "E R R O R");
            }
            else if (txtYear.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtYear), "E R R O R");
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtColor), "E R R O R");
            }
            else if (txtYear.Text != "")
            {
                year = Convert.ToInt32(txtYear.Text);
                
                if (year >= 2014 && year <= 2019)
                {

                }
                else
                {
                    MessageBox.Show("Ingrese un año de vehículo válido y aceptado por la agencia", "A V I S O");
                }
            }
            else if (txtMotor.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtMotor), "E R R O R");
            }
            else if (txtCilindros.Text == "")
            {
                MessageBox.Show("Campo vacío: " + error.GetError(txtCilindros), "E R R O R");
            }
            else
            {
                neg.Show();
            }

            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }  
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }  
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }  
        }

        private void txtEdicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }  
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }  
        }

        private void txtMotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }  
        }
    }
}
