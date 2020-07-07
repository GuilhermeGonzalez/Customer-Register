
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Modelo
{
    class Cidade
    {
        private int codigo;
        private string nome;
        private string uf;

        public Cidade(int codigo, string nome, string uf)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.uf = uf;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Uf { get => uf; set => uf = value; }


        public override string ToString()
        {
            return Nome + "/" + Uf;
        }
    }
}
