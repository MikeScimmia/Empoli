using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Parallelepipido : Rettangolo
    {
        int profondita;
        public Parallelepipido(int _base, int altezza, Punto punto, int profondita) : base(_base, altezza, punto)
        {
            this.profondita = profondita;
        }
        public int Volume
        {
            get { return CalcoloVolume(); }
        }
        private int CalcoloVolume()
        {
            return _base * altezza * profondita;
        }
        public override string ToString()
        {
            return String.Format($"PARALLELEPIPIDO. punto alto a sinistra:{punto.ToString()} base: {_base}, altezza: {altezza} perimetro: {Perimetro} area: {Area} volume: {Volume}");
        }
    }
}
