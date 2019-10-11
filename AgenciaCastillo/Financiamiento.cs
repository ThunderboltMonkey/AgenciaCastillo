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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AgenciaCastillo
{
    public partial class Financiamiento : Form
    {
        public Financiamiento()
        {
            InitializeComponent();
        }

        public void Ofrecer()
        {
            // Declara una nueva instancia de la forma "Autonuevo", luego esconde la forma activa
            // y muestra la forma "Autonuevo"
            Vender ven = new Vender();
            ven.Show();
        }

        public double enganche;

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Financiamiento_Load(object sender, EventArgs e)
        {
            cbOpciones.SelectedIndex = 0;
            cbEnganche.SelectedIndex = 0;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double precio = 0;
            double diferencia = 0;

            // Selección de opciónes para el enganche
            if (cbEnganche.SelectedIndex == 0)
            {
                precio = Convert.ToDouble(txtPrecio.Text);
                enganche = precio * 0.20;
                txtEnganche.Text = enganche.ToString();
              
            }
            else if (cbEnganche.SelectedIndex == 1)
            {
                precio = Convert.ToDouble(txtPrecio.Text);
                enganche = precio * 0.30;
                txtEnganche.Text = enganche.ToString();
            }
            else if (cbEnganche.SelectedIndex == 2)
            {
                precio = Convert.ToDouble(txtPrecio.Text);
                enganche = precio * 0.35;
                txtEnganche.Text = enganche.ToString();
            }
            else if (cbEnganche.SelectedIndex == 3)
            {
                precio = Convert.ToDouble(txtPrecio.Text);
                enganche = precio * 0.40;
                txtEnganche.Text = enganche.ToString();
            }
            else
            {
                precio = Convert.ToDouble(txtPrecio.Text);
                enganche = precio * 0.50;
                txtEnganche.Text = enganche.ToString();
            }

            // Selección de opciones para el plazo de pago
            if (cbOpciones.SelectedIndex == 0)
            {
                diferencia = precio - Convert.ToDouble(txtEnganche.Text);
                txtMensualidad.Text = (Math.Ceiling(diferencia / 24)).ToString();
            }
            else if (cbOpciones.SelectedIndex == 1)
            {
                diferencia = precio - Convert.ToDouble(txtEnganche.Text);
                txtMensualidad.Text = (Math.Ceiling(diferencia / 36)).ToString();
            }
            else
            {
                diferencia = precio - Convert.ToDouble(txtEnganche.Text);
                txtMensualidad.Text = (Math.Ceiling(diferencia / 48)).ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            foreach (object lista in lbOculto.Items)
            {
                richTextBox1.Text =  richTextBox1.Text + "\n\r" + lista.ToString();
            }

            richTextBox1.Text = richTextBox1.Text + "\n\rPorcentaje de enganche = " + cbEnganche.Text;
            richTextBox1.Text = richTextBox1.Text + "\n\rEnganche = $ " + txtEnganche.Text + " MX";
            richTextBox1.Text = richTextBox1.Text + "\n\rPlazo a pagar = " + cbOpciones.Text;
            richTextBox1.Text = richTextBox1.Text + "\n\rMensualidad =  $ " + txtMensualidad.Text + " MX";

            if(MessageBox.Show("¿Desea guardar la cotización", "GUARDAR", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("No se ha guardado el archivo", "ERROR", MessageBoxButtons.OK);
            }


        }

        private void Guardar()
        {
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\\Users\\Monkey\\Documents\\Visual Studio 2013\\Projects\\AgenciaCastillo\\AgenciaCastillo\\images\\sentranegro.jpg");            
            imagen.BorderWidth = 5;
            imagen.Alignment = Element.ALIGN_CENTER;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\\Users\\Monkey\\Documents\\Visual Studio 2013\\Projects\\AgenciaCastillo\\AgenciaCastillo\\images\\Logo.png");
            logo.BorderWidth = 5;
            logo.Alignment = Element.ALIGN_CENTER;
            float percentage1 = 0.0f;
            percentage1 = 150 / logo.Width;
            logo.ScalePercent(percentage1 * 100);

            Chunk chunk = new Chunk("AGENCIA CASTILLO", FontFactory.GetFont("dax-black", 25f, 1));
            chunk.SetUnderline(0.5f, -1.5f);

            Chunk chunk1 = new Chunk(logo, 30f, 10f);

            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(imagen);
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1; //0=Left, 1=Center, 2=Right
            table.AddCell(cell);
            table.AddCell(lbOculto.Items[0].ToString());
            table.AddCell(lbOculto.Items[1].ToString());
            table.AddCell(lbOculto.Items[2].ToString());
            table.AddCell(lbOculto.Items[3].ToString());
            table.AddCell(lbOculto.Items[4].ToString());
            table.AddCell(lbOculto.Items[5].ToString());
            table.AddCell(lbOculto.Items[6].ToString());
            table.AddCell(lbOculto.Items[7].ToString());
            table.AddCell(lbOculto.Items[8].ToString());
            table.AddCell(lbOculto.Items[9].ToString());
            table.AddCell(lbOculto.Items[10].ToString());
            table.AddCell(lbOculto.Items[11].ToString());
            table.AddCell(lbOculto.Items[12].ToString());
            table.AddCell("Precio total: " + txtPrecio.Text + " MX");
            table.AddCell("Porcentaje de enganche: " + cbEnganche.Text);
            table.AddCell("Total de enganche: $ " + txtEnganche.Text + " MX");
            table.AddCell("Plazo de pago: " + cbOpciones.Text);
            table.AddCell("La mensualidad es de: $ " + txtMensualidad.Text + " MX");

            Stream stream1;
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                if ((stream1 = guardar.OpenFile()) != null)
                {
                    Document doc = new Document(PageSize.LETTER, 40, 40, 30, 20);
                    PdfWriter.GetInstance(doc, stream1);
                    doc.Open();
                    doc.Add(new Paragraph(chunk));
                    doc.Add(new Paragraph(""));                    
                    //doc.Add(new Paragraph(chunk1));
                    doc.Add(new Paragraph(""));
                    doc.Add(table);
                    doc.Close();
                }
                MessageBox.Show("Se ha guardado con éxito", "TODO CORRECTO", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?","S A L I R",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Gracias por consultarnos :)","AGENCIA CASTILLO",MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void btnOfrecer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ofrecer un auto a cuenta?", "AGENCIA CASTILLO", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Debe tener en cuenta lo siguiente:\n • El auto que puede ofrecer a cuenta no debe ser mayor a 5 años.\n • El auto deberá ser evaluado por la agencia para poder indicarle el descuento al que puede ser acreedor.\n • Puede llevar su tiempo hacer la evaluación, nosotros lo contactaremos.\n • IMPORTANTE: El auto puede ser rechazado por la agencia lo que significa que no puede aplicarse un descuento al auto que desea comprar.", "A V I S O", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Ofrecer();
            }
        }
    }
}