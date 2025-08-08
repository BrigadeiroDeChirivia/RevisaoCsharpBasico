using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTres.Modelos
{
    public struct Point
    {
        private int _x;
        private int _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        public void AtribuirNovasCoordenadas(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
