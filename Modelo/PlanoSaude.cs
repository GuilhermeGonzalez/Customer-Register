using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Modelo
{
    [Serializable]
    public class PlanoSaude
    {
        private int codigo;
        private string descricao;
        private DateTime vigencia_ini;
        private DateTime vigencia_fim;

        public PlanoSaude(int codigo, string descricao, DateTime vigencia_ini, DateTime vigencia_fim)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.vigencia_ini = vigencia_ini;
            this.vigencia_fim = vigencia_fim;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Vigencia_ini { get => vigencia_ini; set => vigencia_ini = value; }
        public DateTime Vigencia_fim { get => vigencia_fim; set => vigencia_fim = value; }

        public override string ToString()
        {
            return Descricao; 
        }
    }
}
