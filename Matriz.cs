
namespace ArreglosMultidimensionales_G2_2024_II
{
    internal class Matriz
    {
        #region Atributos
        private int m;
        private int n;


        #endregion
        #region Propiedades

        public int M { get => m;
            set
            {
                if (value > 1)
                    m = value;
                else
                    m = 2;
            }
        }
        public int N { get => n;
            set {
                if (value > 1)
                    n = value;
                else
                    n = 2;
            } 
        }

        #endregion



    }
}
