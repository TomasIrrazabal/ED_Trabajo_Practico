namespace ED_Trabajo_Practico
{
    partial class frmGestorDeTurnos
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
            gbInicio = new GroupBox();
            btnIngresar = new Button();
            txtDniIngreso = new TextBox();
            labelIngresoDni = new Label();
            gbRecepcion = new GroupBox();
            panel1 = new Panel();
            btnAceptar = new Button();
            chkEsCliente = new CheckBox();
            txtDniMesaIngreso = new TextBox();
            radAtencionPersonal = new RadioButton();
            radCaja = new RadioButton();
            lblTramites = new Label();
            lblDniRecepcion = new Label();
            lblMesaInformes = new Label();
            btnSiguienteMesaIngreso = new Button();
            dgvColaIngreso = new DataGridView();
            gbCajas = new GroupBox();
            dgvCaja = new DataGridView();
            txtAtendiendoCaja = new TextBox();
            btnIniciarCaja = new Button();
            lblAtendientoCaja = new Label();
            gbAP = new GroupBox();
            dgvAP = new DataGridView();
            btnIniciarAP = new Button();
            txtAtendiendoAP = new TextBox();
            label1 = new Label();
            gbInicio.SuspendLayout();
            gbRecepcion.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColaIngreso).BeginInit();
            gbCajas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
            gbAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAP).BeginInit();
            SuspendLayout();
            // 
            // gbInicio
            // 
            gbInicio.Controls.Add(btnIngresar);
            gbInicio.Controls.Add(txtDniIngreso);
            gbInicio.Controls.Add(labelIngresoDni);
            gbInicio.Location = new Point(10, 12);
            gbInicio.Name = "gbInicio";
            gbInicio.Size = new Size(200, 83);
            gbInicio.TabIndex = 0;
            gbInicio.TabStop = false;
            gbInicio.Text = "Ingreso";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(112, 40);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDniIngreso
            // 
            txtDniIngreso.Location = new Point(6, 40);
            txtDniIngreso.Name = "txtDniIngreso";
            txtDniIngreso.Size = new Size(100, 23);
            txtDniIngreso.TabIndex = 1;
            // 
            // labelIngresoDni
            // 
            labelIngresoDni.AutoSize = true;
            labelIngresoDni.Location = new Point(6, 22);
            labelIngresoDni.Name = "labelIngresoDni";
            labelIngresoDni.Size = new Size(30, 15);
            labelIngresoDni.TabIndex = 0;
            labelIngresoDni.Text = "DNI:";
            // 
            // gbRecepcion
            // 
            gbRecepcion.Controls.Add(panel1);
            gbRecepcion.Controls.Add(lblMesaInformes);
            gbRecepcion.Controls.Add(btnSiguienteMesaIngreso);
            gbRecepcion.Location = new Point(235, 12);
            gbRecepcion.Name = "gbRecepcion";
            gbRecepcion.Size = new Size(479, 164);
            gbRecepcion.TabIndex = 1;
            gbRecepcion.TabStop = false;
            gbRecepcion.Text = "Recepción";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(chkEsCliente);
            panel1.Controls.Add(txtDniMesaIngreso);
            panel1.Controls.Add(radAtencionPersonal);
            panel1.Controls.Add(radCaja);
            panel1.Controls.Add(lblTramites);
            panel1.Controls.Add(lblDniRecepcion);
            panel1.Location = new Point(147, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 145);
            panel1.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(233, 112);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // chkEsCliente
            // 
            chkEsCliente.AutoSize = true;
            chkEsCliente.Location = new Point(86, 116);
            chkEsCliente.Name = "chkEsCliente";
            chkEsCliente.Size = new Size(77, 19);
            chkEsCliente.TabIndex = 6;
            chkEsCliente.Text = "Es Cliente";
            chkEsCliente.UseVisualStyleBackColor = true;
            // 
            // txtDniMesaIngreso
            // 
            txtDniMesaIngreso.Enabled = false;
            txtDniMesaIngreso.Location = new Point(86, 3);
            txtDniMesaIngreso.Name = "txtDniMesaIngreso";
            txtDniMesaIngreso.Size = new Size(100, 23);
            txtDniMesaIngreso.TabIndex = 4;
            // 
            // radAtencionPersonal
            // 
            radAtencionPersonal.AutoSize = true;
            radAtencionPersonal.Location = new Point(86, 66);
            radAtencionPersonal.Name = "radAtencionPersonal";
            radAtencionPersonal.Size = new Size(121, 19);
            radAtencionPersonal.TabIndex = 3;
            radAtencionPersonal.TabStop = true;
            radAtencionPersonal.Text = "Atención Personal";
            radAtencionPersonal.UseVisualStyleBackColor = true;
            // 
            // radCaja
            // 
            radCaja.AutoSize = true;
            radCaja.Location = new Point(86, 38);
            radCaja.Name = "radCaja";
            radCaja.Size = new Size(48, 19);
            radCaja.TabIndex = 2;
            radCaja.TabStop = true;
            radCaja.Text = "Caja";
            radCaja.UseVisualStyleBackColor = true;
            // 
            // lblTramites
            // 
            lblTramites.AutoSize = true;
            lblTramites.Location = new Point(15, 37);
            lblTramites.Name = "lblTramites";
            lblTramites.Size = new Size(54, 15);
            lblTramites.TabIndex = 1;
            lblTramites.Text = "Tramites:";
            // 
            // lblDniRecepcion
            // 
            lblDniRecepcion.AutoSize = true;
            lblDniRecepcion.Location = new Point(15, 8);
            lblDniRecepcion.Name = "lblDniRecepcion";
            lblDniRecepcion.Size = new Size(30, 15);
            lblDniRecepcion.TabIndex = 0;
            lblDniRecepcion.Text = "DNI:";
            // 
            // lblMesaInformes
            // 
            lblMesaInformes.AutoSize = true;
            lblMesaInformes.Location = new Point(14, 25);
            lblMesaInformes.Name = "lblMesaInformes";
            lblMesaInformes.Size = new Size(93, 15);
            lblMesaInformes.TabIndex = 1;
            lblMesaInformes.Text = "Mesa de Ingreso";
            // 
            // btnSiguienteMesaIngreso
            // 
            btnSiguienteMesaIngreso.Location = new Point(14, 43);
            btnSiguienteMesaIngreso.Name = "btnSiguienteMesaIngreso";
            btnSiguienteMesaIngreso.Size = new Size(75, 23);
            btnSiguienteMesaIngreso.TabIndex = 0;
            btnSiguienteMesaIngreso.Text = "Siguiente";
            btnSiguienteMesaIngreso.UseVisualStyleBackColor = true;
            btnSiguienteMesaIngreso.Click += btnSiguienteMesaIngreso_Click;
            // 
            // dgvColaIngreso
            // 
            dgvColaIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColaIngreso.Location = new Point(10, 98);
            dgvColaIngreso.Name = "dgvColaIngreso";
            dgvColaIngreso.ReadOnly = true;
            dgvColaIngreso.Size = new Size(200, 376);
            dgvColaIngreso.TabIndex = 2;
            // 
            // gbCajas
            // 
            gbCajas.Controls.Add(dgvCaja);
            gbCajas.Controls.Add(txtAtendiendoCaja);
            gbCajas.Controls.Add(btnIniciarCaja);
            gbCajas.Controls.Add(lblAtendientoCaja);
            gbCajas.Location = new Point(235, 182);
            gbCajas.Name = "gbCajas";
            gbCajas.Size = new Size(233, 292);
            gbCajas.TabIndex = 3;
            gbCajas.TabStop = false;
            gbCajas.Text = "Cajas";
            // 
            // dgvCaja
            // 
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(7, 79);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.ReadOnly = true;
            dgvCaja.Size = new Size(220, 207);
            dgvCaja.TabIndex = 3;
            // 
            // txtAtendiendoCaja
            // 
            txtAtendiendoCaja.Enabled = false;
            txtAtendiendoCaja.Location = new Point(95, 50);
            txtAtendiendoCaja.Name = "txtAtendiendoCaja";
            txtAtendiendoCaja.Size = new Size(132, 23);
            txtAtendiendoCaja.TabIndex = 2;
            // 
            // btnIniciarCaja
            // 
            btnIniciarCaja.Location = new Point(7, 22);
            btnIniciarCaja.Name = "btnIniciarCaja";
            btnIniciarCaja.Size = new Size(75, 23);
            btnIniciarCaja.TabIndex = 1;
            btnIniciarCaja.Text = "Iniciar";
            btnIniciarCaja.UseVisualStyleBackColor = true;
            btnIniciarCaja.Click += btnIniciarCaja_Click;
            // 
            // lblAtendientoCaja
            // 
            lblAtendientoCaja.AutoSize = true;
            lblAtendientoCaja.Location = new Point(7, 54);
            lblAtendientoCaja.Name = "lblAtendientoCaja";
            lblAtendientoCaja.Size = new Size(83, 15);
            lblAtendientoCaja.TabIndex = 0;
            lblAtendientoCaja.Text = "Atendiendo A:";
            // 
            // gbAP
            // 
            gbAP.Controls.Add(dgvAP);
            gbAP.Controls.Add(btnIniciarAP);
            gbAP.Controls.Add(txtAtendiendoAP);
            gbAP.Controls.Add(label1);
            gbAP.Location = new Point(481, 182);
            gbAP.Name = "gbAP";
            gbAP.Size = new Size(233, 292);
            gbAP.TabIndex = 4;
            gbAP.TabStop = false;
            gbAP.Text = "Atención Personal";
            // 
            // dgvAP
            // 
            dgvAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAP.Location = new Point(6, 79);
            dgvAP.Name = "dgvAP";
            dgvAP.ReadOnly = true;
            dgvAP.Size = new Size(220, 207);
            dgvAP.TabIndex = 7;
            // 
            // btnIniciarAP
            // 
            btnIniciarAP.Location = new Point(6, 22);
            btnIniciarAP.Name = "btnIniciarAP";
            btnIniciarAP.Size = new Size(75, 23);
            btnIniciarAP.TabIndex = 5;
            btnIniciarAP.Text = "Iniciar";
            btnIniciarAP.UseVisualStyleBackColor = true;
            btnIniciarAP.Click += btnIniciarAP_Click;
            // 
            // txtAtendiendoAP
            // 
            txtAtendiendoAP.Enabled = false;
            txtAtendiendoAP.Location = new Point(94, 50);
            txtAtendiendoAP.Name = "txtAtendiendoAP";
            txtAtendiendoAP.Size = new Size(132, 23);
            txtAtendiendoAP.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Atendiendo A:";
            // 
            // frmGestorDeTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 486);
            Controls.Add(gbAP);
            Controls.Add(gbCajas);
            Controls.Add(dgvColaIngreso);
            Controls.Add(gbRecepcion);
            Controls.Add(gbInicio);
            Name = "frmGestorDeTurnos";
            Text = "Gestor de turnos";
            gbInicio.ResumeLayout(false);
            gbInicio.PerformLayout();
            gbRecepcion.ResumeLayout(false);
            gbRecepcion.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColaIngreso).EndInit();
            gbCajas.ResumeLayout(false);
            gbCajas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            gbAP.ResumeLayout(false);
            gbAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInicio;
        private GroupBox gbRecepcion;
        private DataGridView dgvColaIngreso;
        private Button btnIngresar;
        private TextBox txtDniIngreso;
        private Label labelIngresoDni;
        private Label lblMesaInformes;
        private Button btnSiguienteMesaIngreso;
        private Panel panel1;
        private Label lblTramites;
        private Label lblDniRecepcion;
        private TextBox txtDniMesaIngreso;
        private RadioButton radAtencionPersonal;
        private RadioButton radCaja;
        private Button btnAceptar;
        private CheckBox chkEsCliente;
        private GroupBox gbCajas;
        private GroupBox gbAP;
        private DataGridView dgvCaja;
        private TextBox txtAtendiendoCaja;
        private Button btnIniciarCaja;
        private Label lblAtendientoCaja;
        private DataGridView dgvAP;
        private Button btnIniciarAP;
        private TextBox txtAtendiendoAP;
        private Label label1;
    }
}
