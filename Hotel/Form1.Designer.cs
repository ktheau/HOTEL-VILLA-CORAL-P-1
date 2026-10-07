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
            ckTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            btnFinSemana = new Button();
            chkFinSemana = new CheckBox();
            btnDeposito = new Button();
            btnPorPersona = new Button();
            nudPersonas = new NumericUpDown();
            lblPersonas = new Label();
            nudTarifa = new NumericUpDown();
            label2 = new Label();
            btnPesos = new Button();
            lblTasa = new Label();
            nudTasa = new NumericUpDown();
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
            btnNivel1 = new Button();
            btnNivel1p6 = new Button();
            btnNivel1p4 = new Button();
            btnNivel1p3 = new Button();
            btnNivel1p2 = new Button();
            btnNivel1p5 = new Button();
            btnNivel1p7 = new Button();
            btnNivel1p8 = new Button();
            btnNivel1p9 = new Button();
            btnNivel1p10 = new Button();
            btnDesglose = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
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
            txtHuesped.Location = new Point(81, 38);
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
            nudNoches.Location = new Point(75, 84);
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
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(4, 264);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(188, 24);
            ckTemporada.TabIndex = 7;
            ckTemporada.Text = "Temporada alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.Location = new Point(19, 353);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(84, 32);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(149, 353);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 32);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(btnDesglose);
            gbCotizador.Controls.Add(btnFinSemana);
            gbCotizador.Controls.Add(chkFinSemana);
            gbCotizador.Controls.Add(btnDeposito);
            gbCotizador.Controls.Add(btnPorPersona);
            gbCotizador.Controls.Add(nudPersonas);
            gbCotizador.Controls.Add(lblPersonas);
            gbCotizador.Controls.Add(nudTarifa);
            gbCotizador.Controls.Add(label2);
            gbCotizador.Controls.Add(btnPesos);
            gbCotizador.Controls.Add(lblTasa);
            gbCotizador.Controls.Add(nudTasa);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Location = new Point(12, 25);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(786, 315);
            gbCotizador.TabIndex = 10;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(406, 261);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(109, 29);
            btnFinSemana.TabIndex = 18;
            btnFinSemana.Text = "Confirmar";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(222, 264);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(178, 24);
            chkFinSemana.TabIndex = 17;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(411, 128);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(159, 32);
            btnDeposito.TabIndex = 16;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(411, 81);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(159, 32);
            btnPorPersona.TabIndex = 15;
            btnPorPersona.Text = "Costo por Persona:";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // nudPersonas
            // 
            nudPersonas.DecimalPlaces = 2;
            nudPersonas.Location = new Point(567, 39);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(150, 27);
            nudPersonas.TabIndex = 14;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(411, 41);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(150, 20);
            lblPersonas.TabIndex = 13;
            lblPersonas.Text = "Numero de personas:";
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(160, 121);
            nudTarifa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(150, 27);
            nudTarifa.TabIndex = 12;
            nudTarifa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 213);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 11;
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(0, 207);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(159, 32);
            btnPesos.TabIndex = 10;
            btnPesos.Text = "Total en RD$:";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(0, 169);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(104, 20);
            lblTasa.TabIndex = 9;
            lblTasa.Text = "Tasa del dolar:";
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(110, 167);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(150, 27);
            nudTasa.TabIndex = 8;
            nudTasa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudTasa.ValueChanged += nudTasa_ValueChanged;
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
            gbTotales.Location = new Point(16, 409);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(454, 142);
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
            btnCopiarPorWhasapp.Location = new Point(12, 571);
            btnCopiarPorWhasapp.Name = "btnCopiarPorWhasapp";
            btnCopiarPorWhasapp.Size = new Size(180, 32);
            btnCopiarPorWhasapp.TabIndex = 12;
            btnCopiarPorWhasapp.Text = "Copiar Por Whatsapp";
            btnCopiarPorWhasapp.UseVisualStyleBackColor = true;
            // 
            // btnImperactivo
            // 
            btnImperactivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnImperactivo.Location = new Point(215, 571);
            btnImperactivo.Name = "btnImperactivo";
            btnImperactivo.Size = new Size(180, 32);
            btnImperactivo.TabIndex = 13;
            btnImperactivo.Text = "Imperativo";
            btnImperactivo.UseVisualStyleBackColor = true;
            btnImperactivo.Click += btnImperactivo_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(824, 25);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(540, 564);
            lstResultados.TabIndex = 14;
            // 
            // btnNivel1
            // 
            btnNivel1.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1.Location = new Point(1391, 66);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(84, 32);
            btnNivel1.TabIndex = 15;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // btnNivel1p6
            // 
            btnNivel1p6.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p6.Location = new Point(1391, 281);
            btnNivel1p6.Name = "btnNivel1p6";
            btnNivel1p6.Size = new Size(84, 32);
            btnNivel1p6.TabIndex = 16;
            btnNivel1p6.Text = "Nivel 1.6";
            btnNivel1p6.UseVisualStyleBackColor = true;
            btnNivel1p6.Click += btnNivel1p6_Click;
            // 
            // btnNivel1p4
            // 
            btnNivel1p4.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p4.Location = new Point(1391, 194);
            btnNivel1p4.Name = "btnNivel1p4";
            btnNivel1p4.Size = new Size(84, 32);
            btnNivel1p4.TabIndex = 17;
            btnNivel1p4.Text = "Nivel 1.4";
            btnNivel1p4.UseVisualStyleBackColor = true;
            btnNivel1p4.Click += btnNivel1p4_Click;
            // 
            // btnNivel1p3
            // 
            btnNivel1p3.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p3.Location = new Point(1391, 153);
            btnNivel1p3.Name = "btnNivel1p3";
            btnNivel1p3.Size = new Size(84, 32);
            btnNivel1p3.TabIndex = 18;
            btnNivel1p3.Text = "Nivel 1.3";
            btnNivel1p3.UseVisualStyleBackColor = true;
            btnNivel1p3.Click += btnNivel1p3_Click;
            // 
            // btnNivel1p2
            // 
            btnNivel1p2.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p2.Location = new Point(1391, 109);
            btnNivel1p2.Name = "btnNivel1p2";
            btnNivel1p2.Size = new Size(84, 27);
            btnNivel1p2.TabIndex = 19;
            btnNivel1p2.Text = "Nivel 1.2";
            btnNivel1p2.UseVisualStyleBackColor = true;
            btnNivel1p2.Click += btnNivel1p2_Click;
            // 
            // btnNivel1p5
            // 
            btnNivel1p5.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p5.Location = new Point(1391, 232);
            btnNivel1p5.Name = "btnNivel1p5";
            btnNivel1p5.Size = new Size(84, 32);
            btnNivel1p5.TabIndex = 20;
            btnNivel1p5.Text = "Nivel 1.5";
            btnNivel1p5.UseVisualStyleBackColor = true;
            btnNivel1p5.Click += btnNivel1p5_Click;
            // 
            // btnNivel1p7
            // 
            btnNivel1p7.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p7.Location = new Point(1391, 334);
            btnNivel1p7.Name = "btnNivel1p7";
            btnNivel1p7.Size = new Size(84, 32);
            btnNivel1p7.TabIndex = 21;
            btnNivel1p7.Text = "Nivel 1.7";
            btnNivel1p7.UseVisualStyleBackColor = true;
            btnNivel1p7.Click += btnNivel1p7_Click;
            // 
            // btnNivel1p8
            // 
            btnNivel1p8.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p8.Location = new Point(1391, 391);
            btnNivel1p8.Name = "btnNivel1p8";
            btnNivel1p8.Size = new Size(84, 32);
            btnNivel1p8.TabIndex = 22;
            btnNivel1p8.Text = "Nivel 1.8";
            btnNivel1p8.UseVisualStyleBackColor = true;
            btnNivel1p8.Click += btnNivel1p8_Click;
            // 
            // btnNivel1p9
            // 
            btnNivel1p9.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p9.Location = new Point(1391, 438);
            btnNivel1p9.Name = "btnNivel1p9";
            btnNivel1p9.Size = new Size(84, 30);
            btnNivel1p9.TabIndex = 23;
            btnNivel1p9.Text = "Nivel 1.9";
            btnNivel1p9.UseVisualStyleBackColor = true;
            btnNivel1p9.Click += btnNivel1p9_Click;
            // 
            // btnNivel1p10
            // 
            btnNivel1p10.BackgroundImageLayout = ImageLayout.Stretch;
            btnNivel1p10.Location = new Point(1391, 492);
            btnNivel1p10.Name = "btnNivel1p10";
            btnNivel1p10.Size = new Size(84, 32);
            btnNivel1p10.TabIndex = 24;
            btnNivel1p10.Text = "Nivel 1.10";
            btnNivel1p10.UseVisualStyleBackColor = true;
            btnNivel1p10.Click += btnNivel1p10_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(536, 259);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(115, 29);
            btnDesglose.TabIndex = 19;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 705);
            Controls.Add(btnNivel1p10);
            Controls.Add(btnNivel1p9);
            Controls.Add(btnNivel1p8);
            Controls.Add(btnNivel1p7);
            Controls.Add(btnNivel1p5);
            Controls.Add(btnNivel1p2);
            Controls.Add(btnNivel1p3);
            Controls.Add(btnNivel1p4);
            Controls.Add(btnNivel1p6);
            Controls.Add(btnNivel1);
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
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
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
        private Button btnNivel1;
        private Button btnNivel1p6;
        private Button btnNivel1p4;
        private Button btnNivel1p3;
        private Button btnNivel1p2;
        private Button btnNivel1p5;
        private Button btnNivel1p7;
        private Button btnNivel1p8;
        private Button btnNivel1p9;
        private Button btnNivel1p10;
        private NumericUpDown nudTasa;
        private NumericUpDown numericUpDown2;
        private Label lblTasa;
        private Button btnPesos;
        private Label label2;
        private NumericUpDown nudTarifa;
        private Label lblPersonas;
        private NumericUpDown nudPersonas;
        private Button btnPorPersona;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnDesglose;
    }
}
