using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Record : Form
    {
        public string record;
        

        public Record()
        {
            InitializeComponent();
        }

        private void bttonGRecord_Click(object sender, EventArgs e)
        {
            record = textBox1.Text;//lee el texbox 
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
