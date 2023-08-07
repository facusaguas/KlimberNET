using KlimberNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimberNet.Clases
{
    public class TrianguloEquilatero : IForma
    {
        private readonly decimal _lado;
        private int _tipo;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
            _tipo = (int)FormaGeometricaEnum.Triangulo;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }
        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
        public int GetTipo()
        {
            return _tipo;
        }
    }
}
