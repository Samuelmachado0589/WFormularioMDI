using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormularioMDI
{
    public partial class frmFormularioPadre : Form
    {
        public frmFormularioPadre()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormularioHijo frmHijo = new frmFormularioHijo();  
            frmHijo.MdiParent = this;
            frmHijo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPadre = this.ActiveMdiChild;
            if (frmPadre != null) 
            {
                frmPadre.Close();            
            }
        }
    }
}
