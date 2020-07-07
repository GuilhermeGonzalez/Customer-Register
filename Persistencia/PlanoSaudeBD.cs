using Proj_Aula_BD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Persistencia
{
    class PlanoSaudeBD
    {
        private Banco bancoDeDados;

        public PlanoSaudeBD(Banco banco)
        {
            this.bancoDeDados = banco;
        }

        public void incluir(PlanoSaude plano)
        {
            string sql = "insert into plano_saude(codigo,descricao, vigencia_ini, vigencia_fim) values(@pcodigo,@pdescricao,@pvigencia_ini,@pvigencia_fim)";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pcodigo", plano.Codigo,"@pdescricao", plano.Descricao, "@pvigencia_ini", plano.Vigencia_ini, "@pvigencia_fim", plano.Vigencia_fim);
            this.bancoDeDados.Desconecta();
        }

        public void alterar(PlanoSaude plano)
        {
            string sql = "update plano_saude set descricao = @pdescricao, vigencia_ini = @pvigencia_ini, vigencia_fim = @pvigencia_fim where codigo = @pcodigo";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pdescricao", plano.Descricao, "@pvigencia_ini", plano.Vigencia_ini, "@pvigencia_fim", plano.Vigencia_fim, "@pcodigo", plano.Codigo);
            this.bancoDeDados.Desconecta();
        }

        public void excluir(PlanoSaude plano)
        {
            string sql = "Delete from plano_saude where codigo = @pcodigo";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pcodigo", plano.Codigo);
            this.bancoDeDados.Desconecta();
        }

        public PlanoSaude consulta(int cod)
        {
            string sql = "Select * from plano_saude where codigo = @pcodigo";
            DataTable dados;
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@pcodigo", cod);
            if(dados.Rows.Count > 0)
            {
                PlanoSaude resultadoPlano = new PlanoSaude(Convert.ToInt32(dados.Rows[0][0].ToString()),
                                                                           dados.Rows[0][1].ToString(),
                                                                           Convert.ToDateTime(dados.Rows[0][2]),
                                                                           Convert.ToDateTime(dados.Rows[0][3]));
                return resultadoPlano;
            }
            else
            {
                return null;
            }
        }

        public List<PlanoSaude> consulta(string termo)
        {
            string sql = "Select * from plano_saude where codigo like @ptermo";
            DataTable dados;
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@ptermo", "%" + termo + "%");
            this.bancoDeDados.Desconecta();

            List<PlanoSaude> planos = new List<PlanoSaude>();
            for(int i=0; i < dados.Rows.Count; i++)
            {
                DataRow linha = dados.Rows[i];
                PlanoSaude plano = new PlanoSaude(Convert.ToInt32(linha[0].ToString()),
                                                                  linha[1].ToString(),
                                               Convert.ToDateTime(linha[2]),
                                               Convert.ToDateTime(linha[3]));
                planos.Add(plano);
            }
            return planos;
        }

    }
}
