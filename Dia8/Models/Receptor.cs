using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8.Models
{
    internal class Receptor
    {
        public void Recibodatos(string mensaje)
        {
            Console.WriteLine("Recibi: " + mensaje);
            Console.WriteLine("Guardé: " + mensaje);
        }
    }
}
