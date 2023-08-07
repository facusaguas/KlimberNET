using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KlimberNet.Clases
{
    internal class Idioma
    {
        public CultureInfo SetIdioma(int idioma)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            switch (idioma)
            {
                case (int)IdiomasEnum.Espanol:
                    ci = CultureInfo.CreateSpecificCulture("es-ES");
                    break;
                case (int)IdiomasEnum.Ingles:
                    ci = CultureInfo.CreateSpecificCulture("en-US");
                    break;
                case (int)IdiomasEnum.Italiano:
                    ci = CultureInfo.CreateSpecificCulture("it-IT");
                    break;
                default:
                    break;
            }
            return ci;
        }
    }
}
