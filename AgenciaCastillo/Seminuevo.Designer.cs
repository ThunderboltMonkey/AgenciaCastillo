namespace AgenciaCastillo
{
    partial class Seminuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seminuevo));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHyundai = new System.Windows.Forms.RadioButton();
            this.rbFord = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtCilindros = new System.Windows.Forms.TextBox();
            this.lblCilindros = new System.Windows.Forms.Label();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.lblTrans = new System.Windows.Forms.Label();
            this.txtMods = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPBase = new System.Windows.Forms.TextBox();
            this.lblPBase = new System.Windows.Forms.Label();
            this.gbAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(504, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 27);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Atrás";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(400, 418);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(99, 27);
            this.btnSiguiente.TabIndex = 67;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.rbHonda);
            this.gbAuto.Controls.Add(this.rbToyota);
            this.gbAuto.Controls.Add(this.rbNissan);
            this.gbAuto.Controls.Add(this.rbHyundai);
            this.gbAuto.Controls.Add(this.rbFord);
            this.gbAuto.Location = new System.Drawing.Point(10, 197);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Size = new System.Drawing.Size(297, 131);
            this.gbAuto.TabIndex = 43;
            this.gbAuto.TabStop = false;
            this.gbAuto.Text = "Auto";
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHonda.Location = new System.Drawing.Point(3, 108);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(161, 20);
            this.rbHonda.TabIndex = 4;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "Honda Accord 2013";
            this.rbHonda.UseVisualStyleBackColor = true;
            this.rbHonda.CheckedChanged += new System.EventHandler(this.rbHonda_CheckedChanged);
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbToyota.Location = new System.Drawing.Point(3, 85);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(150, 20);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "Toyota Prius 2015";
            this.rbToyota.UseVisualStyleBackColor = true;
            this.rbToyota.CheckedChanged += new System.EventHandler(this.rbToyota_CheckedChanged);
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNissan.Location = new System.Drawing.Point(3, 62);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(159, 20);
            this.rbNissan.TabIndex = 2;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "Nissan Sentra 2016";
            this.rbNissan.UseVisualStyleBackColor = true;
            this.rbNissan.CheckedChanged += new System.EventHandler(this.rbNissan_CheckedChanged);
            // 
            // rbHyundai
            // 
            this.rbHyundai.AutoSize = true;
            this.rbHyundai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHyundai.Location = new System.Drawing.Point(3, 39);
            this.rbHyundai.Name = "rbHyundai";
            this.rbHyundai.Size = new System.Drawing.Size(172, 20);
            this.rbHyundai.TabIndex = 1;
            this.rbHyundai.TabStop = true;
            this.rbHyundai.Text = "Hyandui Elantra 2014";
            this.rbHyundai.UseVisualStyleBackColor = true;
            this.rbHyundai.CheckedChanged += new System.EventHandler(this.rbHyundai_CheckedChanged);
            // 
            // rbFord
            // 
            this.rbFord.AutoSize = true;
            this.rbFord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFord.Location = new System.Drawing.Point(3, 16);
            this.rbFord.Name = "rbFord";
            this.rbFord.Size = new System.Drawing.Size(140, 20);
            this.rbFord.TabIndex = 0;
            this.rbFord.TabStop = true;
            this.rbFord.Text = "Ford Focus 2015";
            this.rbFord.UseVisualStyleBackColor = true;
            this.rbFord.CheckedChanged += new System.EventHandler(this.rbFord_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(487, 380);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(170, 20);
            this.txtTotal.TabIndex = 63;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(325, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 16);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "Total (M.N.):";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(487, 350);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(170, 20);
            this.txtIva.TabIndex = 61;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(325, 351);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(81, 16);
            this.lblIva.TabIndex = 60;
            this.lblIva.Text = "IVA (M.N.):";
            // 
            // txtSub
            // 
            this.txtSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.Location = new System.Drawing.Point(487, 320);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(170, 20);
            this.txtSub.TabIndex = 59;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(325, 321);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(114, 16);
            this.lblSub.TabIndex = 58;
            this.lblSub.Text = "Subtotal (M.N.):";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.Location = new System.Drawing.Point(487, 76);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.ReadOnly = true;
            this.txtEdicion.Size = new System.Drawing.Size(170, 20);
            this.txtEdicion.TabIndex = 57;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.Location = new System.Drawing.Point(325, 77);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(64, 16);
            this.lblEdicion.TabIndex = 56;
            this.lblEdicion.Text = "Edición:";
            // 
            // txtCilindros
            // 
            this.txtCilindros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCilindros.Location = new System.Drawing.Point(487, 230);
            this.txtCilindros.Name = "txtCilindros";
            this.txtCilindros.ReadOnly = true;
            this.txtCilindros.Size = new System.Drawing.Size(170, 20);
            this.txtCilindros.TabIndex = 55;
            // 
            // lblCilindros
            // 
            this.lblCilindros.AutoSize = true;
            this.lblCilindros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindros.Location = new System.Drawing.Point(325, 231);
            this.lblCilindros.Name = "lblCilindros";
            this.lblCilindros.Size = new System.Drawing.Size(73, 16);
            this.lblCilindros.TabIndex = 54;
            this.lblCilindros.Text = "Cilindros:";
            // 
            // txtMotor
            // 
            this.txtMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotor.Location = new System.Drawing.Point(487, 200);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.ReadOnly = true;
            this.txtMotor.Size = new System.Drawing.Size(170, 20);
            this.txtMotor.TabIndex = 53;
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotor.Location = new System.Drawing.Point(325, 201);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(51, 16);
            this.lblMotor.TabIndex = 52;
            this.lblMotor.Text = "Motor:";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(487, 136);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(170, 20);
            this.txtColor.TabIndex = 51;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(325, 137);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 16);
            this.lblColor.TabIndex = 50;
            this.lblColor.Text = "Color:";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(487, 106);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(170, 20);
            this.txtYear.TabIndex = 49;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(325, 107);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 48;
            this.lblYear.Text = "Año:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(487, 46);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(170, 20);
            this.txtModelo.TabIndex = 47;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(325, 47);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(64, 16);
            this.lblModelo.TabIndex = 46;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(487, 16);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(170, 20);
            this.txtMarca.TabIndex = 45;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(325, 17);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 16);
            this.lblMarca.TabIndex = 44;
            this.lblMarca.Text = "Marca:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // txtTrans
            // 
            this.txtTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrans.Location = new System.Drawing.Point(487, 168);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.ReadOnly = true;
            this.txtTrans.Size = new System.Drawing.Size(170, 20);
            this.txtTrans.TabIndex = 72;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrans.Location = new System.Drawing.Point(325, 169);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(97, 16);
            this.lblTrans.TabIndex = 71;
            this.lblTrans.Text = "Transmisión:";
            // 
            // txtMods
            // 
            this.txtMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMods.Location = new System.Drawing.Point(487, 293);
            this.txtMods.Name = "txtMods";
            this.txtMods.ReadOnly = true;
            this.txtMods.Size = new System.Drawing.Size(170, 20);
            this.txtMods.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Modificaciones (M.N.):";
            // 
            // txtPBase
            // 
            this.txtPBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPBase.Location = new System.Drawing.Point(487, 263);
            this.txtPBase.Name = "txtPBase";
            this.txtPBase.ReadOnly = true;
            this.txtPBase.Size = new System.Drawing.Size(170, 20);
            this.txtPBase.TabIndex = 74;
            // 
            // lblPBase
            // 
            this.lblPBase.AutoSize = true;
            this.lblPBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPBase.Location = new System.Drawing.Point(325, 264);
            this.lblPBase.Name = "lblPBase";
            this.lblPBase.Size = new System.Drawing.Size(141, 16);
            this.lblPBase.TabIndex = 73;
            this.lblPBase.Text = "Precio base (M.N.):";
            // 
            // Seminuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(678, 449);
            this.Controls.Add(this.txtMods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPBase);
            this.Controls.Add(this.lblPBase);
            this.Controls.Add(this.txtTrans);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbAuto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.txtCilindros);
            this.Controls.Add(this.lblCilindros);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seminuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia Castillo: Seminuevo";
            this.gbAuto.ResumeLayout(false);
            this.gbAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHyundai;
        private System.Windows.Forms.RadioButton rbFord;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtCilindros;
        private System.Windows.Forms.Label lblCilindros;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.TextBox txtMods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPBase;
        private System.Windows.Forms.Label lblPBase;
    }
}