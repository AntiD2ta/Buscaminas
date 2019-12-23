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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Buscaminas
{
    public partial class Records : Form
    {
        List<buscaminas> RecordGuardado;       

        public Records()
        {
            InitializeComponent();
            Iniciar();
        }
        
        public void Iniciar()
        {

            BinaryFormatter a = new BinaryFormatter();
            FileStream b = new FileStream("Records.Salva", FileMode.Open);
            RecordGuardado = (List<buscaminas>)a.Deserialize(b);
            b.Close();

            for (int i = 0; i < RecordGuardado.Count; i++) //poner valores en listbox
            {
                buscaminas actual = RecordGuardado[i];
                RecordsGuardados.Items.Add(actual);
            }           
        }

        
    }
}
