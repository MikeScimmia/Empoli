using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Rettangolo
    {
        protected int _base;
        protected int altezza;
        protected Punto punto;
        public Rettangolo(int _base, int altezza, Punto punto)
        {
            this._base = _base;
            this.altezza = altezza;
            this.punto = punto;
        }
        public int Area
        {
            get { return CalcoloArea(); }
        }
        public int Perimetro
        {
            get { return CalcoloPerimetro(); }
        }
        
        protected int CalcoloArea()
        {
            return _base * altezza;
        }
        protected int CalcoloPerimetro()
        {
            return _base * 2 + altezza * 2;
        }
        public override string ToString()
        {
            return String.Format($"RETTANGOLO. punto alto a sinistra:{punto.ToString()} base: {_base}, altezza: {altezza} perimetro: {Perimetro} area: {Area}");
        }
    }
}
