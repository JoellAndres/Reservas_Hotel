namespace AdminReservasHotel.PLayers
{
    partial class frmEliminarReserva
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.txtDniTitular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.lblCodigoId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblNHabitacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(163, 430);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 29);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(143, 105);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(71, 28);
            this.btnBuscarReserva.TabIndex = 15;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // txtDniTitular
            // 
            this.txtDniTitular.Location = new System.Drawing.Point(163, 69);
            this.txtDniTitular.Margin = new System.Windows.Forms.Padding(2);
            this.txtDniTitular.Name = "txtDniTitular";
            this.txtDniTitular.Size = new System.Drawing.Size(168, 20);
            this.txtDniTitular.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dni del titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese el D.N.I del titular de la reserva para buscarla y luego eliminarla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliminar una reserva";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCantidadPersonas);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblPago);
            this.groupBox1.Controls.Add(this.lblNHabitacion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminarReserva);
            this.groupBox1.Location = new System.Drawing.Point(34, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 267);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la reserva encontrada";
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(98, 222);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(121, 29);
            this.btnEliminarReserva.TabIndex = 0;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // lblCodigoId
            // 
            this.lblCodigoId.AutoSize = true;
            this.lblCodigoId.Location = new System.Drawing.Point(135, 25);
            this.lblCodigoId.Name = "lblCodigoId";
            this.lblCodigoId.Size = new System.Drawing.Size(16, 13);
            this.lblCodigoId.TabIndex = 31;
            this.lblCodigoId.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Codigo de reserva: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cantidad de Personas:";
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(164, 165);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(16, 13);
            this.lblCantidadPersonas.TabIndex = 28;
            this.lblCantidadPersonas.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Estado de pago:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(135, 193);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(16, 13);
            this.lblPago.TabIndex = 26;
            this.lblPago.Text = "...";
            // 
            // lblNHabitacion
            // 
            this.lblNHabitacion.AutoSize = true;
            this.lblNHabitacion.Location = new System.Drawing.Point(113, 128);
            this.lblNHabitacion.Name = "lblNHabitacion";
            this.lblNHabitacion.Size = new System.Drawing.Size(16, 13);
            this.lblNHabitacion.TabIndex = 25;
            this.lblNHabitacion.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Habitacion";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(129, 94);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(16, 13);
            this.lblFechaSalida.TabIndex = 23;
            this.lblFechaSalida.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de Salida";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(135, 55);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(16, 13);
            this.lblFechaIngreso.TabIndex = 21;
            this.lblFechaIngreso.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // frmEliminarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(383, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.txtDniTitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEliminarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Reserva";
            this.Load += new System.EventHandler(this.frmEliminarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtDniTitular;
        private System.Windows.Forms.Button btnEliminarReserva;
        internal System.Windows.Forms.Label lblCodigoId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label lblPago;
        internal System.Windows.Forms.Label lblNHabitacion;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox groupBox1;
    }
}