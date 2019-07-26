using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja CajaNueva = new Caja();
            
            
            CajaNueva.altura = "30 cm";
            CajaNueva.ancho = "50 cm";
            CajaNueva.profundidad = "45 cm";
            CajaNueva.MostrarDatos();

            Caja np2 = new Caja();
            CajaNueva.color = "Verde";
            CajaNueva.altura = "50 cm";
            CajaNueva.ancho = "40 cm";
            CajaNueva.profundidad = "55 cm";
            CajaNueva.MostrarDatos();

            Caja np3 = new Caja();
            CajaNueva.color = "Rojo";
            CajaNueva.altura = "45 cm";
            CajaNueva.ancho = "45 cm";
            CajaNueva.profundidad = "30 cm";
            CajaNueva.material = "Metal";
            CajaNueva.estructura = "Tapa";
            CajaNueva.empresa = "Industrias del Patio SA";
            CajaNueva.abrir = "Arriba";
            CajaNueva.MostrarDatos();

            Caja np4 = new Caja();
            CajaNueva.color = "Café";
            CajaNueva.altura = "80 cm";
            CajaNueva.ancho = "80 cm";
            CajaNueva.profundidad = "50 cm";
            CajaNueva.material = "Cartón";
            CajaNueva.estructura = "Solapas";
            CajaNueva.empresa = "El Camino SA";
            CajaNueva.abrir = "Arriba";
            CajaNueva.MostrarDatos();


        }

        /// <summary>
        /// ESta clase puede ser utilizada para crear cajas
        /// </summary>
        public class Caja
        {
            public Caja()
            {

            }

            public string color { get; set; }
            public string altura { get; set; }
            public string ancho { get; set; }
            public string profundidad { get; set; }
            public string material { get; set; }
            public string estructura { get; set; }
            public string empresa { get; set; }
            public string abrir { get; set; }

            public void MostrarDatos()
            {
                Console.WriteLine();
                Console.WriteLine("color: " + color + " altura: " + altura + " Acho: " + ancho + " Profundidad: " + profundidad + " Material: " + material +  " Estructura: " + estructura + " Empresa: " + empresa + " Se abre en el lado de: " + abrir );
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

        