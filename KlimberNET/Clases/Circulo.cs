using KlimberNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimberNet.Clases
{
    public class Circulo : IForma
    {
        private readonly decimal _lado;
        private int _tipo;

        public Circulo(decimal lado)
        {
            _lado = lado;
            _tipo = (int)FormaGeometricaEnum.Circulo;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }
        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public int GetTipo()
        {
            return _tipo;
        }
    }
}
