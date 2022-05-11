using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8.Models
{
    internal class Creador
    {
        public static ConnectionFactory CreadorConexion(int num)
        {
            switch (num)
            {
                case 0:
                    return new ConexionMySql();
                    break;
                    case 1:
                    return new ConexionSql();
                    break;
                case 2:
                    return new ConexionOracle();
                default:
                    return null;
            }
                
        }
    }
}
