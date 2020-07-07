using Proj_Aula_BD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Persistencia
{
    class TitularBD
    {
        private Banco bancoDeDados;


        public TitularBD(Banco banco)
        {
            this.bancoDeDados = banco;
        }

        public void incluir(Titular titular)
        {
            bancoDeDados.Conecta();
            string sql = "insert into titular(cpf_tit,nome,dt_nasc,estado_civil,email,telefone,celular,cidade,endereco,uf,sexo,codigo_plano)"+
                         "values(@pcpt_tit,@pnome,@pdt_nasc,@pestado_civil,@pemail,@ptelefone,@pcelular,@pcidade,@pendereco,@puf,@psexo,@pcodigo_plano)";
            bancoDeDados.ExecuteNonQuery(sql, "@pcpf_tit", titular.Cpf_tit,
                                              "@pnome", titular.Nome,
                                              "@pdt_nasc",titular.Dt_nasc,
                                              "@pestado_civil",titular.Estado_civil, 
                                              "@pemail",titular.Email, 
                                              "@ptelefone",titular.Telefone, 
                                              "@pcelular",titular.Celular, 
                                              "@pcidade",titular.Cidade, 
                                              "@pendereco",titular.Endereco, 
                                              "@puf",titular.Uf, 
                                              "@psexo",titular.Sexo, 
                                              "@pcodigo_plano",titular.Plano.Codigo);
            //titular.Cpf_tit = bancoDeDados.GetIdentity();
            bancoDeDados.Desconecta();
        }

        public void alterar(Titular titular)
        {
            string sql = "update titular set nome = @pnome, dt_nasc = @pdt_nasc, estado_civil = @pestado_civil, email = @pemail, telefone = @ptelefone, celular = @pcelular, cidade = @pcidade, endereco = @pendereco, uf = @puf, sexo = @psexo, codigo_plano = @pcodigo_plano where cpf_tit = @pcpf_tit";
            bancoDeDados.Conecta();
            bancoDeDados.ExecuteNonQuery(sql, "@pnome", titular.Nome, "@pdt_nasc", titular.Dt_nasc, "@pestado_civil", titular.Estado_civil, "@pemail", titular.Email, "@ptelefone", titular.Telefone, "@pcelular", titular.Celular, "@pcidade", titular.Cidade, "@pendereco", titular.Endereco, "@puf", titular.Uf, "@psexo", titular.Sexo, "@pcodigo_plano", titular.Plano.Codigo,"@pcpf_tit",titular.Cpf_tit);
            bancoDeDados.Desconecta();
        }

        public void excluir(Titular titular)
        {
            string sql = "Delete from titular where cpf_tit = @pcpf_tit";
            bancoDeDados.Conecta();
            bancoDeDados.ExecuteNonQuery(sql, "@pcpf_tit", titular.Cpf_tit);
            bancoDeDados.Desconecta();
        }

        public Titular consulta(int cpf)
        {
            string sql = "Select * from titular where cpf_tit = @pcpf";
            DataTable dados;
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@pcpf", cpf);
            if (dados.Rows.Count > 0)
            {
                PlanoSaudeBD psBD = new PlanoSaudeBD(this.bancoDeDados);
                PlanoSaude planoCliente = psBD.consulta(Convert.ToInt32(dados.Rows[0][11].ToString()));

                Titular resultadoTitular = new Titular(dados.Rows[0][0].ToString(),
                                                       dados.Rows[0][1].ToString(),
                                                       Convert.ToDateTime(dados.Rows[0][2]),
                                                       dados.Rows[0][3].ToString(),
                                                       dados.Rows[0][4].ToString(),
                                                       dados.Rows[0][5].ToString(),
                                                       dados.Rows[0][6].ToString(),
                                                       dados.Rows[0][7].ToString(),
                                                       dados.Rows[0][8].ToString(),
                                                       dados.Rows[0][9].ToString(),
                                                       dados.Rows[0][10].ToString(),planoCliente);
                return resultadoTitular;
            }
            else
            {
                return null;
            }
        }

        public List<Titular> consulta(string termo)
        {
            string sql = "Select * from titular where nome like @ptermo";
            DataTable dados;
            List<Titular> titulares = new List<Titular>();
            this.bancoDeDados.Conecta();
            this.bancoDeDados.ExecuteQuery(sql, out dados, "@ptermo", "%" + termo + "%");
            if(dados.Rows.Count > 0)
            {
                for (int i = 0; i < dados.Rows.Count; i++)
                {

                    PlanoSaudeBD psBD = new PlanoSaudeBD(this.bancoDeDados);
                    PlanoSaude planoCliente = psBD.consulta(Convert.ToInt32(dados.Rows[i][11].ToString()));
                    Titular titular = new Titular(dados.Rows[i][0].ToString(),
                                                           dados.Rows[i][1].ToString(),
                                                           Convert.ToDateTime(dados.Rows[i][2]),
                                                           dados.Rows[i][3].ToString(),
                                                           dados.Rows[i][4].ToString(),
                                                           dados.Rows[i][5].ToString(),
                                                           dados.Rows[i][6].ToString(),
                                                           dados.Rows[i][7].ToString(),
                                                           dados.Rows[i][8].ToString(),
                                                           dados.Rows[i][9].ToString(),
                                                           dados.Rows[i][10].ToString(), planoCliente);
                    titulares.Add(titular);
                }
            }
            
            return titulares;
        }

    }
}
