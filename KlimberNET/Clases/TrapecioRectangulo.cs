using KlimberNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimberNet.Clases
{
    public class TraprecioRectangulo : IForma
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _hip;
        private int _tipo;

        public TraprecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura, decimal hip)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _hip = hip;

            _tipo = (int)FormaGeometricaEnum.Trapecio;
        }

        public decimal CalcularArea()
        {
            return _altura * ((_baseMayor * _baseMenor) / 2);
        }
        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _altura + _hip;
        }
        public int GetTipo()
        {
            return _tipo;
        }
    }
}
