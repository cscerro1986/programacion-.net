using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int y;
        private int x;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        #region METODOS

        public int GetY()
        {
            return this.y;
        }
        public int GetX()
        {
            return this.x;
        }

        #endregion METODOS

    }
}
