using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dia8.Models;

namespace Dia8
{
    public abstract class Informante
    {
        public List<Venta> ventas= new List<Venta>();


        public abstract void GuardoArchivo(string archivoXml);
    }
}