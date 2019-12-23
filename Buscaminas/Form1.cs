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
using System.Diagnostics;

namespace Buscaminas
{

    public partial class frmDrawing : Form
    {
        buscaminas T = new buscaminas(9, 9, 10);    // tablero by default
        Stopwatch crono = new Stopwatch();        

        public frmDrawing()
        {           
            InitializeComponent();
            Iniciar();           
        }

        public void RestartGrid()
        {           
            T = new buscaminas(T.Filas,T.Columnas,T.Minas);
            pbxGrid.Width = T.Columnas * 18;
            pbxGrid.Height = T.Filas * 18;
            this.Size = new System.Drawing.Size(pbxGrid.Width + 40, pbxGrid.Height + 140);
            pbxGrid.Refresh();
            RefrescarContador();
            crono.Restart();
            T.Marca = 0;
        }

        public void Iniciar()
        {
            pbxGrid.Width = T.Columnas * 18;
            pbxGrid.Height = T.Filas * 18;
            this.Size = new System.Drawing.Size(pbxGrid.Width + 40, pbxGrid.Height + 140);
            RefrescarContador();
            pbxGrid.Refresh();
            crono.Restart();
            T.Marca = 0;
        } 
                     
        private void pbxGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;           
            Pen p = new Pen(Color.Black, 2);                     
            int width = 18;
            int height = 18;
                   
