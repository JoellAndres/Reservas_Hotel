namespace AdminReservasHotel.PLayers
{
    partial class frmConsultaDisponibilidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarDisp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de disponibilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de salida:";
            // 
            // dateTimeFechaIngreso
            // 
            this.dateTimeFechaIngreso.Location = new System.Drawing.Point(154, 41);
            this.dateTimeFechaIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFechaIngreso.MaxDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            this.dateTimeFechaIngreso.MinDate = new System.DateTime(2020, 11, 25, 0, 0, 0, 0);
            this.dateTimeFechaIngreso.Name = "dateTimeFechaIngreso";
            this.dateTimeFechaIngreso.Size = new System.Drawing.Size(237, 20);
            this.dateTimeFechaIngreso.TabIndex = 3;
            this.dateTimeFechaIngreso.Value = new System.DateTime(2020, 11, 25, 12, 2, 19, 0);
            // 
            // dateTimeFechaSalida
            // 
            this.dateTimeFechaSalida.Location = new System.Drawing.Point(154, 72);
            this.dateTimeFechaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFechaSalida.MaxDate = new System.DateTime(2025, 6, 30, 0, 0, 0, 0);
            this.dateTimeFechaSalida.MinDate = new System.DateTime(2020, 11, 26, 0, 0, 0, 0);
            this.dateTimeFechaSalida.Name = "dateTimeFechaSalida";
            this.dateTimeFechaSalida.Size = new System.Drawing.Size(237, 20);
            this.dateTimeFechaSalida.TabIndex = 4;
            this.dateTimeFechaSalida.Value = new System.DateTime(2020, 11, 26, 0, 0, 0, 0);
            // 
            // btnConsultarDisp
            // 
            this.btnConsultarDisp.Location = new System.Drawing.Point(140, 108);
            this.btnConsultarDisp.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarDisp.Name = "btnConsultarDisp";
            this.btnConsultarDisp.Size = new System.Drawing.Size(110, 37);
            this.btnConsultarDisp.TabIndex = 5;
            this.btnConsultarDisp.Text = "Consultar";
            this.btnConsultarDisp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(174, 352);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 30);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(402, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultarDisp);
            this.Controls.Add(this.dateTimeFechaSalida);
            this.Controls.Add(this.dateTimeFechaIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaDisponibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Disponibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFechaIngreso;
        private System.Windows.Forms.DateTimePicker dateTimeFechaSalida;
        private System.Windows.Forms.Button btnConsultarDisp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
    }
}