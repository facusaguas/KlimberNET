/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using KlimberNET.Recursos;
using KlimberNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlimberNet.Clases
{
    public class FormaGeometrica
    {
        public IForma _forma;
        private static CultureInfo _ci;

        public FormaGeometrica(IForma forma)
        {
            _forma = forma;
        }
        public decimal Perimetro => _forma.CalcularPerimetro();
        public decimal Area => _forma.CalcularArea();
        public int TipoForma => _forma.GetTipo();
        public string TipoNombre => Enum.GetName(typeof(FormaGeometricaEnum), _forma.GetTipo());

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {

            _ci = new Idioma().SetIdioma(idioma);
            var sb = new StringBuilder();
            int totalFormas = 0;
            decimal totalPerimetros = 0;
            decimal totalAreas = 0;

            if (!formas.Any())
            {
                sb.Append("<h1>" + Strings.ResourceManager.GetString("ListaVacia", _ci) + "</h1>");
            }
            else
            {
                sb.Append("<h1>" + Strings.ResourceManager.GetString("Titulo", _ci) + "</h1>");

                foreach (int f in Enum.GetValues(typeof(FormaGeometricaEnum)))
                {
                    List<FormaGeometrica> formaFilter = formas.Where(c => c.TipoForma == f).ToList();
                    int cantidad = formaFilter.Count();
                    totalFormas += cantidad;
                    decimal perimetro = formaFilter.Sum(v => v.Perimetro);
                    totalPerimetros += perimetro;
                    decimal area = formaFilter.Sum(v => v.Area);
                    totalAreas += area;
                    string nombre = Enum.GetName(typeof(FormaGeometricaEnum), f);
                    sb.Append(FormateaLinea(cantidad, area, perimetro, nombre));
                }
                sb.Append("TOTAL:<br/>");
                sb.Append(totalFormas + " " + Strings.ResourceManager.GetString("Formas", _ci) + " ");
                sb.Append(Strings.ResourceManager.GetString("Perimetro", _ci) + " " + (totalPerimetros).ToString("#.##") + " ");
                sb.Append(Strings.ResourceManager.GetString("Area", _ci) + " " + (totalAreas).ToString("#.##"));

            }
            return sb.ToString();
        }
        private static string FormateaLinea(int cantidad, decimal area, decimal perimetro, string nombre)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {ObtenerForma(cantidad, nombre)} | {Strings.ResourceManager.GetString("Area", _ci)} {area:#.##} | {Strings.ResourceManager.GetString("Perimetro", _ci)} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string ObtenerForma(int cantidad, string nombre)
        {
            return cantidad == 1 ? Strings.ResourceManager.GetString(nombre, _ci) : Strings.ResourceManager.GetString(nombre + "s", _ci);
        }

    }
}
