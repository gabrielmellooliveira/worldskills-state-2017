using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC2017.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativa { get; set; }

        public Perfil Perfil { get; set; }
        public int IdPerfil { get; set; }
        public Idioma Idioma { get; set; }
        public int IdIdioma { get; set; }
    }
}
