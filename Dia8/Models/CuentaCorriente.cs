using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8.Models
{
     class CuentaCorriente
    {
        public int Id { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public CuentaCorriente()
        {
               
        }

        public CuentaCorriente Clonar()
        {
            CuentaCorriente clon = (CuentaCorriente)this.MemberwiseClone();
            return clon;
        }
    }
}
