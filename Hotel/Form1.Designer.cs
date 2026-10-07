namespace Hotel
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblHuesped = new Label();
            txtHuesped = new TextBox();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            txtTarifa = new TextBox();
            ckTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            gbTotales = new GroupBox();
            lbl_Total = new Label();
            lbl_Servicio = new Label();
            lbl_ITBIS = new Label();
            lbl_Descuento = new Label();
            lbl_Subtotal = new Label();
            lblTotal = new Label();
            lblServicio = new Label();
            lblITBIS = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            btnCopiarPorWhasapp = new Button();
            btnImperactivo = new Button();
            lstResultados = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(395, 48);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(0, 41);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(75, 20);
            lblHuesped.TabIndex = 1;
            lblHuesped.Text = "Huesped: ";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(165, 37);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.PlaceholderText = "PONGA EL NOMBRE";
            txtHuesped.Size = new Size(271, 27);
            txtHuesped.TabIndex = 2;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(4, 84);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(65, 20);
            lblNoches.TabIndex = 3;
            lblNoches.Text = "Noches: ";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(286, 84);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 4;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(0, 128);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 5;
            lblTarifa.Text = "Tarifa por noche (USD)";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(165, 125);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(271, 27);
            txtTarifa.TabIndex = 6;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(4, 169);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(188, 24);
            ckTemporada.TabIndex = 7;
            ckTemporada.Text = "Temporada alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.Location = new Point(19, 334);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(84, 32);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(144, 334);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 32);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Location = new Point(12, 25);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(458, 303);
            gbCotizador.TabIndex = 10;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lbl_Total);
            gbTotales.Controls.Add(lbl_Servicio);
            gbTotales.Controls.Add(lbl_ITBIS);
            gbTotales.Controls.Add(lbl_Descuento);
            gbTotales.Controls.Add(lbl_Subtotal);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblITBIS);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Location = new Point(16, 391);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(454, 114);
            gbTotales.TabIndex = 11;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(282, 57);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(24, 28);
            lbl_Total.TabIndex = 9;
            lbl_Total.Text = "0";
            // 
            // lbl_Servicio
            // 
            lbl_Servicio.AutoSize = true;
            lbl_Servicio.Location = new Point(282, 28);
            lbl_Servicio.Name = "lbl_Servicio";
            lbl_Servicio.Size = new Size(17, 20);
            lbl_Servicio.TabIndex = 8;
            lbl_Servicio.Text = "0";
            // 
            // lbl_ITBIS
            // 
            lbl_ITBIS.AutoSize = true;
            lbl_ITBIS.Location = new Point(93, 91);
            lbl_ITBIS.Name = "lbl_ITBIS";
            lbl_ITBIS.Size = new Size(17, 20);
            lbl_ITBIS.TabIndex = 7;
            lbl_ITBIS.Text = "0";
            // 
            // lbl_Descuento
            // 
            lbl_Descuento.AutoSize = true;
            lbl_Descuento.Location = new Point(93, 57);
            lbl_Descuento.Name = "lbl_Descuento";
            lbl_Descuento.Size = new Size(17, 20);
            lbl_Descuento.TabIndex = 6;
            lbl_Descuento.Text = "0";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Location = new Point(90, 28);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(17, 20);
            lbl_Subtotal.TabIndex = 5;
            lbl_Subtotal.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(218, 57);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(218, 28);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(61, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "Servicio";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(8, 91);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(42, 20);
            lblITBIS.TabIndex = 2;
            lblITBIS.Text = "ITBIS";
            lblITBIS.Click += lblITBIS_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(8, 57);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(8, 28);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal";
            // 
            // btnCopiarPorWhasapp
            // 
            btnCopiarPorWhasapp.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopiarPorWhasapp.Location = new Point(24, 525);
            btnCopiarPorWhasapp.Name = "btnCopiarPorWhasapp";
            btnCopiarPorWhasapp.Size = new Size(180, 32);
            btnCopiarPorWhasapp.TabIndex = 12;
            btnCopiarPorWhasapp.Text = "Copiar Por Whatsapp";
            btnCopiarPorWhasapp.UseVisualStyleBackColor = true;
            // 
            // btnImperactivo
            // 
            btnImperactivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnImperactivo.Location = new Point(215, 525);
            btnImperactivo.Name = "btnImperactivo";
            btnImperactivo.Size = new Size(180, 32);
            btnImperactivo.TabIndex = 13;
            btnImperactivo.Text = "Imperactico";
            btnImperactivo.UseVisualStyleBackColor = true;
            btnImperactivo.Click += btnImperactivo_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(563, 25);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(540, 564);
            lstResultados.TabIndex = 14;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 609);
            Controls.Add(lstResultados);
            Controls.Add(btnImperactivo);
            Controls.Add(btnCopiarPorWhasapp);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Controls.Add(btnLimpiar);
            Controls.Add(button1);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral - Kimberly Ashley, 2025-0505";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label lblHuesped;
        private TextBox txtHuesped;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private Label lblTarifa;
        private TextBox txtTarifa;
        private CheckBox ckTemporada;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private Label lblITBIS;
        private Label lblDescuento;
        private Label lblSubtotal;
        private Label lbl_Descuento;
        private Label lbl_Subtotal;
        private Label lblTotal;
        private Label lblServicio;
        private Label lbl_Total;
        private Label lbl_Servicio;
        private Label lbl_ITBIS;
        private Button btnCopiarPorWhasapp;
        private Button btnImperactivo;
        private ListBox lstResultados;
    }
}
