namespace AgenciaCastillo
{
    partial class Financiamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financiamiento));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblEnganche = new System.Windows.Forms.Label();
            this.cbEnganche = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnganche = new System.Windows.Forms.TextBox();
            this.txtMensualidad = new System.Windows.Forms.TextBox();
            this.lblMensualidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbOculto = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOfrecer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPCIONES DE FINANCIAMIENTO";
            // 
            // btnRegresar1
            // 
            this.btnRegresar1.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar1.BackgroundImage = global::AgenciaCastillo.Properties.Resources.Regresar;
            this.btnRegresar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar1.ForeColor = System.Drawing.Color.Silver;
            this.btnRegresar1.Location = new System.Drawing.Point(8, 6);
            this.btnRegresar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.Size = new System.Drawing.Size(61, 59);
            this.btnRegresar1.TabIndex = 10;
            this.btnRegresar1.UseVisualStyleBackColor = false;
            this.btnRegresar1.Click += new System.EventHandler(this.btnRegresar1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total ($ MX):";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(185, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(130, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // lblEnganche
            // 
            this.lblEnganche.AutoSize = true;
            this.lblEnganche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnganche.Location = new System.Drawing.Point(12, 145);
            this.lblEnganche.Name = "lblEnganche";
            this.lblEnganche.Size = new System.Drawing.Size(153, 20);
            this.lblEnganche.TabIndex = 18;
            this.lblEnganche.Text = "Enganche ($ MX):";
            // 
            // cbEnganche
            // 
            this.cbEnganche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnganche.FormattingEnabled = true;
            this.cbEnganche.Items.AddRange(new object[] {
            "20 %",
            "30 %",
            "35 %",
            "40 %",
            "50 %"});
            this.cbEnganche.Location = new System.Drawing.Point(185, 144);
            this.cbEnganche.Name = "cbEnganche";
            this.cbEnganche.Size = new System.Drawing.Size(130, 21);
            this.cbEnganche.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "=";
            // 
            // txtEnganche
            // 
            this.txtEnganche.Location = new System.Drawing.Point(346, 144);
            this.txtEnganche.Name = "txtEnganche";
            this.txtEnganche.ReadOnly = true;
            this.txtEnganche.Size = new System.Drawing.Size(130, 20);
            this.txtEnganche.TabIndex = 21;
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.Location = new System.Drawing.Point(185, 265);
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.ReadOnly = true;
            this.txtMensualidad.Size = new System.Drawing.Size(130, 20);
            this.txtMensualidad.TabIndex = 25;
            // 
            // lblMensualidad
            // 
            this.lblMensualidad.AutoSize = true;
            this.lblMensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensualidad.Location = new System.Drawing.Point(12, 263);
            this.lblMensualidad.Name = "lblMensualidad";
            this.lblMensualidad.Size = new System.Drawing.Size(173, 20);
            this.lblMensualidad.TabIndex = 24;
            this.lblMensualidad.Text = "Mensualidad ($ MX):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Plazo de pago:";
            // 
            // cbOpciones
            // 
            this.cbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Items.AddRange(new object[] {
            "24 Meses",
            "36 Meses",
            "48 Meses"});
            this.cbOpciones.Location = new System.Drawing.Point(185, 182);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(130, 21);
            this.cbOpciones.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(155, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 42);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar detalles";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbOculto
            // 
            this.lbOculto.FormattingEnabled = true;
            this.lbOculto.Location = new System.Drawing.Point(12, 318);
            this.lbOculto.Name = "lbOculto";
            this.lbOculto.Size = new System.Drawing.Size(112, 30);
            this.lbOculto.TabIndex = 27;
            this.lbOculto.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(492, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(307, 345);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // btnOfrecer
            // 
            this.btnOfrecer.Location = new System.Drawing.Point(260, 353);
            this.btnOfrecer.Name = "btnOfrecer";
            this.btnOfrecer.Size = new System.Drawing.Size(99, 42);
            this.btnOfrecer.TabIndex = 29;
            this.btnOfrecer.Text = "Ofrecer auto a cuenta";
            this.btnOfrecer.UseVisualStyleBackColor = true;
            this.btnOfrecer.Click += new System.EventHandler(this.btnOfrecer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(365, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 42);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picGuardar
            // 
            this.picGuardar.Location = new System.Drawing.Point(12, 354);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(112, 41);
            this.picGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuardar.TabIndex = 31;
            this.picGuardar.TabStop = false;
            this.picGuardar.Visible = false;
            // 
            // Financiamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(825, 432);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOfrecer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbOculto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMensualidad);
            this.Controls.Add(this.lblMensualidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOpciones);
            this.Controls.Add(this.txtEnganche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEnganche);
            this.Controls.Add(this.lblEnganche);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegresar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Financiamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia Castillo: Financiamiento";
            this.Load += new System.EventHandler(this.Financiamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar1;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblEnganche;
        private System.Windows.Forms.ComboBox cbEnganche;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEnganche;
        public System.Windows.Forms.TextBox txtMensualidad;
        private System.Windows.Forms.Label lblMensualidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOpciones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ListBox lbOculto;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOfrecer;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.PictureBox picGuardar;
    }
}