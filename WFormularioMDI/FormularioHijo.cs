using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFormularioMDI
{
    public partial class frmFormularioHijo : Form
    {
        public frmFormularioHijo()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog1.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                    foreach (string linea in txtContenido.Lines)
                    {
                        wrtGuardar.WriteLine(linea);
                    }
                    wrtGuardar.Close();
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);  
            }
        }
    }
}
