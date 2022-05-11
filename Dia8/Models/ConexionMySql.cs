using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8.Models
{
    internal class ConexionMySql : ConnectionFactory
    {
        public override void Connect()
        {
            Console.WriteLine("Conectando con la clase ConexionMySql");
        }
    }
}
