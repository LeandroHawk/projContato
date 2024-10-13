using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjContato
{
    public class Contatos
    {
        private List<Contato> agenda;
        public List<Contato> Agenda { get => agenda; set => agenda = value; }

        public Contatos()
        {
            Agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            if (c != null && !Agenda.Contains(c))
            {
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public Contato pesquisar(string email)
        {
            foreach (Contato c in Agenda)
            {
                if (c.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }
            return null;
        }

        public bool alterar(Contato c)
        {
            var contatoExistente = pesquisar(c.Email);
            if (contatoExistente != null)
            {
                contatoExistente.Nome = c.Nome;
                contatoExistente.dtNasc = c.dtNasc;
                contatoExistente.Telefones = c.Telefones;
                return true;
            }
            return false;
        }

        public bool remover(Contato c)
        {
            return agenda.Remove(c);
        }

    }
}