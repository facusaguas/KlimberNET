using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimberNet.Interfaces
{
    public interface IForma
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        int GetTipo();
    }
}
