using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Modelo
{

    public class Titular
    {
        private string cpf_tit;
        private string nome;
        private DateTime dt_nasc;
        private string estado_civil;
        private string email;
        private string telefone;
        private string celular;
        private string cidade;
        private string endereco;
        private string uf;
        private string sexo;
        private PlanoSaude plano;

        public Titular(string cpf_tit, string nome, DateTime dt_nasc, string estado_civil, string email, string telefone, string celular, string cidade, string endereco, string uf, string sexo, PlanoSaude plano)
        {
            this.cpf_tit = cpf_tit;
            this.nome = nome;
            this.dt_nasc = dt_nasc;
            this.estado_civil = estado_civil;
            this.email = email;
            this.telefone = telefone;
            this.celular = celular;
            this.cidade = cidade;
            this.endereco = endereco;
            this.uf = uf;
            this.sexo = sexo;
            this.plano = plano;
        }

        public string Cpf_tit { get => cpf_tit; set => cpf_tit = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Dt_nasc { get => dt_nasc; set => dt_nasc = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public PlanoSaude Plano { get => plano; set => plano = value; }
    }
}
