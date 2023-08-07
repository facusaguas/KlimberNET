using KlimberNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimberNet.Clases
{
    public class Cuadrado : IForma
    {
        private readonly decimal _lado;
        private int _tipo;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
            _tipo = (int)FormaGeometricaEnum.Cuadrado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }
        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
        public int GetTipo()
        {
            return _tipo;
        }
    }
}
