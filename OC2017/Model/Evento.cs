using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Model
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Site { get; set; }
        public string Data_Inicio { get; set; }
        public string Data_Fim { get; set; }
        public string Valor { get; set; }

        public string Lote_1 { get; set; }
        public string Lote_2 { get; set; }
        public string Lote_3 { get; set; }

        public int IdEndereco { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
