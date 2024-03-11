using System;


namespace ArreglosMultidimensionales_G2_2024_II
{
    internal class Multidimensional:Matriz
    {
        private float[,] A;


        /// <summary>
        /// Constructor que define el tamaño de la Matriz A
        /// </summary>
        /// <param name="M">Número de Renglones</param>
        /// <param name="N">Número de Columnas</param>
        public Multidimensional(int M, int N)
        {
            this.M = M;
            this.N = N;
            A = new float[M, N];
        }


        public static Multidimensional Leer(string A)
        {
            //1,2,3;5,6,7
            string[] renglones = A.Split(';');
            string[] columnas = renglones[0].Split(',');

            Multidimensional matriz = new Multidimensional(renglones.Length, columnas.Length);

            for (int i=0; i < renglones.Length; i++)
            {
                columnas = renglones[i].Split(',');
                for(int j=0; j < columnas.Length; j++)
                {
                    matriz.A[i, j] = float.Parse(columnas[j]);
                }

            }
            return matriz;

 
        }

        public override string ToString()
        {
            //1 2 3
            //5 6 7
            string A = "";
            for ( int i=0; i < M; i++)
            {
                for(int j=0; j < N; j++)
                {
                    A = A + " " + this.A[i, j].ToString();
                }
                A = A + "\n";
            }
            
            
            return A;
        }


    }
}
