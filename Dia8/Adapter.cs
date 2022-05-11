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

        public override void GuardoArchivo(string archivoXml)
        {
            Console.WriteLine("El adapter recibe: " + archivoXml);
            string aux = Transformo(archivoXml);
            Console.WriteLine(aux);
            receptor.Recibodatos(aux);
        }
        private string Transformo(string archivoXml)
        {
            archivoXml = "Hago el cambio de XML a JSON en el adapter";
            Console.WriteLine(archivoXml);
            string archivoJSON = "Archivo JSON";
            return archivoJSON;
        }
    }
}
