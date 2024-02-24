using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Quadrato : Rettangolo
    {
        public Quadrato(int _base, int altezza, Punto punto) : base(_base, _base, punto) { }
        public override string ToString()
        {
            return String.Format($"QUADRATO. punto alto a sinistra:{punto.ToString()} lato: {_base}, perimetro: {Perimetro} area: {Area}");
        }
    }
}
