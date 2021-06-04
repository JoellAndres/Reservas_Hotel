namespace AdminReservasHotel.PLayers
{
    partial class frmIngresoAdmin
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
            this.txtCorreoAdmin = new System.Windows.Forms.TextBox();
            this.txtClaveClave = new System.Windows.Forms.TextBox();
            this.btnIngresarAdmin = new System.Windows.Forms.Button();
            this.btnCrearNuevoAdmin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su clave:";
            // 
            // txtCorreoAdmin
            // 
            this.txtCorreoAdmin.Location = new System.Drawing.Point(130, 28);
            this.txtCorreoAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoAdmin.Name = "txtCorreoAdmin";
            this.txtCorreoAdmin.Size = new System.Drawing.Size(181, 20);
            this.txtCorreoAdmin.TabIndex = 2;
            // 
            // txtClaveClave
            // 
            this.txtClaveClave.Location = new System.Drawing.Point(130, 60);
            this.txtClaveClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClaveClave.Name = "txtClaveClave";
            this.txtClaveClave.Size = new System.Drawing.Size(181, 20);
            this.txtClaveClave.TabIndex = 3;
            // 
            // btnIngresarAdmin
            // 
            this.btnIngresarAdmin.Location = new System.Drawing.Point(121, 92);
            this.btnIngresarAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresarAdmin.Name = "btnIngresarAdmin";
            this.btnIngresarAdmin.Size = new System.Drawing.Size(90, 29);
            this.btnIngresarAdmin.TabIndex = 4;
            this.btnIngresarAdmin.Text = "Ingresar";
            this.btnIngresarAdmin.UseVisualStyleBackColor = true;
            this.btnIngresarAdmin.Click += new System.EventHandler(this.btnIngresarAdmin_Click);
            // 
            // btnCrearNuevoAdmin
            // 
            this.btnCrearNuevoAdmin.Location = new System.Drawing.Point(76, 134);
            this.btnCrearNuevoAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearNuevoAdmin.Name = "btnCrearNuevoAdmin";
            this.btnCrearNuevoAdmin.Size = new System.Drawing.Size(180, 29);
            this.btnCrearNuevoAdmin.TabIndex = 5;
            this.btnCrearNuevoAdmin.Text = "Crear nuevo administrador";
            this.btnCrearNuevoAdmin.UseVisualStyleBackColor = true;
            this.btnCrearNuevoAdmin.Click += new System.EventHandler(this.btnCrearNuevoAdmin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(130, 180);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 29);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIngresoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(344, 229);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearNuevoAdmin);
            this.Controls.Add(this.btnIngresarAdmin);
            this.Controls.Add(this.txtClaveClave);
            this.Controls.Add(this.txtCorreoAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmIngresoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Administrador";
            this.Load += new System.EventHandler(this.frmIngresoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresarAdmin;
        private System.Windows.Forms.Button btnCrearNuevoAdmin;
        private System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.TextBox txtCorreoAdmin;
        internal System.Windows.Forms.TextBox txtClaveClave;
    }
}