            for (int i = 0; i < T.Filas; i++)
            {
                for (int j = 0; j < T.Columnas; j++)
                {
                    if (T.Celda[i, j])
                    {                        
                        switch (T.Tablero[i, j])
                        {
                            case 0:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C_Descubierta, j * width, i * height, width, height);
                                break;
                            case 1:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C1, j * width, i * height, width, height);
                                break;
                            case 2:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C2, j * width, i * height, width, height);
                                break;
                            case 3:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C3, j * width, i * height, width, height);
                                break;
                            case 4:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C4, j * width, i * height, width, height);
                                break;
                            case 5:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C5, j * width, i * height, width, height);
                                break;
                            case 6:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C6, j * width, i * height, width, height);
                                break;
                            case 7:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C7, j * width, i * height, width, height);
                                break;
                            case 8:
                                g.DrawImage(global::Buscaminas.Properties.Resources.C8, j * width, i * height, width, height);
                                break;
                            case -1:
                                g.DrawImage(global::Buscaminas.Properties.Resources.Mina, j * width, i * height, width, height);
                                break;
                            case -2:
                                g.DrawImage(global::Buscaminas.Properties.Resources.Last_Mine, j * width, i * height, width, height);
                                break;
                            case -3:
                                g.DrawImage(global::Buscaminas.Properties.Resources.MinaError, j * width, i * height, width, height);
                                break;                           
                        }                        
                    }
                    else
                    {                        
                        g.DrawImage(global::Buscaminas.Properties.Resources.C_Oculta, j * width, i * height, width, height); //Imagen de la celda oculta
                    }

                    #region Bandera y Interrogante

                    if (T.Flag[i,j])
                         g.DrawImage(global::Buscaminas.Properties.Resources.Bandera, j * width - 1, i * height - 1, width, height); //Imagen de la bandera
                    if(T.Interrogacion[i,j])
                        g.DrawImage(global::Buscaminas.Properties.Resources.interrog, j * width - 1, i * height - 1, width, height);

                    #endregion

                    #region Bandera sobre mina
                    if (T.Flag[i, j] && T.Tablero[i, j] == -1)
                    {
                        T.MinaError(i,j);
                    }
                    if (T.Tablero[i, j] == -3 && !T.Flag[i, j])
                    {
                        T.Tablero[i, j] = -1;
                    }
                    #endregion
                }
            }

            for (int i = 0; i < T.Filas; i++) //Dibujar lineas entre celdas
            {
                g.DrawLine(p, 0, i * width - 1, pbxGrid.Width, i * width - 1);
            }

            for (int j = 0; j < T.Columnas; j++)
            {
                g.DrawLine(p, j * height - 1, 0, j * height - 1, pbxGrid.Height);
            }
        }
                                       
        #region Juego

        private void pbxGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X * T.Columnas / pbxGrid.Width;
            int y = e.Y * T.Filas / pbxGrid.Height;

            crono.Start();

            switch (e.Button)
            { 
                case MouseButtons.Left:
                    buscaminas.WinCondition N = buscaminas.WinCondition.KeepPlaying;
                    if (T.Flag[y, x] || T.Interrogacion[y,x]) break;                   
                     N = T.Juego(y, x);
                     if (N == buscaminas.WinCondition.KeepPlaying)
                         pbxGrid.Refresh();
                     else
                     {
                         crono.Stop();
                         T.Marca = crono.ElapsedMilliseconds / 1000;
                         CondiciondeVictoria(N, y, x);
                     }
                    break;
                case MouseButtons.Right:
                    T.Flags(y,x);
                    RefrescarContador();
                    pbxGrid.Refresh();
                    break;            
            }                                                              
        } 

        private void CondiciondeVictoria(buscaminas.WinCondition N, int x, int y)
        {
            Derrota L = new Derrota();
            VictoriaP W = new VictoriaP();

            if (N == buscaminas.WinCondition.Win)
            {
                pbxGrid.Invalidate();
                T.DesFlags();
                T.MostrarMinas();
                pbxGrid.Refresh();
                W.ShowDialog();
                GuardarRecord();               
                RestartGrid();
            }
            else
            {               
                T.DesFlags();
                T.UltimaMina(x, y);
                T.MostrarMinas();
                pbxGrid.Refresh();
                L.ShowDialog();                           
                RestartGrid();
            }
        }

        #endregion
        

        #region Cronometro

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbxCronoU.Refresh();
            pbxCronoD.Refresh();
            pbxCronoC.Refresh();
        }

        private void pbxCrono_Paint(object sender, PaintEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            int index = int.Parse((string)box.Tag);

            string seg = (crono.ElapsedMilliseconds / 1000).ToString();
            Graphics g = e.Graphics;
                            
            if (seg.Length > index - 1)
                switch (seg[seg.Length - index])
                {
                    case '0':
                        g.DrawImage(Properties.Resources.cero, 0, 0, box.Width , box.Height);
                        break;
                    case '1':
                        g.DrawImage(Properties.Resources.uno, 0, 0, box.Width , box.Height);
                        break;
                    case '2':
                        g.DrawImage(Properties.Resources.dos, 0, 0, box.Width , box.Height);
                        break;
                    case '3':
                        g.DrawImage(Properties.Resources.tres, 0, 0, box.Width , box.Height);
                        break;
                    case '4':
                        g.DrawImage(Properties.Resources.cuatro, 0, 0, box.Width , box.Height);
                        break;
                    case '5':
                        g.DrawImage(Properties.Resources.cinco, 0, 0, box.Width , box.Height);
                        break;
                    case '6':
                        g.DrawImage(Properties.Resources.seis, 0, 0, box.Width , box.Height);
                        break;
                    case '7':
                        g.DrawImage(Properties.Resources.siete, 0, 0, box.Width , box.Height);
                        break;
                    case '8':
                        g.DrawImage(Properties.Resources.ocho, 0, 0, box.Width , box.Height);
                        break;
                    case '9':
                        g.DrawImage(Properties.Resources.nueve, 0, 0, box.Width , box.Height);
                        break;
                }
            else
                g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width , pbxCronoU.Height);
                                  
        }
        
        private void pbxCronoD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxCronoC_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region Dificultad de Juego

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T = new buscaminas(9, 9, 10);
            Iniciar();
            T.Dificultad = "fácil";
            crono.Restart();
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T = new buscaminas(16,16,40);
            T.Dificultad = "medio";
            Iniciar();            
            crono.Restart();
        }

        private void díficilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            T = new buscaminas(16, 30, 99);
            T.Dificultad = "díficil";
            Iniciar();           
            crono.Restart();
        }

        private void personalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personalizado p = new Personalizado();
            crono.Stop();
            p.ShowDialog();
            while (p.minas > (p.filas - 1) * (p.columnas - 1))
            {
                MessageBox.Show("La cantidad de minas no puede ser\nmayor que las dimensiones del tablero.");
                p.minas = 0;
                p.ShowDialog();
            }
            while (p.filas <= 0)
            {
                MessageBox.Show("La cantidad de filas tienen que ser\nmayores que cero.");
                p.filas = 0;
                p.ShowDialog();
            }
            while (p.columnas <= 0)
            {
                MessageBox.Show("La cantidad de columnas tienen que ser\nmayores que cero.");
                p.columnas = 0;
                p.ShowDialog();
            }
            T = new buscaminas(p.filas, p.columnas, p.minas);
            T.Dificultad = "personalizado";
            Iniciar();
        }

        #endregion
       
        #region Contador de Minas

        private void RefrescarContador()
        {
            pbxCantMinasU.Refresh();
            pbxCantidadMinasD.Refresh();
            pbxCantMinasC.Refresh();
        }
       
        private void pbxCantMinasU_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string cont = T.CantidadDBanderas.ToString();

            if (cont.Length > 0)
            switch(cont[cont.Length - 1])
            {
                case '0':
                    g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '1':
                    g.DrawImage(Properties.Resources.uno, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '2':
                    g.DrawImage(Properties.Resources.dos, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '3':
                    g.DrawImage(Properties.Resources.tres, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '4':
                    g.DrawImage(Properties.Resources.cuatro, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '5':
                    g.DrawImage(Properties.Resources.cinco, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '6':
                    g.DrawImage(Properties.Resources.seis, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '7':
                    g.DrawImage(Properties.Resources.siete, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '8':
                    g.DrawImage(Properties.Resources.ocho, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
                case '9':
                    g.DrawImage(Properties.Resources.nueve, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                    break;
            }
            else
                g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
        }

        private void pbxCantidadMinasD_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string cont = T.CantidadDBanderas.ToString();

            if (cont.Length >= 2)
                switch (cont[cont.Length - 2])
                {
                    case '0':
                        g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '1':
                        g.DrawImage(Properties.Resources.uno, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '2':
                        g.DrawImage(Properties.Resources.dos, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '3':
                        g.DrawImage(Properties.Resources.tres, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '4':
                        g.DrawImage(Properties.Resources.cuatro, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '5':
                        g.DrawImage(Properties.Resources.cinco, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '6':
                        g.DrawImage(Properties.Resources.seis, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '7':
                        g.DrawImage(Properties.Resources.siete, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '8':
                        g.DrawImage(Properties.Resources.ocho, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '9':
                        g.DrawImage(Properties.Resources.nueve, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '-':
                       g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                }
            else
                g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
        }

        private void pbxCantMinasC_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string cont = T.CantidadDBanderas.ToString();

            if (cont.Length >= 3)
                switch (cont[cont.Length - 3])
                {
                    case '0':
                        g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '1':
                        g.DrawImage(Properties.Resources.uno, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '2':
                        g.DrawImage(Properties.Resources.dos, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '3':
                        g.DrawImage(Properties.Resources.tres, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '4':
                        g.DrawImage(Properties.Resources.cuatro, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '5':
                        g.DrawImage(Properties.Resources.cinco, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '6':
                        g.DrawImage(Properties.Resources.seis, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '7':
                        g.DrawImage(Properties.Resources.siete, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '8':
                        g.DrawImage(Properties.Resources.ocho, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;
                    case '9':
                        g.DrawImage(Properties.Resources.nueve, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
                        break;                   
                }
            else
                g.DrawImage(Properties.Resources.cero, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
            if (T.CantidadDBanderas < 0)
                g.DrawImage(Properties.Resources.menos, 0, 0, pbxCronoU.Width, pbxCronoU.Height);
        }

#endregion

        #region Miscelaneas

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //Cerrar ventana

        private void frmDrawing_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'f':
                    Application.Exit();
                    break;
                case '*':
                    T.MostrarMinas();
                    pbxGrid.Refresh();
                    break;
                case '/':
                    T.OcultarMinas();
                    pbxGrid.Refresh();
                    break;
                case 'r':
                    RestartGrid();
                    break;
            }

        } //Hot Keys

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGrid();
        }//Nuevo Juego

        #endregion

        #region Record

        public void GuardarRecord()
        {
            List<buscaminas> RecordGuardado; // todos los records guardados

            if (File.Exists("Records.Salva")) // si existe , lo cargo
            {
                BinaryFormatter a = new BinaryFormatter();
                FileStream file = new FileStream("Records.Salva", FileMode.Open);
                RecordGuardado = (List<buscaminas>)a.Deserialize(file);
                file.Close();
            }
            else  // si no, inicializo     
                RecordGuardado = new List<buscaminas>();

            Record p = new Record();
            p.ShowDialog();
            T.record = p.record;
            T.record = T.record + "                          " + T.Marca.ToString() + " seg" + "                      " + T.Dificultad;
            RecordGuardado.Add(T);

            //guardar
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file1 = new FileStream("Records.Salva", FileMode.OpenOrCreate);
            formatter.Serialize(file1, RecordGuardado);
            file1.Close();
        }

        private void recordsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("Records.Salva"))
            {
                Records a = new Records();
                a.ShowDialog();
                RestartGrid();
            }
        }

        #endregion

        
    }
}
