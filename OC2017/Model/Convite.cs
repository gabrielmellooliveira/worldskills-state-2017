using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Model
{
    public class Convite
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public int IdEvento { get; set; }
    }
}
