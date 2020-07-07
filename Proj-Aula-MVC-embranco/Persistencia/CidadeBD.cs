using Proj_Aula_BD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Persistencia
{
    class CidadeBD
    {
        private Banco bancoDeDados;

        public CidadeBD(Banco banco)
        {
            this.bancoDeDados = banco;
        }

        public void incluir(Cidade cidade)
        {
            string sql = "insert into cidade(cid_nome, cid_uf) values(@nome, @puf)";
            this.bancoDeDados.Conecta();

            this.bancoDeDados.ExecuteNonQuery(sql, "@pnome", cidade.Nome, "@puf", cidade.Uf);

            this.bancoDeDados.Desconecta();
        }

        public void alterar(Cidade cidade)
        {
            string sql = "update cidade set cid_nome = @pnome, cid_uf = @puf where cid_cod = @pcodigo";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pnome", cidade.Nome, "@puf", cidade.Uf, "@pcodigo");            
            this.bancoDeDados.Desconecta();
        }

        public void excluir(Cidade cidade)
        {
            string sql = "delete from cidade where cid_cod = @pcodigo";
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteNonQuery(sql, "@pcodigo", cidade.Codigo);
            this.bancoDeDados.Desconecta();
        }

        public Cidade consulta(int codigo)
        {
            string sql = "Select * from cidade where cid_cod = @pcodigo";
            DataTable dados;
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@pcodigo", codigo);
            if(dados.Rows.Count > 0)
            {
                Cidade resultadoCidade = new Cidade(Convert.ToInt32(dados.Rows[0][1].ToString()),
                                                    dados.Rows[0][1].ToString(),
                                                    dados.Rows[0][2].ToString());
                return resultadoCidade;
            }
            else
            {
                return null;
            }
            this.bancoDeDados.Desconecta();
        }

        public List<Cidade> consulta(string termo)
        {
            string sql = "Select * from cidade where cid_cod like @ptermo order by cid_nome";
            DataTable dados;
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@ptermo", "%" + termo + "%");
            this.bancoDeDados.Desconecta();
            List<Cidade>  cidades = new List<Cidade>();
            for(int i = 0; i < dados.Rows.Count; i++)
            {
                DataRow linha = dados.Rows[i];
                Cidade cidade = new Cidade(Convert.ToInt32(linha[0].ToString()),
                                            linha[1].ToString(),
                                            linha[2].ToString());
                cidades.Add(cidade);
            }
            return cidades;
        }
    }
}
