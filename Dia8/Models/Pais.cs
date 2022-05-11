using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8.Models
{
     class Pais
    {
        private List<string> listaProv = new List<string>();
        public List<string> ListaProv { get => listaProv; }

        private static Pais _instance = null;
        private Pais()
        {           
        }
        public void AgregaPaises()
        {
            _instance.listaProv.Add("formosa");
            _instance.listaProv.Add("Chubut");
            _instance.listaProv.Add("Chaco");
            _instance.listaProv.Add("Misiones");
        }
        public static Pais GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Pais();
            }
            return _instance;
        }
    }
}
