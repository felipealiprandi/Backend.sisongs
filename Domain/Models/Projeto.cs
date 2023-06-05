using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Projeto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string dataInicio { get; set; }
        public string dataFim { get; set; }
        public string local { get; set; }

    }
}
