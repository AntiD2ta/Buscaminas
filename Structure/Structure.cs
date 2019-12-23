using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Structure
{
     [Serializable]

    public class buscaminas
    {
        #region Variables

        int[,] tablero;
        int[] PosXminas;
        int[] PosYminas;
        int[] PosPrimerClick;
        int minas;
        int filas;
        int columnas;
        int cantidadDbanderas;
        long marca;
        bool[,] celda;
        bool[,] flag;
        bool[,] interrogacion;
        bool[,] posicionValida;
        bool primerClick;
        public string nombre;
        public string record;
        string dificultad;

        #endregion

        public buscaminas(int filas, int columnas, int minas)
        {
            if (filas * columnas <= minas - 8)
            throw new ArgumentException("La cantidad de minas no puede ser mayor que las dimensiones del tablero");

            this.filas = filas;
            this.columnas = columnas;
            this.minas = minas;
            this.cantidadDbanderas = minas;
            this.marca = 0;
            this.tablero = new int[filas, columnas];
            this.PosXminas = new int[minas];
            this.PosYminas = new int[minas];
            this.PosPrimerClick = new int[2];
            this.celda = new bool[filas, columnas];
            this.flag = new bool[filas, columnas];
            this.interrogacion = new bool[filas, columnas];
            this.posicionValida = new bool[filas,columnas];
            this.primerClick = false;
            this.dificultad = "fácil";
        } //Constructor

        #region Propiedades

        public int Filas
        { 
         get
            {
                return this.filas;
            }
        }
        public int Columnas
        {
            get
            {
                return this.columnas;
            }
        }
        public int Minas
        {
            get
            {
                return this.minas;
            }
        }
        public int CantidadDBanderas
        {
            get
            {
                return this.cantidadDbanderas;
            }
        }      
        public long Marca
        {
            get
            {
                return this.marca;
            }
            set
            { marca = value; }
        }
        public int[,] Tablero
        {
            get
            {
                return this.tablero;
            }
        }
        public bool[,] Celda
        {
            get
            {
                return this.celda;
            }
        }
        public bool[,] Flag
        {
            get
            {
                return this.flag;
            }
        }
        public bool[,] Interrogacion
        {
            get
            {
                return this.interrogacion;
            }
        }
        public bool PrimerClick
        {
            get
            {
                return this.primerClick;
            }
            set
            {
                if (primerClick)
                    primerClick = true;
                else
                    primerClick = false;
            }
        }
        public int[] posXminas
        {
            get
            {
                return this.PosXminas;
            }
        }
        public int[] posYminas
        {
            get
            {
                return this.PosYminas;
            }
        }
        public int[] posPrimerClick
        {
            get
            {
                return this.PosPrimerClick;
            }
        }
        public string Dificultad
        {
            get
            {
                return this.dificultad;
            }
            set
            { dificultad = value.ToString(); }
        }

        #endregion

        public override string ToString()
        {           
            return record;
        }

        #region Metodos Auxiliares

        public void ColocarMinas(int[,] tablero)
        {
            // N   NE  E  SE  S  SO  O  NO
            int[] FilaX = { -1, -1, 0, 1, 1, 1, 0, -1 };
            int[] ColumY = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int f = PosPrimerClick[0]; 
            int c = PosPrimerClick[1];

            posicionValida[f, c] = true;

            Random r = new Random();

            for (int i = 0; i < minas ; )
            {
                int X = r.Next(filas);
                int Y = r.Next(Columnas);
                for (int k = 0; k < FilaX.Length; k++)
                {
                    f = PosPrimerClick[0] + FilaX[k];
                    c = PosPrimerClick[1] + ColumY[k];
                    if (X == f && Y == c || FilaX[k] + f == X && ColumY[k] + c == Y || tablero[X, Y] == -1)
                    {
                        posicionValida[X, Y] = true;
                    }
                }
                if (!posicionValida[X, Y])
                {
                    tablero[X, Y] = -1;
                    this.PosXminas[i] = X;
                    this.PosYminas[i] = Y;
                    i++;
                }
            }
        }
        public void ColocarValores(int[,] tablero)
        {                 // N   NE  E  SE  S  SO  O  NO
            int[] FilaX = { -1, -1, 0, 1, 1, 1, 0, -1 };
            int[] ColumY = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int f = 0;
            int c = 0;

            for (int i = 0; i < minas; i++)
                for (int j = 0; j < FilaX.Length; j++)
                {
                    f = PosXminas[i] + FilaX[j];
                    c = PosYminas[i] + ColumY[j];
                    if (f >= 0 && f < tablero.GetLength(0) && c >= 0 && c < tablero.GetLength(1))
                    {
                        if (tablero[f, c] != tablero[PosXminas[i], PosYminas[i]])
                            tablero[f, c]++;
                    }                   
                }                                       
        }
        public void GenerarTablero(int[,] tablero)
        {
            ColocarMinas(tablero);
            ColocarValores(tablero);
        }
        public void DescubrirCasillas(int x, int y)
        {                // N   NE  E  SE  S  SO  O  NO
            int[] FilaX = { -1, -1, 0, 1, 1, 1, 0, -1 };
            int[] ColumY = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int f = 0;
            int c = 0;

            if (tablero[x, y] != 0)
                return;

                for (int i = 0; i < FilaX.Length; i++)
                {
                    f = x + FilaX[i];
                    c = y + ColumY[i]; 
                    if (f >= 0 && f < tablero.GetLength(0) && c >= 0 && c < tablero.GetLength(1))
                    {
                        if (!celda[f,c])
                        {                           
                            celda[f,c] = true;
                                                     
                            DescubrirCasillas(f, c);
                        }
                    }
                }
            
                

        }
        public void Flags(int x, int y)
        {
            if (!flag[x, y] && !celda[x, y] && !Interrogacion[x,y])
            {
                flag[x, y] = true;
                cantidadDbanderas--;
            }
            else
            {
                flag[x, y] = false;           
                cantidadDbanderas++;
                Interrogaciones(x, y);
            }
        }
        public void Interrogaciones(int x, int y)
         {
             if (!interrogacion[x, y] && !celda[x, y])
                 interrogacion[x, y] = true;
             else
             {
                 interrogacion[x, y] = false;
                 cantidadDbanderas--;
             }
         }
        public void DesFlags()
        {
            flag = new bool[filas, columnas];
        }
        public void MinaError(int x, int y)
        {
            tablero[x, y] = -3;
        }
        public void UltimaMina(int x, int y)
        {
            Tablero[x, y] = -2;
        }
        public void MostrarMinas()
        {
            for (int i = 0; i < posYminas.Length; i++)
            {
                if (!Celda[posXminas[i], posYminas[i]])
                    Celda[posXminas[i], posYminas[i]] = true;
            }
        }
        public void OcultarMinas()
        {
            for (int i = 0; i < posYminas.Length; i++)
            {
                if (Celda[posXminas[i], posYminas[i]])
                    Celda[posXminas[i], posYminas[i]] = false;
            }

        } 
        public WinCondition Juego(int x , int y)
        {
            if (!primerClick)
            {
                primerClick = true;
                PosPrimerClick[0] = x;
                PosPrimerClick[1] = y;
                GenerarTablero(tablero);
            }

            if (!celda[x, y])
                celda[x, y] = true;
                DescubrirCasillas(x, y);

                if (tablero[x, y] == -1)
                    return WinCondition.Loose;

                for (int i = 0; i < tablero.GetLength(0); i++)
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        if (tablero[i, j] == -1 || tablero[i, j] == -3) continue;
                        if (!celda[i, j])
                            return WinCondition.KeepPlaying;
                    }
                return WinCondition.Win;              
        }

        #endregion

        public enum WinCondition
        { 
            Win,
            Loose,
            KeepPlaying,
        }
    }
}
