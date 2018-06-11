using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Model
{
    public class Idioma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Foto { get; set; }

        public override string ToString()
        {
            return this.Sigla;
        }
    }
}
