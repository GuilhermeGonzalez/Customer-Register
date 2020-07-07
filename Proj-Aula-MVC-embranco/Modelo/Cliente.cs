using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Modelo
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private DateTime dataNasc;
        private string telefone;
        private string cpf;
        private string email;
        private Cidade cidade;

        public Cliente(int codigo, string nome, DateTime dataNasc, string telefone, string cpf, string email, Cidade cidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.telefone = telefone;
            this.cpf = cpf;
            this.email = email;
            this.cidade = cidade;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        internal Cidade Cidade { get => cidade; set => cidade = value; }
    }
}
