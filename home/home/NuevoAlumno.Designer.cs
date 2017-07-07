namespace home
{
    partial class NuevoAlumno
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.txtEmailContacto = new System.Windows.Forms.TextBox();
            this.cbxEstadoAlumno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgwAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(565, 103);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(544, 41);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(135, 20);
            this.txtApellidoMaterno.TabIndex = 4;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(365, 41);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(134, 20);
            this.txtApellidoPaterno.TabIndex = 3;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(12, 41);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(137, 20);
            this.txtRut.TabIndex = 1;
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Location = new System.Drawing.Point(204, 104);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.Size = new System.Drawing.Size(134, 20);
            this.txtTelefonoContacto.TabIndex = 6;
            // 
            // txtEmailContacto
            // 
            this.txtEmailContacto.Location = new System.Drawing.Point(365, 104);
            this.txtEmailContacto.Name = "txtEmailContacto";
            this.txtEmailContacto.Size = new System.Drawing.Size(181, 20);
            this.txtEmailContacto.TabIndex = 7;
            // 
            // cbxEstadoAlumno
            // 
            this.cbxEstadoAlumno.FormattingEnabled = true;
            this.cbxEstadoAlumno.Location = new System.Drawing.Point(12, 103);
            this.cbxEstadoAlumno.Name = "cbxEstadoAlumno";
            this.cbxEstadoAlumno.Size = new System.Drawing.Size(137, 21);
            this.cbxEstadoAlumno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono Contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email Contacto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado Alumno";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(155, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgwAlumnos
            // 
            this.dgwAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlumnos.Location = new System.Drawing.Point(15, 239);
            this.dgwAlumnos.Name = "dgwAlumnos";
            this.dgwAlumnos.Size = new System.Drawing.Size(667, 112);
            this.dgwAlumnos.TabIndex = 16;
            // 
            // NuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.dgwAlumnos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoAlumno);
            this.Controls.Add(this.txtEmailContacto);
            this.Controls.Add(this.txtTelefonoContacto);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAceptar);
            this.Name = "NuevoAlumno";
            this.Text = "NuevoAlumno";
            this.Load += new System.EventHandler(this.NuevoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.TextBox txtEmailContacto;
        private System.Windows.Forms.ComboBox cbxEstadoAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgwAlumnos;
    }
}