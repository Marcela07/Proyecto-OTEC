using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores pr = new Profesores();
            pr.MdiParent = this;
            pr.Show();
            

        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoAlumno na = new NuevoAlumno();
            na.MdiParent = this;
            na.Show();
        }
    }
}
