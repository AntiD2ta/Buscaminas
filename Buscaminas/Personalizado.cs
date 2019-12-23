using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Structure;

namespace Buscaminas
{
    public partial class Personalizado : Form
    {
        frmDrawing B = new frmDrawing();
       public int filas, columnas, minas;

        public Personalizado()
        {
            InitializeComponent();
        }

        private void Personalizado_Load(object sender, EventArgs e)
        {

        }

        private void bttonAceptar_Click(object sender, EventArgs e)
        {
            filas = (int)numPDFilas.Value;
            columnas = (int)numUPDColumnas.Value;
            minas = (int)numUPDMinas.Value;

            Close();
        }
    }
}