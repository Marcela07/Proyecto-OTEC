namespace home
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.salasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProfesorToolStripMenuItem});
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.iToolStripMenuItem.Text = "Profesores";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAlumnoToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // nuevoProfesorToolStripMenuItem
            // 
            this.nuevoProfesorToolStripMenuItem.Name = "nuevoProfesorToolStripMenuItem";
            this.nuevoProfesorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevoProfesorToolStripMenuItem.Text = "Nuevo Profesor";
            this.nuevoProfesorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProfesorToolStripMenuItem_Click);
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            this.nuevoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlumnoToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSalasToolStripMenuItem,
            this.nuevaSalaToolStripMenuItem});
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // listaSalasToolStripMenuItem
            // 
            this.listaSalasToolStripMenuItem.Name = "listaSalasToolStripMenuItem";
            this.listaSalasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listaSalasToolStripMenuItem.Text = "Lista Salas";
            // 
            // nuevaSalaToolStripMenuItem
            // 
            this.nuevaSalaToolStripMenuItem.Name = "nuevaSalaToolStripMenuItem";
            this.nuevaSalaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaSalaToolStripMenuItem.Text = "Nueva Sala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OTEC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSalasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSalaToolStripMenuItem;
    }
}

