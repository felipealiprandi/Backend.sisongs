using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Ong
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }
        public string? telefone { get; set; }
        public string? email { get; set; }
    }
}
