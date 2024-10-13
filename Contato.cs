using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjContato
{
    public class Contato
    {
        private string email { get; set; }
        private string nome { get; set; }
        private Data DtNasc { get; set; }
        private List<Telefone> telefones;

        //Construtor
        public Contato()
        {
            this.telefones = new List<Telefone>();
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public Data dtNasc { get => dtNasc; set => dtNasc = value; }
        public List<Telefone> Telefones { get => telefones; set => telefones = value; }

        public int GetIdade()
        {
            DateTime now = DateTime.Now;
            int idade = now.Year - dtNasc.Ano;

            if (now.Month < dtNasc.Mes || (now.Month == dtNasc.Mes && now.Day < dtNasc.Dia))
            {
                idade--;
            }
            return idade;
        }

        public void addTelefone(Telefone t)
        {
            telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            foreach (Telefone t in telefones)
            {
                if (t.Principal)
                {
                    return t.Numero;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"{Nome} - {Email} - {DtNasc} - {getTelefonePrincipal()}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }
            Contato c = (Contato)obj;
            return email.Equals(c.email);
        }



    }

}