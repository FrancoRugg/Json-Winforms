using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string CoD_ALFA { get; set; }
        public string Codigo { get; set; }
        public string Detalle { get; set; }
        public string Rubro { get; set; }
        public string Subrubro { get; set; }
        public string Modelo { get; set; }
        public string NoM_Marca { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public string PlantI_Rec { get; set; }
        public string Cuenta { get; set; }
        public string Cta_Costo { get; set; }
        public string Cta_Mercad { get; set; }
        public string Cta_Ajupos { get; set; }
        public string Cta_Ajuneg { get; set; }
        public string Cta_Ajuint { get; set; }
    }
}
