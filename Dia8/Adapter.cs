using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia8.Models;

namespace Dia8
{
    internal class Adapter : Informante
    {
        Receptor receptor = new Receptor();

        public override void GuardaEnXML(List<Venta> li)
        {
            Console.WriteLine("Cambio los datos de XML a JSON");
            receptor.Recibodatos("Los datos estaban en XML y ahora los recibo en JSON");
            receptor.Muestro();
        }
    }
}
