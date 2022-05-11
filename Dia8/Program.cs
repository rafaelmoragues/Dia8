using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia8.Models;

namespace Dia8
{
    internal class Program
    {
        void Ej1()
        {
            Pais pais = Pais.GetInstance();
            pais.AgregaPaises();
            foreach (string item in pais.ListaProv)
            {
                Console.WriteLine(item);
            }
        }

        void Ej2()
        {
            ConnectionFactory oConn = Creador.CreadorConexion(1);
            oConn.Connect();
        }
        void Ej3()
        {
            CuentaCorriente cuenta1 = new CuentaCorriente();
            cuenta1.Id = 1;
            cuenta1.Titular = "rafa";
            cuenta1.Saldo = 2500784.25;

            CuentaCorriente cuentaClon = cuenta1.Clonar();
            Console.WriteLine(cuentaClon.Id);
            Console.WriteLine(cuentaClon.Titular);
            Console.WriteLine(cuentaClon.Saldo);
        }

        void Ej4()
        {
            Adapter ad = new Adapter();
            ad.GuardoArchivo("Un archivo xml");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Ej4();
            Console.ReadKey();

            

        }
    }
}
